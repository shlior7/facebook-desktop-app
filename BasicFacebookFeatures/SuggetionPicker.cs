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
    public partial class SuggetionPicker : Form
    {
        private bool m_Confirm;

        private List<string> m_Suggestions;

        public SuggetionPicker(List<string> i_Suggestions)
        {
            m_Suggestions = i_Suggestions;
            InitializeComponent();
        }

        private void SuggetionPicker_Load(object sender, EventArgs e)
        {
            foreach (string suggestion in m_Suggestions)
            {
                this.comboBox_Suggestions.Items.Add(suggestion);
            }

            this.comboBox_Suggestions.SelectedItem = m_Suggestions[0];
            this.comboBox_Suggestions.Text = m_Suggestions[0];
        }

        private void comboBox_FontFamily_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private void styledButton_Confirm_Click(object sender, EventArgs e)
        {
        }
    }
}
