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
        private bool m_Confirm;
        private Document m_Document;

        public ConfirmPosting(Document i_Document)
        {
            m_Confirm = false;
            m_Document = i_Document;
            InitializeComponent();
            textBox1.Text = m_Document.Text;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void styledButton_Confirm_Click(object sender, EventArgs e)
        {
            m_Confirm = true;
            m_Document.Text = textBox1.Text;
        }
        private void styledButton_Undo_Click(object sender, EventArgs e)
        {
            m_Document.Undo();
            textBox1.Text = m_Document.Text;
        }
    }
}
