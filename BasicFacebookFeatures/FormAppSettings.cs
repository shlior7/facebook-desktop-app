using BasicFacebookFeatures;
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
    public partial class FormAppSettings : Form
    {
        bool m_AuditoryAssistant;


        public FormAppSettings()
        {
            InitializeComponent();
            m_AuditoryAssistant = assistantToggle.Checked;
        }

        StringBuilder m_PermissionsStringBuilder = new StringBuilder();

        public bool AuditoryAssistant { get => m_AuditoryAssistant; set => m_AuditoryAssistant = value; }


        private void buttonRefreshPermissions_Click(object sender, EventArgs e)
        {
            textBoxPermissions.Clear();
            m_PermissionsStringBuilder.Clear();
            foreach (var checkedItem in listBoxPermissions.CheckedItems)
            {
                m_PermissionsStringBuilder.Append($"\"{checkedItem}\",");
            }

            textBoxPermissions.Text = m_PermissionsStringBuilder.ToString();
        }

        private void buttonApply_Click(object sender, EventArgs e)
        {
            if (comboAppID.SelectedIndex == -1)
            {
                comboAppID.SelectedIndex = 0;
            }
            AppSettings.s_AppID = comboAppID.SelectedItem.ToString();
            AppSettings.s_Permissions = new string[listBoxPermissions.CheckedItems.Count];
            listBoxPermissions.CheckedItems.CopyTo(AppSettings.s_Permissions, 0);
            DialogResult = DialogResult.OK;
            Clipboard.SetText(textBoxPassword.Text);
            this.Close();
        }

        private void buttonAddPermission_Click(object sender, EventArgs e)
        {
            listBoxPermissions.Items.Add(textBoxPermissionToAdd.Text);
        }

        private void buttonAddAppID_Click(object sender, EventArgs e)
        {
            comboAppID.Items.Insert(0, textBoxAppID.Text);
            comboAppID.SelectedIndex = 0;
        }

        private void FormAppSettings_Load(object sender, EventArgs e)
        {

        }

        private void Assistant_CheckedChanged(object sender, EventArgs e)
        {
            m_AuditoryAssistant = assistantToggle.Checked;
        }

    }
}
