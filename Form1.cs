namespace WF_TH1
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void lbName_Click(object sender, EventArgs e)
        {

        }

        private void txtYourName_TextChanged(object sender, EventArgs e)
        {
            Control ctr = (Control)sender;
            if (ctr.Text.Trim().Length == 0)
                this.errorProvider1.SetError(txtYourName, "You must enter Your Name");
            else
                this.errorProvider1.Clear();
        }

        private void lbYear_Click(object sender, EventArgs e)
        {

        }

        private void txtYear_TextChanged(object sender, EventArgs e)
        {
            Control ctr = (Control)(sender);
            if (ctr.Text.Trim().Length > 0 && !char.IsDigit(ctr.Text, ctr.Text.Length - 1))
                this.errorProvider1.SetError(txtYear, "This is not invalid number");
            else
                this.errorProvider1.Clear();
        }

        private void btnShow_Click(object sender, EventArgs e)
        {
            int age = DateTime.Now.Year - Convert.ToInt32(txtYear.Text);
            string s = "My name is: " + txtYourName.Text + "\n" + age.ToString();
            MessageBox.Show(s);
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtYourName.Clear();
            txtYear.Clear();
            txtYourName.Focus();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmMain_Load(object sender, EventArgs e)
        {

        }
        private void frmMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult r;
            r = MessageBox.Show("Do you want to close?", "Exit",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question,
                MessageBoxDefaultButton.Button1);
            if (r == DialogResult.No)
                e.Cancel = true;
        }
    }
}