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
    public partial class Font_Pick : Form
    {
        private FontStyle m_FontStyle;
        private string m_Font;
        private bool m_Confirmed;
        public Font_Pick(string i_Font,FontStyle i_FontStyle)
        {
            Confirmed = false;
            m_Font = i_Font;
            m_FontStyle = i_FontStyle;
            InitializeComponent();
        }
        public bool Confirmed
        {
            get => m_Confirmed;
            set => m_Confirmed = value;
        }

      

        private void Font_Pick_Load(object sender, EventArgs e)
        {
            this.comboBox_Font.SelectedItem = m_Font;
            this.comboBox_FontStyle.SelectedItem = m_FontStyle;
            this.comboBox_Font.Text = m_Font;
            this.comboBox_FontStyle.Text = m_FontStyle.ToString() ;


            foreach (FontFamily familyName in FontFamily.Families)
            {
                this.comboBox_Font.Items.Add(familyName.Name);
            }

            this.comboBox_FontStyle.Items.Add( System.Drawing.FontStyle.Regular);
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
            m_Font = comboBox_Font.SelectedItem.ToString();

            showText();
        }
        private void comboBoxFontStyle_SelectedIndexChanged(object sender, EventArgs e)
        {
            m_FontStyle = (FontStyle)comboBox_FontStyle.SelectedItem;

            showText();
        }

        private void showText()
        {


            this.label_ShowText.Font = new System.Drawing.Font(m_Font, this.label_ShowText.Font.Size, m_FontStyle);
        }

      
    }
}
