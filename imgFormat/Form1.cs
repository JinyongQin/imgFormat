using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Text.RegularExpressions;
using System.Drawing.Imaging;

namespace imgFormat
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            this.Text = "Markdown图片批量处理工具";
        }

        private void Log(string message)
        {
            log_box.AppendText($"{DateTime.Now:HH:mm:ss} {message}{Environment.NewLine}");
        }

        private void btnProcessMarkdown_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog ofd = new OpenFileDialog())
            {
                ofd.Filter = "Markdown 文件|*.md";
                ofd.Multiselect = true;
                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    string prefix = prefix_box.Text.Trim();
                    if(num_box.Text.Length > 0 ) {
                        if (!int.TryParse(num_box.Text.Trim(), out _))
                        {
                            MessageBox.Show("起始编号必须是数字！", "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return;
                        }
                    }
                    if(length_box.Text.Length > 0)
                    {
                        if (!int.TryParse(length_box.Text.Trim(), out _))
                        {
                            MessageBox.Show("编号长度必须是数字！", "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return;
                        }
                    }
                    int startNum = 1;
                    int.TryParse(num_box.Text.Trim(), out startNum);
                    int imgIndex = startNum;
                    int name_len = 7;
                    int.TryParse(length_box.Text.Trim(), out name_len);

                    foreach (var file in ofd.FileNames)
                    {
                        string mdDir = Path.GetDirectoryName(file);
                        string content = File.ReadAllText(file);
                        var matches = Regex.Matches(content, @"!\[.*?\]\((.*?)\)");
                        foreach (Match match in matches)
                        {
                            string imgPath = match.Groups[1].Value;
                            //获取 图片路径
                            string absImgPath = Path.IsPathRooted(imgPath) ? imgPath : Path.Combine(mdDir, imgPath);

                            if (File.Exists(absImgPath))
                            {
                                string numStr = imgIndex.ToString();
                                int totalLen = prefix.Length + numStr.Length;
                                string zeros = totalLen < name_len ? new string('0', name_len - totalLen) : "";
                                string newImgName = $"{prefix}{zeros}{numStr}.jpg";

                                string newImgPath = Path.Combine(Path.GetDirectoryName(absImgPath), newImgName);
                                try
                                {
                                    using (var img = Image.FromFile(absImgPath))
                                    {
                                        img.Save(newImgPath, ImageFormat.Jpeg);
                                    }
                                    // 替换 markdown 内容中的图片路径
                                    string newImgRelPath = Path.Combine(Path.GetDirectoryName(imgPath) ?? "", newImgName)
                                        .Replace("\\", "/");
                                    content = content.Replace(imgPath, newImgRelPath);
                                    Log($"图片 {imgPath} 已重命名并转换为 {newImgName}");
                                    try
                                    {
                                        File.Delete(absImgPath);
                                        Log($"已删除原图片: {imgPath}");
                                    }
                                    catch (Exception ex)
                                    {
                                        Log($"删除原图片 {imgPath} 时出错: {ex.Message}");
                                    }
                                    imgIndex++;
                                }
                                catch (Exception ex)
                                {
                                    Log($"处理图片 {imgPath} 时出错: {ex.Message}");
                                }
                            }
                            else
                            {
                                Log($"未找到图片文件: {imgPath}");
                            }
                        }
                        File.WriteAllText(file, content);
                        Log($"已更新Markdown文件: {file}");
                    }
                    MessageBox.Show("处理完成！");
                }
            }
        }

        private void btnProcessFolder_Click(object sender, EventArgs e)
        {
            using (FolderBrowserDialog fbd = new FolderBrowserDialog())
            {
                if (fbd.ShowDialog() == DialogResult.OK)
                {
                    string prefix = prefix_box.Text.Trim();
                    if (num_box.Text.Length > 0)
                    {
                        if (!int.TryParse(num_box.Text.Trim(), out _))
                        {
                            MessageBox.Show("起始编号必须是数字！", "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return;
                        }
                    }
                    if (length_box.Text.Length > 0)
                    {
                        if (!int.TryParse(length_box.Text.Trim(), out _))
                        {
                            MessageBox.Show("编号长度必须是数字！", "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return;
                        }
                    }
                    int startNum = 1;
                    int.TryParse(num_box.Text.Trim(), out startNum);
                    int imgIndex = startNum;

                    int name_len = 7;
                    int.TryParse(length_box.Text.Trim(), out name_len);

                    var files = Directory.GetFiles(fbd.SelectedPath, "*.*")
                        .Where(
                        f => f.EndsWith(".png") || f.EndsWith(".jpg") || f.EndsWith(".jpeg") || f.EndsWith(".gif") || f.EndsWith(".bmp")
                        );
                    foreach (var file in files)
                    {
                        string numStr = imgIndex.ToString();
                        int totalLen = prefix.Length + numStr.Length;
                        string zeros = totalLen < name_len ? new string('0', name_len - totalLen) : "";
                        string newImgName = $"{prefix}{zeros}{numStr}.jpg";

                        string newFile = Path.Combine(
                            Path.GetDirectoryName(file),
                            newImgName
                        );
                        try
                        {
                            using (var img = Image.FromFile(file))
                            {
                                img.Save(newFile, ImageFormat.Jpeg);
                            }
                            Log($"图片 {file} 已重命名并转换为 {newImgName}");
                            try
                            {
                                File.Delete(file);
                                Log($"已删除原图片: {file}");
                            }
                            catch (Exception ex)
                            {
                                Log($"删除原图片 {file} 时出错: {ex.Message}");
                            }
                            imgIndex++;
                        }
                        catch (Exception ex)
                        {
                            Log($"处理图片 {file} 时出错: {ex.Message}");
                        }
                    }
                    MessageBox.Show("文件夹图片处理完成！");
                }
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.Text = "Markdown图片批量处理工具";
            log_box.Multiline = true;
            log_box.ScrollBars = ScrollBars.Vertical;
            log_box.ReadOnly = true;
        }

        private void prefix_box_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
