using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FontViewer
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            //InstalledFontCollection installedFonts = new InstalledFontCollection();

            foreach (FontFamily fontFamily in FontFamily.Families)
            {
                lbFont.Items.Add(fontFamily.Name);
            }

            lbCountFonts.Text = "Numer of instelled fonts: " + Value().ToString();
            lblTop.Text = "Select a font from the list on the left side to see the preview.";

            labelStart();
        }

        int Value()
        {
            int a = lbFont.Items.Count + 1;
            return a;
        }

        private void lbFont_SelectedIndexChanged(object sender, EventArgs e)
        {
            //string defaultString = "The quick fox jumps over the lazy dog.";

            if (txtBoxBottom.Text == String.Empty)
            {
                labelStart();
                lblRegular.Font = new Font(lbFont.Items[lbFont.SelectedIndex].ToString(), 16, FontStyle.Regular);
                lblBold.Font = new Font(lbFont.Items[lbFont.SelectedIndex].ToString(), 16, FontStyle.Bold);
                lblItalic.Font = new Font(lbFont.Items[lbFont.SelectedIndex].ToString(), 16, FontStyle.Italic);
                lblUnderline.Font = new Font(lbFont.Items[lbFont.SelectedIndex].ToString(), 16, FontStyle.Underline);
            }
            else
            {
                lblRegular.Text = txtBoxBottom.Text;
                lblRegular.Font = new Font(lbFont.Items[lbFont.SelectedIndex].ToString(), 16, FontStyle.Regular);

                lblBold.Text = txtBoxBottom.Text;
                lblBold.Font = new Font(lbFont.Items[lbFont.SelectedIndex].ToString(), 16, FontStyle.Bold);

                lblItalic.Text = txtBoxBottom.Text;
                lblItalic.Font = new Font(lbFont.Items[lbFont.SelectedIndex].ToString(), 16, FontStyle.Italic);

                lblUnderline.Text = txtBoxBottom.Text;
                lblUnderline.Font = new Font(lbFont.Items[lbFont.SelectedIndex].ToString(), 16, FontStyle.Underline);
            }
        }

        
        void labelStart()
        {
            string defaultString = "The quick fox jumps over the lazy dog.";

            lblRegular.Text = defaultString;
            lblRegular.Font = new Font("Arial", 16,FontStyle.Regular);

            lblBold.Text = defaultString;
            lblBold.Font = new Font("Arial", 16,FontStyle.Bold);

            lblItalic.Text = defaultString;
            lblItalic.Font = new Font("Arial", 16,FontStyle.Italic);

            lblUnderline.Text = defaultString;
            lblUnderline.Font = new Font("Arial", 16, FontStyle.Underline);
        }
        

        private void txtBoxBottom_TextChanged(object sender, EventArgs e)
        {
            TextBox tb = sender as TextBox;

            lblRegular.Text = tb.Text;
            lblBold.Text = tb.Text;
            lblItalic.Text = tb.Text;
            lblUnderline.Text = tb.Text;
        }
    }
}
