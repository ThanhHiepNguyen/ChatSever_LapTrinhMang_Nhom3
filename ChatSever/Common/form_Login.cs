using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ChatSever.Common
{
    public partial class form_Login : Form
    {
        public form_Login()
        {
            InitializeComponent();
        }

        private void btn_Cancel_Click(object sender, EventArgs e)
        {
            DialogResult = System.Windows.Forms.DialogResult.Cancel;           
            Close();
        }

        private void btn_Login_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txt_UserName.Text))
            {
                MessageBox.Show(@"User Name không được để trống ", @"System Message");
                return;
            }
            if (string.IsNullOrEmpty(txt_PassWord.Text))
            {
                MessageBox.Show(@"PassWord không được để trống ", @"System Message");
                return;
            }
            if ( txt_UserName.Text.Equals("admin") && (txt_PassWord.Text.Equals("123456")))
            {
                DialogResult = DialogResult.OK;
                Close();
                return;
            }
            MessageBox.Show(@"Bạn đã nhập sai User hoặc PassWord, vui lòng nhập lại", @"System Message");
        }
    }
}
