using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using ChatSever.Common;  // Thêm dòng này để sử dụng form_Login từ namespace ChatSever.Common

namespace ChatSever
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        private void Main_Load(object sender, EventArgs e)
        {
           
        }

        private void Main_Shown(object sender, EventArgs e)
        {
            try
            {
                var frm = new form_Login();
                frm.ShowDialog();
                if (frm.DialogResult == DialogResult.Cancel)
                {
                    Close();
                    return;
                }
                MessageBox.Show(@"Bạn đã đăng nhập thành công !", @"System Message");
            }  
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, @"System Message");
            }
        }
    }
}