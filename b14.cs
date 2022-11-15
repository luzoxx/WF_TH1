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
    public partial class b14 : Form
    {
        public b14()
        {
            InitializeComponent();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

        }

        private void txtNhapten_TextChanged(object sender, EventArgs e)
        {
            lblLapTrinh.Text = txtNhapten.Text;
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void b14_Load(object sender, EventArgs e)
        {
            txtNhapten.ForeColor = radRed.ForeColor;
            lblLapTrinh.ForeColor = radRed.ForeColor;
        }

        private void radRed_CheckedChanged(object sender, EventArgs e)
        {
            if(radRed.Checked)
            {
                txtNhapten.ForeColor = Color.Red;
                lblLapTrinh.ForeColor = Color.Red;
            }
        }

        private void radGreen_CheckedChanged(object sender, EventArgs e)
        {
            if (radGreen.Checked)
            {
                txtNhapten.ForeColor = Color.Green;
                lblLapTrinh.ForeColor = Color.Green;
            }
        }

        private void radBlue_CheckedChanged(object sender, EventArgs e)
        {
            if (radBlue.Checked)
            {
                txtNhapten.ForeColor = Color.Blue;
                lblLapTrinh.ForeColor = Color.Blue;
            }
        }

        private void radBlack_CheckedChanged(object sender, EventArgs e)
        {
            if (radBlack.Checked)
            {
                txtNhapten.ForeColor = Color.Black;
                lblLapTrinh.ForeColor = Color.Black;
            }
        }

        private void ckBold_CheckedChanged(object sender, EventArgs e)
        {
            if (ckBold.Checked)
            {
                txtNhapten.Font = new Font(txtNhapten.Font, txtNhapten.Font.Style | FontStyle.Bold);
                lblLapTrinh.Font = new Font(lblLapTrinh.Font, lblLapTrinh.Font.Style | FontStyle.Bold);
            }
            else
            {
                txtNhapten.Font = new Font(txtNhapten.Font, txtNhapten.Font.Style & ~FontStyle.Bold);
                lblLapTrinh.Font = new Font(lblLapTrinh.Font, lblLapTrinh.Font.Style & ~FontStyle.Bold);
            }
        }

        private void ckItalic_CheckedChanged(object sender, EventArgs e)
        {
            if (ckItalic.Checked)
            {
                txtNhapten.Font = new Font(txtNhapten.Font, txtNhapten.Font.Style | FontStyle.Italic);
                lblLapTrinh.Font = new Font(lblLapTrinh.Font, lblLapTrinh.Font.Style | FontStyle.Italic);
            }
            else
            {
                txtNhapten.Font = new Font(txtNhapten.Font, txtNhapten.Font.Style & ~FontStyle.Italic);
                lblLapTrinh.Font = new Font(lblLapTrinh.Font, lblLapTrinh.Font.Style & ~FontStyle.Italic);
            }
        }

        private void ckUnderline_CheckedChanged(object sender, EventArgs e)
        {
            if (ckUnderline.Checked)
            {
                txtNhapten.Font = new Font(txtNhapten.Font, txtNhapten.Font.Style | FontStyle.Underline);
                lblLapTrinh.Font = new Font(lblLapTrinh.Font, lblLapTrinh.Font.Style | FontStyle.Underline);
            }
            else
            {
                txtNhapten.Font = new Font(txtNhapten.Font, txtNhapten.Font.Style & ~FontStyle.Underline);
                lblLapTrinh.Font = new Font(lblLapTrinh.Font, lblLapTrinh.Font.Style & ~FontStyle.Underline);
            }
        }
    }
}
