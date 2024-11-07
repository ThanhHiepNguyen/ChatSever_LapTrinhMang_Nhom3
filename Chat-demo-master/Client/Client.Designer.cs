namespace Client
{
    partial class Client
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Client));
            listbox_result = new ListBox();
            txt_Message = new TextBox();
            btn_Send = new Button();
            panel1 = new Panel();
            label4 = new Label();
            btn_disconnect = new Button();
            btn_connect = new Button();
            listbox_User = new ListBox();
            label3 = new Label();
            txt_Port = new TextBox();
            label1 = new Label();
            txt_IPAddress = new TextBox();
            pictureBox1 = new PictureBox();
            label2 = new Label();
            txt_username = new TextBox();
            label5 = new Label();
            panel2 = new Panel();
            label6 = new Label();
            txt_status = new TextBox();
            panel3 = new Panel();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            SuspendLayout();
            // 
            // listbox_result
            // 
            listbox_result.FormattingEnabled = true;
            listbox_result.ItemHeight = 15;
            listbox_result.Location = new Point(265, 108);
            listbox_result.Margin = new Padding(3, 2, 3, 2);
            listbox_result.Name = "listbox_result";
            listbox_result.Size = new Size(456, 364);
            listbox_result.TabIndex = 0;
            // 
            // txt_Message
            // 
            txt_Message.Location = new Point(265, 476);
            txt_Message.Margin = new Padding(3, 2, 3, 2);
            txt_Message.Multiline = true;
            txt_Message.Name = "txt_Message";
            txt_Message.Size = new Size(356, 44);
            txt_Message.TabIndex = 11;
            txt_Message.KeyDown += txt_Message_KeyDown;
            // 
            // btn_Send
            // 
            btn_Send.BackColor = SystemColors.MenuHighlight;
            btn_Send.Enabled = false;
            btn_Send.Font = new Font("Stencil", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btn_Send.Location = new Point(626, 488);
            btn_Send.Margin = new Padding(3, 2, 3, 2);
            btn_Send.Name = "btn_Send";
            btn_Send.Size = new Size(94, 31);
            btn_Send.TabIndex = 2;
            btn_Send.Text = "Send";
            btn_Send.UseVisualStyleBackColor = false;
            btn_Send.Click += btn_Send_Click;
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ControlLight;
            panel1.Controls.Add(label4);
            panel1.Controls.Add(btn_disconnect);
            panel1.Controls.Add(btn_connect);
            panel1.Controls.Add(listbox_User);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(txt_Port);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(txt_IPAddress);
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(txt_username);
            panel1.Location = new Point(10, 9);
            panel1.Margin = new Padding(3, 2, 3, 2);
            panel1.Name = "panel1";
            panel1.Size = new Size(249, 510);
            panel1.TabIndex = 3;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Showcard Gothic", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(52, 244);
            label4.Name = "label4";
            label4.Size = new Size(127, 23);
            label4.TabIndex = 11;
            label4.Text = "user online";
            // 
            // btn_disconnect
            // 
            btn_disconnect.BackColor = SystemColors.Window;
            btn_disconnect.Enabled = false;
            btn_disconnect.Font = new Font("Stencil", 7.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btn_disconnect.Location = new Point(152, 461);
            btn_disconnect.Margin = new Padding(3, 2, 3, 2);
            btn_disconnect.Name = "btn_disconnect";
            btn_disconnect.Size = new Size(82, 32);
            btn_disconnect.TabIndex = 5;
            btn_disconnect.Text = "DisConnect";
            btn_disconnect.UseVisualStyleBackColor = false;
            btn_disconnect.Click += btn_disconnect_Click;
            // 
            // btn_connect
            // 
            btn_connect.BackColor = SystemColors.Window;
            btn_connect.Font = new Font("Stencil", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btn_connect.Location = new Point(21, 461);
            btn_connect.Margin = new Padding(3, 2, 3, 2);
            btn_connect.Name = "btn_connect";
            btn_connect.Size = new Size(84, 32);
            btn_connect.TabIndex = 4;
            btn_connect.Text = "Connect";
            btn_connect.UseVisualStyleBackColor = false;
            btn_connect.Click += btn_connect_Click;
            // 
            // listbox_User
            // 
            listbox_User.FormattingEnabled = true;
            listbox_User.ItemHeight = 15;
            listbox_User.Location = new Point(21, 275);
            listbox_User.Margin = new Padding(3, 2, 3, 2);
            listbox_User.Name = "listbox_User";
            listbox_User.Size = new Size(214, 154);
            listbox_User.TabIndex = 10;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Stencil", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(21, 214);
            label3.Name = "label3";
            label3.Size = new Size(44, 17);
            label3.TabIndex = 8;
            label3.Text = "Port";
            // 
            // txt_Port
            // 
            txt_Port.BackColor = SystemColors.InactiveCaption;
            txt_Port.Location = new Point(80, 211);
            txt_Port.Margin = new Padding(3, 2, 3, 2);
            txt_Port.Name = "txt_Port";
            txt_Port.Size = new Size(154, 23);
            txt_Port.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Stencil", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(80, 110);
            label1.Name = "label1";
            label1.Size = new Size(84, 17);
            label1.TabIndex = 6;
            label1.Text = "USER NAME";
            // 
            // txt_IPAddress
            // 
            txt_IPAddress.BackColor = SystemColors.InactiveCaption;
            txt_IPAddress.Location = new Point(21, 172);
            txt_IPAddress.Margin = new Padding(3, 2, 3, 2);
            txt_IPAddress.Name = "txt_IPAddress";
            txt_IPAddress.Size = new Size(214, 23);
            txt_IPAddress.TabIndex = 1;
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImage = (Image)resources.GetObject("pictureBox1.BackgroundImage");
            pictureBox1.Location = new Point(55, 0);
            pictureBox1.Margin = new Padding(3, 2, 3, 2);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(124, 108);
            pictureBox1.TabIndex = 9;
            pictureBox1.TabStop = false;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Stencil", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(74, 154);
            label2.Name = "label2";
            label2.Size = new Size(88, 17);
            label2.TabIndex = 7;
            label2.Text = "IP Address";
            // 
            // txt_username
            // 
            txt_username.BackColor = SystemColors.InactiveCaption;
            txt_username.Location = new Point(21, 128);
            txt_username.Margin = new Padding(3, 2, 3, 2);
            txt_username.Name = "txt_username";
            txt_username.Size = new Size(214, 23);
            txt_username.TabIndex = 0;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Showcard Gothic", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.Location = new Point(25, 7);
            label5.Name = "label5";
            label5.Size = new Size(137, 23);
            label5.TabIndex = 8;
            label5.Text = "MESSAGE BOX";
            // 
            // panel2
            // 
            panel2.BackColor = SystemColors.ControlLight;
            panel2.Controls.Add(label6);
            panel2.Controls.Add(txt_status);
            panel2.Location = new Point(265, 9);
            panel2.Margin = new Padding(3, 2, 3, 2);
            panel2.Name = "panel2";
            panel2.Size = new Size(455, 46);
            panel2.TabIndex = 9;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Showcard Gothic", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label6.Location = new Point(9, 12);
            label6.Name = "label6";
            label6.Size = new Size(91, 23);
            label6.TabIndex = 10;
            label6.Text = "Status :";
            // 
            // txt_status
            // 
            txt_status.Location = new Point(108, 14);
            txt_status.Margin = new Padding(3, 2, 3, 2);
            txt_status.Multiline = true;
            txt_status.Name = "txt_status";
            txt_status.Size = new Size(329, 21);
            txt_status.TabIndex = 9;
            // 
            // panel3
            // 
            panel3.BackColor = SystemColors.ControlLight;
            panel3.Controls.Add(label5);
            panel3.Location = new Point(389, 59);
            panel3.Margin = new Padding(3, 2, 3, 2);
            panel3.Name = "panel3";
            panel3.Size = new Size(199, 35);
            panel3.TabIndex = 10;
            // 
            // Client
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlDarkDark;
            ClientSize = new Size(732, 528);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Controls.Add(btn_Send);
            Controls.Add(txt_Message);
            Controls.Add(listbox_result);
            Margin = new Padding(3, 2, 3, 2);
            Name = "Client";
            Text = "Client";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListBox listbox_result;
        private TextBox txt_Message;
        private Button btn_Send;
        private Panel panel1;
        private TextBox txt_Port;
        private TextBox txt_IPAddress;
        private TextBox txt_username;
        private PictureBox pictureBox1;
        private Button btn_disconnect;
        private Button btn_connect;
        private Label label5;
        private Label label3;
        private Label label2;
        private Label label1;
        private Panel panel2;
        private ListBox listbox_User;
        private TextBox txt_status;
        private Panel panel3;
        private Label label4;
        private Label label6;
    }
}
