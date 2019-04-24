using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Parcial3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void progressBar1_Click(object sender, EventArgs e)
        {
            
        }

        private void contraseña_TextChanged(object sender, EventArgs e)
        {

        }

        private void usuario_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
             string usuario, password;
            usuario = textBox1.Text.TrimEnd();
            password = textBox2.Text.TrimEnd();
            if ((usuario == "ligia") && (password == "sipuedo"))
        
    }
}
