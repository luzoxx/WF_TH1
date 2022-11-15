namespace WF_TH1
{
    partial class b14
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
            this.label1 = new System.Windows.Forms.Label();
            this.ckItalic = new System.Windows.Forms.CheckBox();
            this.ckUnderline = new System.Windows.Forms.CheckBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtNhapten = new System.Windows.Forms.TextBox();
            this.lblLapTrinh = new System.Windows.Forms.LinkLabel();
            this.btnThoat = new System.Windows.Forms.Button();
            this.ckBold = new System.Windows.Forms.CheckBox();
            this.radRed = new System.Windows.Forms.RadioButton();
            this.radGreen = new System.Windows.Forms.RadioButton();
            this.radBlue = new System.Windows.Forms.RadioButton();
            this.radBlack = new System.Windows.Forms.RadioButton();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.ForeColor = System.Drawing.Color.Lime;
            this.label1.Location = new System.Drawing.Point(46, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nhập tên";
            // 
            // ckItalic
            // 
            this.ckItalic.AutoSize = true;
            this.ckItalic.Font = new System.Drawing.Font("Segoe UI", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.ckItalic.ForeColor = System.Drawing.Color.Blue;
            this.ckItalic.Location = new System.Drawing.Point(27, 81);
            this.ckItalic.Name = "ckItalic";
            this.ckItalic.Size = new System.Drawing.Size(133, 24);
            this.ckItalic.TabIndex = 7;
            this.ckItalic.Text = "Nghiêng Italic";
            this.ckItalic.UseVisualStyleBackColor = true;
            this.ckItalic.CheckedChanged += new System.EventHandler(this.ckItalic_CheckedChanged);
            // 
            // ckUnderline
            // 
            this.ckUnderline.AutoSize = true;
            this.ckUnderline.Font = new System.Drawing.Font("Segoe UI", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point);
            this.ckUnderline.ForeColor = System.Drawing.Color.Blue;
            this.ckUnderline.Location = new System.Drawing.Point(27, 123);
            this.ckUnderline.Name = "ckUnderline";
            this.ckUnderline.Size = new System.Drawing.Size(103, 24);
            this.ckUnderline.TabIndex = 8;
            this.ckUnderline.Text = "Gạch chân";
            this.ckUnderline.UseVisualStyleBackColor = true;
            this.ckUnderline.CheckedChanged += new System.EventHandler(this.ckUnderline_CheckedChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.radBlack);
            this.groupBox1.Controls.Add(this.radBlue);
            this.groupBox1.Controls.Add(this.radGreen);
            this.groupBox1.Controls.Add(this.radRed);
            this.groupBox1.Location = new System.Drawing.Point(12, 85);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(192, 179);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Color";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.ckBold);
            this.groupBox2.Controls.Add(this.ckItalic);
            this.groupBox2.Controls.Add(this.ckUnderline);
            this.groupBox2.Location = new System.Drawing.Point(235, 85);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(173, 179);
            this.groupBox2.TabIndex = 10;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Font";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.Red;
            this.label2.Location = new System.Drawing.Point(57, 297);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(96, 20);
            this.label2.TabIndex = 9;
            this.label2.Text = "Lập trình bởi:";
            // 
            // txtNhapten
            // 
            this.txtNhapten.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtNhapten.Location = new System.Drawing.Point(125, 17);
            this.txtNhapten.Name = "txtNhapten";
            this.txtNhapten.Size = new System.Drawing.Size(125, 27);
            this.txtNhapten.TabIndex = 1;
            this.txtNhapten.TextChanged += new System.EventHandler(this.txtNhapten_TextChanged);
            // 
            // lblLapTrinh
            // 
            this.lblLapTrinh.AutoSize = true;
            this.lblLapTrinh.BackColor = System.Drawing.SystemColors.Control;
            this.lblLapTrinh.Location = new System.Drawing.Point(159, 297);
            this.lblLapTrinh.Name = "lblLapTrinh";
            this.lblLapTrinh.Size = new System.Drawing.Size(0, 20);
            this.lblLapTrinh.TabIndex = 11;
            this.lblLapTrinh.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // btnThoat
            // 
            this.btnThoat.Location = new System.Drawing.Point(299, 335);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(94, 29);
            this.btnThoat.TabIndex = 12;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.UseVisualStyleBackColor = true;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // ckBold
            // 
            this.ckBold.AutoSize = true;
            this.ckBold.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.ckBold.ForeColor = System.Drawing.Color.Blue;
            this.ckBold.Location = new System.Drawing.Point(27, 43);
            this.ckBold.Name = "ckBold";
            this.ckBold.Size = new System.Drawing.Size(100, 24);
            this.ckBold.TabIndex = 6;
            this.ckBold.Text = "Đậm Bold";
            this.ckBold.UseVisualStyleBackColor = true;
            this.ckBold.CheckedChanged += new System.EventHandler(this.ckBold_CheckedChanged);
            // 
            // radRed
            // 
            this.radRed.AutoSize = true;
            this.radRed.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.radRed.ForeColor = System.Drawing.Color.Red;
            this.radRed.Location = new System.Drawing.Point(34, 43);
            this.radRed.Name = "radRed";
            this.radRed.Size = new System.Drawing.Size(57, 24);
            this.radRed.TabIndex = 9;
            this.radRed.TabStop = true;
            this.radRed.Text = "Red";
            this.radRed.UseVisualStyleBackColor = true;
            this.radRed.CheckedChanged += new System.EventHandler(this.radRed_CheckedChanged);
            // 
            // radGreen
            // 
            this.radGreen.AutoSize = true;
            this.radGreen.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.radGreen.ForeColor = System.Drawing.Color.Green;
            this.radGreen.Location = new System.Drawing.Point(34, 73);
            this.radGreen.Name = "radGreen";
            this.radGreen.Size = new System.Drawing.Size(72, 24);
            this.radGreen.TabIndex = 10;
            this.radGreen.TabStop = true;
            this.radGreen.Text = "Green";
            this.radGreen.UseVisualStyleBackColor = true;
            this.radGreen.CheckedChanged += new System.EventHandler(this.radGreen_CheckedChanged);
            // 
            // radBlue
            // 
            this.radBlue.AutoSize = true;
            this.radBlue.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.radBlue.ForeColor = System.Drawing.Color.Blue;
            this.radBlue.Location = new System.Drawing.Point(34, 103);
            this.radBlue.Name = "radBlue";
            this.radBlue.Size = new System.Drawing.Size(61, 24);
            this.radBlue.TabIndex = 11;
            this.radBlue.TabStop = true;
            this.radBlue.Text = "Blue";
            this.radBlue.UseVisualStyleBackColor = true;
            this.radBlue.CheckedChanged += new System.EventHandler(this.radBlue_CheckedChanged);
            // 
            // radBlack
            // 
            this.radBlack.AutoSize = true;
            this.radBlack.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.radBlack.Location = new System.Drawing.Point(34, 133);
            this.radBlack.Name = "radBlack";
            this.radBlack.Size = new System.Drawing.Size(67, 24);
            this.radBlack.TabIndex = 12;
            this.radBlack.TabStop = true;
            this.radBlack.Text = "Black";
            this.radBlack.UseVisualStyleBackColor = true;
            this.radBlack.CheckedChanged += new System.EventHandler(this.radBlack_CheckedChanged);
            // 
            // b14
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.CancelButton = this.btnThoat;
            this.ClientSize = new System.Drawing.Size(405, 376);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.lblLapTrinh);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.txtNhapten);
            this.Controls.Add(this.label1);
            this.Name = "b14";
            this.Text = "Định dạng (Formater)";
            this.Load += new System.EventHandler(this.b14_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private CheckBox ckItalic;
        private CheckBox ckUnderline;
        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private Label label2;
        private TextBox txtNhapten;
        private LinkLabel lblLapTrinh;
        private Button btnThoat;
        private RadioButton radBlack;
        private RadioButton radBlue;
        private RadioButton radGreen;
        private RadioButton radRed;
        private CheckBox ckBold;
    }
}