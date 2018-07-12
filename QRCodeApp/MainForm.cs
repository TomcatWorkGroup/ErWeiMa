using QRCoder;
using System;
using System.Drawing;
using System.Drawing.Imaging;
using System.Windows.Forms;
using static QRCoder.PayloadGenerator;

namespace QRCodeApp
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
            
        }

        private long start, end;
        private string outputPath = string.Empty;
        private Graphics graphic;
        private Bitmap bitmap;
        private QRCodeGenerator qrGenerator;
        private string fileName; 
       
        private Font font;
        private SolidBrush brush;

        private Bitmap CreateQrImage(string strCode)
        {
            Url generator = new Url(strCode);
            string payload = generator.ToString();

            QRCodeGenerator qrGenerator = new QRCodeGenerator();
            QRCodeData qrCodeData = qrGenerator.CreateQrCode(payload, QRCodeGenerator.ECCLevel.Q);
            QRCode qrCode = new QRCode(qrCodeData);
            Bitmap qrCodeAsBitmap = qrCode.GetGraphic(5, Color.Black, Color.White, null, 15, 6, false);
            return qrCodeAsBitmap;
        }

        private void InitGraphic(Bitmap qrImage)
        {
            bitmap = new Bitmap(qrImage.Width + 30, qrImage.Height + 50);
            graphic = Graphics.FromImage(bitmap);
            graphic.FillRegion(Brushes.White, new Region());
        }

        private void PrintQrImage(Bitmap qrImage, int index, string code)
        {
            if (null == graphic)
            {
                InitGraphic(qrImage);
            }
            graphic.FillRegion(Brushes.White, new Region());
            graphic.DrawImage(qrImage, 15 , 15 );
            graphic.DrawString(code, font, brush, 15, qrImage.Height+25);
        }

        

        private void PrintQrImage(Bitmap qrImage, int index, string code,string suffix)
        {
            if (null == graphic)
            {
                InitGraphic(qrImage);
            }
            graphic.FillRegion(Brushes.White, new Region());
            graphic.DrawImage(qrImage, 15, 15);
            graphic.DrawString(string.Format("{0}-{1}",code,suffix.Substring(5)), font, brush, 15, qrImage.Height + 25);
        }

        private void PrintQrImage(Bitmap qrImage, int index)
        {
            if (null == graphic)
            {
                InitGraphic(qrImage);
            }
            graphic.FillRegion(Brushes.White, new Region());
            graphic.DrawImage(qrImage, 15, 15);
        }
        private void PrintCode(int index,string code)
        {
            var x = index % 10;
            var y = index / 10;

            graphic.DrawString(code, font,brush, x * 200 + 25, y * 220 + 215);
        }

        private string DesCode(string data)
        {
            return EnCoder.EnCoder.Encode(data);
        }

        private void btn_create_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txt_start.Text.Trim()))
            {
                MessageBox.Show("设备起始编号不能为空！", "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (txt_url.Enabled)
            {
                var result = MessageBox.Show("APP下载地址确认正确吗？", "确认", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.No)
                {
                    txt_url.Focus();
                    txt_url.SelectAll();
                    return;
                }
            }


            fileName = DateTime.Now.ToString("yyyyMMddHHmmss");
            var str = Text;
            Text = "正在生成.....";
            btn_create.Enabled = false;
            qrGenerator = new QRCodeGenerator();
            
            end = long.Parse(txt_end.Text);
            var length = end - start + 1;
            var url = txt_url.Text;


            for (int i = 0; i < length; i++)
            {
                string code = (start + i).ToString("D10");

                var desCode = DesCode(code);
                var qr = CreateQrImage(string.Format("{0}{1}", url, desCode));
                PrintQrImage(qr, i, desCode, code);
                bitmap.Save(string.Format(@"{0}\{1}.jpg", outputPath, code), ImageFormat.Jpeg);
                qr.Dispose();
            }

            if (null != graphic)
            {
                bitmap.Dispose();
                graphic.Dispose();
            }

            Text = str;
            btn_create.Enabled = true;
        }

        private void btn_select_path_Click(object sender, EventArgs e)
        {
            if (DialogResult.OK == fbd.ShowDialog())
            {
                outputPath = fbd.SelectedPath;
                txt_output.Text = outputPath;
            }
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            outputPath = Application.StartupPath;
            font = new Font("Arial", 14);
            brush = new SolidBrush(Color.Black);
            txt_url.Text = "http://www.sdcsoft.com.cn/app/gl/gl.apk?id=";
        }

       

        private void txt_start_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txt_start.Text))
                return;

            start = long.Parse(txt_start.Text);
            txt_end.Text = (start + 99).ToString("D10");
        }

        private void rbtn_only_code_CheckedChanged(object sender, EventArgs e)
        {
            txt_url.Enabled = false;
        }

        private void rbtn_image_code_CheckedChanged(object sender, EventArgs e)
        {
            txt_url.Enabled = true;
        }
    }
}
