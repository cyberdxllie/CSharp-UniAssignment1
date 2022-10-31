using System;
using System.Drawing;
using System.Windows.Forms;

namespace LoginForm
{
    public partial class Form1 : Form
    {
        
        public Form1()
        {
            InitializeComponent();
            pictureBox1.Image = new Bitmap(LoginForm.Properties.Resources.login_icon);
            textBox1.Text = "(username)";
            textBox2.Text = "(password)";
            this.ActiveControl = pictureBox1;
            pictureBox2.Visible = false;
            pictureBox3.Visible = false;
        }

        private void textBox1_GotFocus(object sender, EventArgs e) => RemoveText(true);
        private void textBox1_LostFocus(object sender, EventArgs e) => AddText(true);
        private void textBox2_GotFocus(object sender, EventArgs e) => RemoveText(false);
        private void textBox2_LostFocus(object sender, EventArgs e) => AddText(false);
        

        private void button1_Click(object sender, EventArgs e)
        {
             if (textBox1.Text == "cyberdxllie" && textBox2.Text == "iLoveMemes")
             {
                pictureBox2.Image = new Bitmap(LoginForm.Properties.Resources.green1);
                pictureBox3.Image = new Bitmap(LoginForm.Properties.Resources.green1);
                pictureBox2.Visible = true;
                pictureBox3.Visible = true;

                MessageBox.Show("Loading . . .");
                Form f2 = new Form2(textBox1.Text);
                f2.Show();
                this.Hide();
             }
             else 
             {
                if (textBox1.Text == "cyberdxllie" && textBox2.Text != "iLoveMemes")
                {
                    pictureBox2.Image = new Bitmap(LoginForm.Properties.Resources.green1);
                    pictureBox3.Image = new Bitmap(LoginForm.Properties.Resources.red1);
                    pictureBox2.Visible = true;
                    pictureBox3.Visible = true;
                    MessageBox.Show("Incorrect password...\n Try again!");

                    textBox2.Clear();
                    textBox2.PasswordChar = '*';
                }
                else if (textBox1.Text != "cyberdxllie" && textBox2.Text == "iLoveMemes")
                {
                    pictureBox2.Image = new Bitmap(LoginForm.Properties.Resources.red1);
                    pictureBox3.Image = new Bitmap(LoginForm.Properties.Resources.green1);
                    pictureBox2.Visible = true;
                    pictureBox3.Visible = true;
                    MessageBox.Show("Incorrect username...\n Try again!");

                    textBox1.Clear();
                }
                else if (textBox1.Text != "cyberdxllie" && textBox2.Text != "iLoveMemes")
                {
                    pictureBox2.Image = new Bitmap(LoginForm.Properties.Resources.red1);
                    pictureBox3.Image = new Bitmap(LoginForm.Properties.Resources.red1);
                    pictureBox2.Visible = true;
                    pictureBox3.Visible = true;
                    MessageBox.Show("Incorrect username AND password...\n Try again!");

                    textBox1.Clear();
                    textBox2.Clear();
                }
            }
        }

        
        public void RemoveText(bool first_textbox)
        {
            if (first_textbox)
            {
                if (textBox1.Text == "(username)")
                    textBox1.Text = "";
            }
            
            if (!first_textbox)
            {
                if (textBox2.Text == "(password)")
                {
                    textBox2.Text = "";
                    textBox2.PasswordChar = '*';
                }
            }
                  
        }

        public void AddText(bool first_textbox)
        {
            if (first_textbox)
            {
                if (string.IsNullOrWhiteSpace(textBox1.Text))
                    textBox1.Text = "(username)";
            }

            if (!first_textbox)
            {
                if (string.IsNullOrWhiteSpace(textBox2.Text))
                {
                    textBox2.Text = "(password)";
                    textBox2.PasswordChar = '\0';
                }
            }
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}