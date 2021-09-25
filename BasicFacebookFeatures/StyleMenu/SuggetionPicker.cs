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
        private bool m_Confirmed;
        private string m_SelectedSuggestion;
        private List<string> m_Suggestions;

        public bool Confirmed { get => m_Confirmed; set => m_Confirmed = value; }

        public string SelectedSuggestion { get => m_SelectedSuggestion; set => m_SelectedSuggestion = value; }

        public SuggetionPicker(List<string> i_Suggestions)
        {
            m_Confirmed = false;
            m_Suggestions = i_Suggestions;
            InitializeComponent();
        }

        private void SuggetionPicker_Load(object sender, EventArgs e)
        {
            foreach (string suggestion in m_Suggestions)
            {
                this.comboBox_Suggestions.Items.Add(suggestion);
            }
        }

        private void styledButton_Confirm_Click(object sender, EventArgs e)
        {
            m_Confirmed = true;
            m_SelectedSuggestion = comboBox_Suggestions.SelectedItem.ToString();
            this.Close();
        }
    }
}
