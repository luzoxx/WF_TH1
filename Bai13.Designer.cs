namespace WF_TH1
{
    partial class b13Main
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
            this.components = new System.ComponentModel.Container();
            this.lb1 = new System.Windows.Forms.Label();
            this.lb2 = new System.Windows.Forms.Label();
            this.txtSO1 = new System.Windows.Forms.TextBox();
            this.txtSO2 = new System.Windows.Forms.TextBox();
            this.lbT = new System.Windows.Forms.Label();
            this.cbCONG = new System.Windows.Forms.CheckBox();
            this.cbTRU = new System.Windows.Forms.CheckBox();
            this.cbNHAN = new System.Windows.Forms.CheckBox();
            this.cbCHIA = new System.Windows.Forms.CheckBox();
            this.txtKetQua = new System.Windows.Forms.TextBox();
            this.lbKQ = new System.Windows.Forms.Label();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // lb1
            // 
            this.lb1.AutoSize = true;
            this.lb1.Location = new System.Drawing.Point(72, 31);
            this.lb1.Name = "lb1";
            this.lb1.Size = new System.Drawing.Size(38, 20);
            this.lb1.TabIndex = 0;
            this.lb1.Text = "Số 1";
            this.lb1.Click += new System.EventHandler(this.lb1_Click);
            // 
            // lb2
            // 
            this.lb2.AutoSize = true;
            this.lb2.Location = new System.Drawing.Point(72, 87);
            this.lb2.Name = "lb2";
            this.lb2.Size = new System.Drawing.Size(38, 20);
            this.lb2.TabIndex = 1;
            this.lb2.Text = "Số 2";
            this.lb2.Click += new System.EventHandler(this.lb2_Click);
            // 
            // txtSO1
            // 
            this.txtSO1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtSO1.Location = new System.Drawing.Point(133, 28);
            this.txtSO1.Name = "txtSO1";
            this.txtSO1.Size = new System.Drawing.Size(453, 27);
            this.txtSO1.TabIndex = 2;
            this.txtSO1.TextChanged += new System.EventHandler(this.txtSO1_TextChanged);
            // 
            // txtSO2
            // 
            this.txtSO2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtSO2.Location = new System.Drawing.Point(133, 84);
            this.txtSO2.Name = "txtSO2";
            this.txtSO2.Size = new System.Drawing.Size(453, 27);
            this.txtSO2.TabIndex = 3;
            this.txtSO2.TextChanged += new System.EventHandler(this.txtSO2_TextChanged);
            // 
            // lbT
            // 
            this.lbT.AutoSize = true;
            this.lbT.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbT.Location = new System.Drawing.Point(50, 141);
            this.lbT.Name = "lbT";
            this.lbT.Size = new System.Drawing.Size(76, 20);
            this.lbT.TabIndex = 4;
            this.lbT.Text = "Phép tính";
            this.lbT.Click += new System.EventHandler(this.lbT_Click);
            // 
            // cbCONG
            // 
            this.cbCONG.AutoSize = true;
            this.cbCONG.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.cbCONG.Location = new System.Drawing.Point(72, 185);
            this.cbCONG.Name = "cbCONG";
            this.cbCONG.Size = new System.Drawing.Size(67, 24);
            this.cbCONG.TabIndex = 5;
            this.cbCONG.Text = "Cộng";
            this.cbCONG.UseVisualStyleBackColor = true;
            this.cbCONG.CheckedChanged += new System.EventHandler(this.cbCONG_CheckedChanged);
            // 
            // cbTRU
            // 
            this.cbTRU.AutoSize = true;
            this.cbTRU.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.cbTRU.Location = new System.Drawing.Point(217, 185);
            this.cbTRU.Name = "cbTRU";
            this.cbTRU.Size = new System.Drawing.Size(55, 24);
            this.cbTRU.TabIndex = 6;
            this.cbTRU.Text = "Trừ";
            this.cbTRU.TextAlign = System.Drawing.ContentAlignment.TopLeft;
            this.cbTRU.UseVisualStyleBackColor = true;
            this.cbTRU.CheckedChanged += new System.EventHandler(this.cbTRU_CheckedChanged);
            // 
            // cbNHAN
            // 
            this.cbNHAN.AutoSize = true;
            this.cbNHAN.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.cbNHAN.Location = new System.Drawing.Point(368, 185);
            this.cbNHAN.Name = "cbNHAN";
            this.cbNHAN.Size = new System.Drawing.Size(69, 24);
            this.cbNHAN.TabIndex = 7;
            this.cbNHAN.Text = "Nhân";
            this.cbNHAN.UseVisualStyleBackColor = true;
            this.cbNHAN.CheckedChanged += new System.EventHandler(this.cbNHAN_CheckedChanged);
            // 
            // cbCHIA
            // 
            this.cbCHIA.AutoSize = true;
            this.cbCHIA.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.cbCHIA.Location = new System.Drawing.Point(512, 185);
            this.cbCHIA.Name = "cbCHIA";
            this.cbCHIA.Size = new System.Drawing.Size(61, 24);
            this.cbCHIA.TabIndex = 8;
            this.cbCHIA.Text = "Chia";
            this.cbCHIA.UseVisualStyleBackColor = true;
            this.cbCHIA.CheckedChanged += new System.EventHandler(this.cbCHIA_CheckedChanged);
            // 
            // txtKetQua
            // 
            this.txtKetQua.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtKetQua.Location = new System.Drawing.Point(133, 246);
            this.txtKetQua.Name = "txtKetQua";
            this.txtKetQua.Size = new System.Drawing.Size(453, 27);
            this.txtKetQua.TabIndex = 9;
            this.txtKetQua.TextChanged += new System.EventHandler(this.txtKetQua_TextChanged);
            // 
            // lbKQ
            // 
            this.lbKQ.AutoSize = true;
            this.lbKQ.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbKQ.Location = new System.Drawing.Point(50, 246);
            this.lbKQ.Name = "lbKQ";
            this.lbKQ.Size = new System.Drawing.Size(63, 20);
            this.lbKQ.TabIndex = 10;
            this.lbKQ.Text = "Kết quả";
            this.lbKQ.Click += new System.EventHandler(this.lbKQ_Click);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // b13Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(696, 327);
            this.Controls.Add(this.lbKQ);
            this.Controls.Add(this.txtKetQua);
            this.Controls.Add(this.cbCHIA);
            this.Controls.Add(this.cbNHAN);
            this.Controls.Add(this.cbTRU);
            this.Controls.Add(this.cbCONG);
            this.Controls.Add(this.lbT);
            this.Controls.Add(this.txtSO2);
            this.Controls.Add(this.txtSO1);
            this.Controls.Add(this.lb2);
            this.Controls.Add(this.lb1);
            this.Name = "b13Main";
            this.Text = "Phép Tính";
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label lb1;
        private Label lb2;
        private TextBox txtSO1;
        private TextBox txtSO2;
        private Label lbT;
        private CheckBox cbCONG;
        private CheckBox cbTRU;
        private CheckBox cbNHAN;
        private CheckBox cbCHIA;
        private TextBox txtKetQua;
        private Label lbKQ;
        private ErrorProvider errorProvider1;
    }
}