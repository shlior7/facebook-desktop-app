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
    public partial class ConfirmPosting : Form
    {
        private bool m_Confirmed;
        private Document m_Document;

        public ConfirmPosting(Document i_Document)
        {
            m_Confirmed = false;
            m_Document = i_Document;
            InitializeComponent();
            textBox1.Text = m_Document.Text;
        }
        public bool Confirmed
        {
            get => m_Confirmed;
            set => m_Confirmed = value;
        }

        private void styledButton_Confirm_Click(object sender, EventArgs e)
        {
            m_Confirmed = true;
            m_Document.Text = textBox1.Text;
            this.Close();

        }
        private void styledButton_Undo_Click(object sender, EventArgs e)
        {
            m_Document.Undo();
            textBox1.Text = m_Document.Text;
        }
    }
}
