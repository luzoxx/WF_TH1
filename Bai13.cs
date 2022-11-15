using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WF_TH1
{
    public partial class b13Main : Form
    {
        public b13Main()
        {
            InitializeComponent();
        }

        private void lb1_Click(object sender, EventArgs e)
        {

        }

        private void txtSO1_TextChanged(object sender, EventArgs e)
        {

        }

        private void lb2_Click(object sender, EventArgs e)
        {

        }

        private void txtSO2_TextChanged(object sender, EventArgs e)
        {
            int SoHai = Convert.ToInt32(txtSO2.Text);
            if (txtSO2 == null)
                this.errorProvider1.SetError(txtSO2, "Please enter number");
            else
                this.errorProvider1.Clear();
        }

        private void cbCONG_CheckedChanged(object sender, EventArgs e)
        {
            int SoMot = Convert.ToInt32(txtSO1.Text);
            int SoHai = Convert.ToInt32(txtSO2.Text);
            if (txtSO1 == null )
                this.errorProvider1.SetError(txtSO1, "Please enter number");
            else
                this.errorProvider1.Clear();
            if (txtSO2 == null)
                this.errorProvider1.SetError(txtSO2, " Please enter number");
            else
                this.errorProvider1.Clear();
            int Kq = SoMot + SoHai;
            txtKetQua.Text = Kq.ToString();
        }

        private void cbTRU_CheckedChanged(object sender, EventArgs e)
        {
            int SoMot = Convert.ToInt32(txtSO1.Text);
            int SoHai = Convert.ToInt32(txtSO2.Text);
            if (txtSO1 == null)
                this.errorProvider1.SetError(txtSO1, "Please enter number");
            else
                this.errorProvider1.Clear();
            if (txtSO2 == null)
                this.errorProvider1.SetError(txtSO2, " Please enter number");
            else
                this.errorProvider1.Clear();
            int Kq = SoMot - SoHai;
            txtKetQua.Text = Kq.ToString();
        }

        private void cbNHAN_CheckedChanged(object sender, EventArgs e)
        {
            int SoMot = Convert.ToInt32(txtSO1.Text);
            int SoHai = Convert.ToInt32(txtSO2.Text);
            if (txtSO1 == null)
                this.errorProvider1.SetError(txtSO1, "Please enter number");
            else
                this.errorProvider1.Clear();
            if (txtSO2 == null)
                this.errorProvider1.SetError(txtSO2, " Please enter number");
            else
                this.errorProvider1.Clear();
            int Kq = SoMot * SoHai;
            txtKetQua.Text = Kq.ToString();
        }

        private void cbCHIA_CheckedChanged(object sender, EventArgs e)
        {
            float SoMot = Convert.ToInt32(txtSO1.Text);
            float SoHai = Convert.ToInt32(txtSO2.Text);
            if (txtSO1 == null)
                this.errorProvider1.SetError(txtSO1, "Please enter number");
            else
                this.errorProvider1.Clear();
            if (txtSO2 == null)
                this.errorProvider1.SetError(txtSO2, " Please enter number");
            else
                this.errorProvider1.Clear();
            if (SoHai == 0)
            {
                MessageBox.Show("Nhap so khac 0");
            }
            else 
            {
                float Kq = SoMot / SoHai;
                txtKetQua.Text = Kq.ToString();
            } 
        }

        private void lbKQ_Click(object sender, EventArgs e)
        {

        }

        private void txtKetQua_TextChanged(object sender, EventArgs e)
        {

        }

        private void lbT_Click(object sender, EventArgs e)
        {

        }
    }
}
