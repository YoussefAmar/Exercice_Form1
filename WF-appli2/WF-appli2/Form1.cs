using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WF_appli2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        float largeur;
        float hauteur;

        private void bRectangle_Click(object sender, EventArgs e)
        {
           

            using (Graphics g = CreateGraphics())
            {
                //Pen MonPen = new Pen(Color.SteelBlue, 9);
                //g.DrawRectangle(MonPen, 10, 10, 100, 80);

                g.DrawRectangle(new Pen(Color.SteelBlue, 9), 10, 10, 100, 80);
            }


        }

        private void bAugmenter_Click(object sender, EventArgs e)
        {
            this.Size = new Size(Width * 125 / 100, Height * 125 / 100);
        }

        private void bReduire_Click(object sender, EventArgs e)
        {
            this.Size = new Size(Width * 75 / 100, Height * 75 / 100);
        }

        int i;
        private void bCouleur_Click(object sender, EventArgs e)
        {
            //Affichage du nombre de clics
            i++;
            this.Text = i.ToString();
            if (i % 2 == 0)
                this.BackColor = Color.Black;
            else
                this.BackColor = Color.FloralWhite;
        }

        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {
            tB1.Text = "Position souris : " + e.X + " - " + e.Y + " - "+ e.Button;
        }

        private void bImage_Click(object sender, EventArgs e)
        {
            using (Graphics g = CreateGraphics())
            {
                g.DrawImage(Properties.Resources._2d0, 0, 0);
            }
        }

        private void bRectangle_Paint(object sender, PaintEventArgs e)
        {
            using (Graphics g = CreateGraphics())
            {
                g.DrawEllipse(new Pen(Color.Tomato, 9), 30, 50, 100, 80);
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            bRectangle.Text = "Dessiner un rectangle sur le form";
            largeur = this.Width;
            hauteur = this.Height;

            this.Text = "largeur : " + largeur.ToString() + " - hauteur : " + hauteur.ToString();
        }

        private void tB1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
