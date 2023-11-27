namespace TraSuaMello._3.PL
{
    partial class FormQuanLyHoaDon
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dgrid_HoaDon = new System.Windows.Forms.DataGridView();
            this.dt_From = new System.Windows.Forms.DateTimePicker();
            this.dt_To = new System.Windows.Forms.DateTimePicker();
            this.btn_Search = new System.Windows.Forms.Button();
            this.pic_Pic = new System.Windows.Forms.PictureBox();
            this.btn_HDCT = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgrid_HoaDon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_Pic)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btn_Search);
            this.groupBox1.Controls.Add(this.dt_To);
            this.groupBox1.Controls.Add(this.dt_From);
            this.groupBox1.Controls.Add(this.dgrid_HoaDon);
            this.groupBox1.Location = new System.Drawing.Point(1, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(691, 617);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.button3);
            this.groupBox2.Controls.Add(this.btn_HDCT);
            this.groupBox2.Controls.Add(this.pic_Pic);
            this.groupBox2.Location = new System.Drawing.Point(698, 0);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(460, 617);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            // 
            // dgrid_HoaDon
            // 
            this.dgrid_HoaDon.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgrid_HoaDon.Location = new System.Drawing.Point(0, 278);
            this.dgrid_HoaDon.Name = "dgrid_HoaDon";
            this.dgrid_HoaDon.RowHeadersWidth = 51;
            this.dgrid_HoaDon.RowTemplate.Height = 29;
            this.dgrid_HoaDon.Size = new System.Drawing.Size(691, 333);
            this.dgrid_HoaDon.TabIndex = 0;
            this.dgrid_HoaDon.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgrid_HoaDon_CellClick);
            // 
            // dt_From
            // 
            this.dt_From.Location = new System.Drawing.Point(34, 89);
            this.dt_From.Name = "dt_From";
            this.dt_From.Size = new System.Drawing.Size(284, 27);
            this.dt_From.TabIndex = 1;
            // 
            // dt_To
            // 
            this.dt_To.Location = new System.Drawing.Point(379, 89);
            this.dt_To.Name = "dt_To";
            this.dt_To.Size = new System.Drawing.Size(284, 27);
            this.dt_To.TabIndex = 1;
            // 
            // btn_Search
            // 
            this.btn_Search.Location = new System.Drawing.Point(275, 161);
            this.btn_Search.Name = "btn_Search";
            this.btn_Search.Size = new System.Drawing.Size(144, 49);
            this.btn_Search.TabIndex = 2;
            this.btn_Search.Text = "Tìm kiếm";
            this.btn_Search.UseVisualStyleBackColor = true;
            this.btn_Search.Click += new System.EventHandler(this.btn_Search_Click);
            // 
            // pic_Pic
            // 
            this.pic_Pic.Location = new System.Drawing.Point(145, 70);
            this.pic_Pic.Name = "pic_Pic";
            this.pic_Pic.Size = new System.Drawing.Size(189, 165);
            this.pic_Pic.TabIndex = 0;
            this.pic_Pic.TabStop = false;
            // 
            // btn_HDCT
            // 
            this.btn_HDCT.Location = new System.Drawing.Point(157, 330);
            this.btn_HDCT.Name = "btn_HDCT";
            this.btn_HDCT.Size = new System.Drawing.Size(168, 58);
            this.btn_HDCT.TabIndex = 1;
            this.btn_HDCT.Text = "Xem chi tiết";
            this.btn_HDCT.UseVisualStyleBackColor = true;
            this.btn_HDCT.Click += new System.EventHandler(this.btn_HDCT_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(157, 425);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(168, 58);
            this.button3.TabIndex = 2;
            this.button3.Text = "Xuất File Excel";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // FormQuanLyHoaDon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1158, 643);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "FormQuanLyHoaDon";
            this.Text = "FormQuanLyHoaDon";
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgrid_HoaDon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_Pic)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private GroupBox groupBox1;
        private Button btn_Search;
        private DateTimePicker dt_To;
        private DateTimePicker dt_From;
        private DataGridView dgrid_HoaDon;
        private GroupBox groupBox2;
        private Button button3;
        private Button btn_HDCT;
        private PictureBox pic_Pic;
    }
}