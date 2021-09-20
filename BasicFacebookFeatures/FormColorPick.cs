using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BasicFacebookFeatures
{
    public partial class FormColorPick : Form
    {

        private Color m_ChosenColor;
        private bool m_Confirmed;

        public FormColorPick()
        {
            ChosenColor = Color.FromArgb(0, 0, 0);
            Confirmed = false;
            InitializeComponent();
        }

        public Color ChosenColor
        {
            get => m_ChosenColor;
            set => m_ChosenColor = value;
        }

        public bool Confirmed
        {
            get => m_Confirmed;
            set => m_Confirmed = value;
        }

        private void numericUpDownRed_ValueChanged(object sender, EventArgs e)
        {
            showColor();
        }

        private void numericUpDownGreen_ValueChanged(object sender, EventArgs e)
        {
            showColor();
        }

        private void numericUpDownBlue_ValueChanged(object sender, EventArgs e)
        {
            showColor();
        }

        private void showColor()
        {
            ChosenColor = Color.FromArgb(Decimal.ToInt32(this.numericUpDownRed.Value), Decimal.ToInt32(this.numericUpDownGreen.Value), Decimal.ToInt32(this.numericUpDownBlue.Value));
            this.pictureBox_ShowColor.BackColor = ChosenColor;
        }

        private void confirmButton_Click(object sender, EventArgs e)
        {
            Confirmed = true;
            this.Close();
        }


    }
}
