namespace QRCodeApp
{
    partial class MainForm
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.btn_create = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_start = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_output = new System.Windows.Forms.TextBox();
            this.btn_select_path = new System.Windows.Forms.Button();
            this.fbd = new System.Windows.Forms.FolderBrowserDialog();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_end = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btn_create
            // 
            this.btn_create.Location = new System.Drawing.Point(375, 126);
            this.btn_create.Name = "btn_create";
            this.btn_create.Size = new System.Drawing.Size(75, 23);
            this.btn_create.TabIndex = 0;
            this.btn_create.Text = "生成";
            this.btn_create.UseVisualStyleBackColor = true;
            this.btn_create.Click += new System.EventHandler(this.btn_create_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 12);
            this.label1.TabIndex = 1;
            this.label1.Text = "开始编号";
            // 
            // txt_start
            // 
            this.txt_start.Location = new System.Drawing.Point(90, 10);
            this.txt_start.MaxLength = 10;
            this.txt_start.Name = "txt_start";
            this.txt_start.Size = new System.Drawing.Size(121, 21);
            this.txt_start.TabIndex = 3;
            this.txt_start.TextChanged += new System.EventHandler(this.txt_start_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(13, 58);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 12);
            this.label4.TabIndex = 7;
            this.label4.Text = "输出位置";
            // 
            // txt_output
            // 
            this.txt_output.Enabled = false;
            this.txt_output.Location = new System.Drawing.Point(90, 53);
            this.txt_output.Name = "txt_output";
            this.txt_output.Size = new System.Drawing.Size(273, 21);
            this.txt_output.TabIndex = 8;
            // 
            // btn_select_path
            // 
            this.btn_select_path.Location = new System.Drawing.Point(375, 53);
            this.btn_select_path.Name = "btn_select_path";
            this.btn_select_path.Size = new System.Drawing.Size(75, 23);
            this.btn_select_path.TabIndex = 9;
            this.btn_select_path.Text = "浏览";
            this.btn_select_path.UseVisualStyleBackColor = true;
            this.btn_select_path.Click += new System.EventHandler(this.btn_select_path_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(258, 13);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 12);
            this.label2.TabIndex = 2;
            this.label2.Text = "截止编号";
            // 
            // txt_end
            // 
            this.txt_end.Location = new System.Drawing.Point(329, 10);
            this.txt_end.Name = "txt_end";
            this.txt_end.Size = new System.Drawing.Size(121, 21);
            this.txt_end.TabIndex = 11;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(462, 159);
            this.Controls.Add(this.txt_end);
            this.Controls.Add(this.btn_select_path);
            this.Controls.Add(this.txt_output);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txt_start);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_create);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "控制器二维码生成器";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_create;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_start;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt_output;
        private System.Windows.Forms.Button btn_select_path;
        private System.Windows.Forms.FolderBrowserDialog fbd;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_end;
    }
}

