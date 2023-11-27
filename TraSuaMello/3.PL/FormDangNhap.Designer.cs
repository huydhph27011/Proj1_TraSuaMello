namespace TraSuaMello._3.PL
{
    partial class FormDangNhap
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormDangNhap));
            label1 = new Label();
            label2 = new Label();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            btDangNhap = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Location = new Point(680, 189);
            label1.Name = "label1";
            label1.Size = new Size(71, 20);
            label1.TabIndex = 0;
            label1.Text = "Tài khoản";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Location = new Point(681, 259);
            label2.Name = "label2";
            label2.Size = new Size(70, 20);
            label2.TabIndex = 1;
            label2.Text = "Mật khẩu";
            label2.Click += label2_Click;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(678, 212);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(243, 27);
            textBox1.TabIndex = 2;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(680, 282);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(241, 27);
            textBox2.TabIndex = 3;
            // 
            // btDangNhap
            // 
            btDangNhap.BackColor = SystemColors.ActiveCaptionText;
            btDangNhap.ForeColor = Color.White;
            btDangNhap.Location = new Point(714, 366);
            btDangNhap.Name = "btDangNhap";
            btDangNhap.Size = new Size(163, 80);
            btDangNhap.TabIndex = 4;
            btDangNhap.Text = "Đăng nhập";
            btDangNhap.UseVisualStyleBackColor = false;
            btDangNhap.Click += btDangNhap_Click;
            // 
            // FormDangNhap
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(1044, 681);
            Controls.Add(btDangNhap);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "FormDangNhap";
            Text = "FormDangNhap";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox textBox1;
        private TextBox textBox2;
        private Button btDangNhap;
    }
}