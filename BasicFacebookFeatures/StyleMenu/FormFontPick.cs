using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Design;

namespace BasicFacebookFeatures
{
    public partial class FormFontPick : Form
    {
        private FontStyle m_FontStyle;
        private string m_FontFamily;
        private bool m_Confirmed;

        public FormFontPick(Font i_CurrentFont)
        {
            m_Confirmed = false;
            m_FontFamily = i_CurrentFont.FontFamily.Name;
            m_FontStyle = i_CurrentFont.Style;
            InitializeComponent();
            showText();
        }

        public bool Confirmed
        {
            get => m_Confirmed;
            set => m_Confirmed = value;
        }

        public string FontFamily
        {
            get => m_FontFamily;
            set => m_FontFamily = value;
        }

        public FontStyle FontStyle
        {
            get => m_FontStyle;
            set => m_FontStyle = value;
        }

        private void Font_Pick_Load(object sender, EventArgs e)
        {
            this.comboBox_FontFamily.SelectedItem = m_FontFamily;
            this.comboBox_FontStyle.SelectedItem = m_FontStyle;
            this.comboBox_FontFamily.Text = m_FontFamily;
            this.comboBox_FontStyle.Text = m_FontStyle.ToString();

            foreach (FontFamily familyName in System.Drawing.FontFamily.Families)
            {
                this.comboBox_FontFamily.Items.Add(familyName.Name);
            }

            this.comboBox_FontStyle.Items.Add(System.Drawing.FontStyle.Regular);
            this.comboBox_FontStyle.Items.Add(System.Drawing.FontStyle.Bold);
            this.comboBox_FontStyle.Items.Add(System.Drawing.FontStyle.Italic);
            this.comboBox_FontStyle.Items.Add(System.Drawing.FontStyle.Underline);
            this.comboBox_FontStyle.Items.Add(System.Drawing.FontStyle.Strikeout);
        }

        private void styledButton_Confirm_Click(object sender, EventArgs e)
        {
            Confirmed = true;
            this.Close();
        }

        private void comboBox_Font_SelectedIndexChanged(object sender, EventArgs e)
        {
            m_FontFamily = comboBox_FontFamily.SelectedItem.ToString();
            showText();
        }

        private void comboBoxFontStyle_SelectedIndexChanged(object sender, EventArgs e)
        {
            m_FontStyle = (FontStyle)comboBox_FontStyle.SelectedItem;
            showText();
        }

        private void showText()
        {
            this.label_ShowText.Font = new System.Drawing.Font(m_FontFamily, this.label_ShowText.Font.Size, m_FontStyle);
        }
    }
}
