using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Imaging;
using System.Drawing.Text;
using System.IO;
using System.Linq;
using System.Security;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DrawNumberOnImage
{
    public partial class Form1 : Form
    {
        private readonly OpenFileDialog _dialogSelectFile;
        private readonly OpenFileDialog _dialogOutPutPath;

        public Form1()
        {
            InitializeComponent();
            _dialogSelectFile = new OpenFileDialog();
        }


        private void LblPath_Click(object sender, EventArgs e)
        {

        }

        private void BtnSelectOutFolder_Click(object sender, EventArgs e)
        {
            using (var fbd = new FolderBrowserDialog())
            {
                DialogResult result = fbd.ShowDialog();

                if (result == DialogResult.OK && !string.IsNullOrWhiteSpace(fbd.SelectedPath))
                {
                    lblOutPath.Text = fbd.SelectedPath;
                }
            }
        }

        private void TbGenerate_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty((lblImagePath.Text)))
            {
                MessageBox.Show("Select an image.");
                return;
            }
            if (string.IsNullOrEmpty(lblOutPath.Text))
            {
                MessageBox.Show("Select output path.");
                return;
            }
            if (string.IsNullOrEmpty(tbNumOfImage.Text))
            {
                MessageBox.Show("Enter number of image to be generated.");
                return;
            }
            GenerateImages();
        }

        private void BtnSelectImage_Click(object sender, EventArgs e)
        {
            if (_dialogSelectFile.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    lblImagePath.Text = _dialogSelectFile.FileName;
                }
                catch (SecurityException ex)
                {
                    MessageBox.Show($"Security error.\n\nError message: {ex.Message}\n\n" +
                                    $"Details:\n\n{ex.StackTrace}");
                }
            }
        }

        private void GenerateImages()
        {
            var numbers = Convert.ToInt32(tbNumOfImage.Text);
            for (int i = 0; i < numbers; i++)
            {
                using (var bmp = new Bitmap(lblImagePath.Text))
                {

                    var rectf = new RectangleF(620, -300, bmp.Width, bmp.Height);

                    Graphics g = Graphics.FromImage(bmp);

                    g.SmoothingMode = SmoothingMode.AntiAlias;


                    g.InterpolationMode = InterpolationMode.HighQualityBicubic;

                    g.PixelOffsetMode = PixelOffsetMode.HighQuality;


                    g.TextRenderingHint = TextRenderingHint.AntiAliasGridFit;

                    StringFormat format = new StringFormat()
                    {
                        Alignment = StringAlignment.Center,
                        LineAlignment = StringAlignment.Center
                    };

                    g.DrawString((i+1).ToString(), new Font("Arial", 200), Brushes.Black, rectf, format);

                    using (MemoryStream memory = new MemoryStream())
                    {
                        using (FileStream fs = new FileStream(lblOutPath.Text + "\\"+i+"-"+Path.GetFileName(lblImagePath.Text), FileMode.Create, FileAccess.ReadWrite))
                        {
                            bmp.Save(memory, ImageFormat.Jpeg);
                            byte[] bytes = memory.ToArray();
                            fs.Write(bytes, 0, bytes.Length);
                        }
                    }
                }
            }
        }
    }
}
