using System;
using System.Threading;

namespace login
{
    public partial class Form1 : Form
    {
        Thread nt;
        public Form1()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "Ariel" && textBox2.Text == "12345")
            {
                this.Close();
                nt = new Thread(novoForm);
                nt.SetApartmentState(ApartmentState.STA);
                nt.Start();
            }
            else {
                MessageBox.Show("Login Failed");
            }
        }

        private void novoForm(object? obj)
        {
            Application.Run(new Form2());
        }
    }
}
