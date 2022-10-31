using System;
using System.Drawing;
using System.Windows.Forms;

namespace LoginForm
{
    public partial class Form2 : Form
    {
        public Form2(String username)
        {
            InitializeComponent();
            pictureBox1.Image = new Bitmap(LoginForm.Properties.Resources.login_icon2);
            label1.Text = "Welcome, " + username + "!";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form f1 = new Form1();
            f1.Show();
            this.Hide();   
        }

        private void Form2_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}
