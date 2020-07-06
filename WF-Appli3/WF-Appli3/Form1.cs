using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WF_Appli3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        #region attributs

        ArrayList listeBoutons = new ArrayList();

        ArrayList listeTout = new ArrayList();

        int i = 0;

        #endregion

        #region initialisations au chargement

        private void button5_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            bModifierCouleur.Text = "Modifier la couleur";

            bModifierFS.Text = "Modifier FlatStyle";

            bModifierTexte.Text = "Modifier le texte";

            bModifieTout.Text = "Modifie tous les elements de l'arraylist";

            bModifiePanel.Text = "Modifie tous les elements du panel";

            listeBoutons.Add(button1);
            listeBoutons.Add(button5);
            listeBoutons.Add(button6);
            listeBoutons.Add(bModifierTexte);
            listeBoutons.Add(bModifierFS);
            listeBoutons.Add(bModifierCouleur);

            listeTout.Add(button2);
            listeTout.Add(label1);
            listeTout.Add(bModifieTout);
            listeTout.Add(dateTimePicker1);

        }
        #endregion

        #region methodes

        private void bModifierCouleur_Click(object sender, EventArgs e)
        {
            i++;
            foreach(Button Grominet in listeBoutons)
            {
                if (i % 2 == 0)
                    Grominet.BackColor = Color.Red;
                else
                    Grominet.BackColor = Color.Blue;

            }
        }

        private void bModifierFS_Click(object sender, EventArgs e)
        {
            foreach(Button Titi in listeBoutons)
            {
                if (Titi.FlatStyle == FlatStyle.Popup)
                    Titi.FlatStyle = FlatStyle.Standard;
                else
                    Titi.FlatStyle = FlatStyle.Flat;
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            foreach(Button b in listeBoutons)
            {
                b.Text = "Ce soir on fait la fête";
            }
        }

        private void bModifieTout_Click(object sender, EventArgs e)
        {
            foreach(Object Mémé in listeTout)
            {
                if(Mémé is Button)
                {
                    Button MonBouton = (Button)Mémé;
                    MonBouton.Visible = !MonBouton.Visible;
                }


                if (Mémé is Label)
                {
                    Label MonLabel = (Label)Mémé;
                    MonLabel.Visible = !MonLabel.Visible;
                }

                if (Mémé is DateTimePicker)
                {
                    DateTimePicker MonDT = (DateTimePicker)Mémé;
                    MonDT.Visible = !MonDT.Visible;
                }

            }
        }

        #endregion

        #region panel

        private void bModifiePanel_Click(object sender, EventArgs e)
        {
            foreach (Object Mémé in panel1.Controls)
            {
                if (Mémé is ComboBox)
                {
                    ComboBox MaCB = (ComboBox)Mémé;
                    MaCB.Visible = !Visible;
                }
                if (Mémé is TextBox)
                {
                    TextBox MaTB = (TextBox)Mémé;
                    MaTB.BackColor = Color.Chartreuse;
                    MaTB.PasswordChar = '*';                }

                if (Mémé is NumericUpDown)
                {
                    NumericUpDown MaNUD = (NumericUpDown)Mémé;
                    MaNUD.Minimum = 5;
                    MaNUD.Maximum = 20;
                    MaNUD.Increment = 2;
                }
            }
        }

        #endregion
        private void button6_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        #region CheckListBox
        private void bAffiche_Click(object sender, EventArgs e)
        {
            //Determine if there is any item checked
            if (checkedListBox1.CheckedItems.Count != 0)
            //if so, loop through all checked items and print results
            {
                string s = "";

                for (int x = 0; x < checkedListBox1.CheckedItems.Count; x++)
                {
                    s = s + "Checked item" + (x + 1).ToString() + " = " + checkedListBox1.CheckedItems[x].ToString() + "\n";
                }

                MessageBox.Show(s);

            }

            else
                MessageBox.Show("Pas d'élement checké");

        }

        #endregion

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}
