using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WF_appli1
{
    public partial class Form1 : Form
    {//Partial : classe partitionné en 2
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.Text = "Ceci est un essai";
            this.BackColor = Color.Beige;
        }

        private void bHello_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Hello world");
        }

        private void bAffiche_Click(object sender, EventArgs e)
        {
            MessageBox.Show(tBvaleur.Text);
        }

        private void tBvaleur_TextChanged(object sender, EventArgs e)
        {

        }

        private void tBvaleur_Enter(object sender, EventArgs e)
        {
            tBvaleur.PasswordChar = '*';
            tBvaleur.Text = "";
        }
    }
}
