using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Parcial_III
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
             string usuario, password;
            usuario = textBox1.Text.TrimEnd();
            password = textBox2.Text.TrimEnd();
            if ((usuario == "LIGIA") && (password == "SIPUEDO"))
            {

                MessageBox.Show("Bienvenidos al sistema");

                MDIParent1 obj = new MDIParent1();

                obj.Show();

        }
            
                else
            {
                MessageBox.Show("Verifique usuario y password");

            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox2.Clear();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

    }
}
