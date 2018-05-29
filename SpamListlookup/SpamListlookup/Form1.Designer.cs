namespace SpamListlookup
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.ListViewGroup listViewGroup11 = new System.Windows.Forms.ListViewGroup("Black listed", System.Windows.Forms.HorizontalAlignment.Left);
            System.Windows.Forms.ListViewGroup listViewGroup12 = new System.Windows.Forms.ListViewGroup("White listed", System.Windows.Forms.HorizontalAlignment.Left);
            this.button1 = new System.Windows.Forms.Button();
            this.listView1 = new System.Windows.Forms.ListView();
            this.Ip_address = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Is_black_listed = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.On_Server = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.txb_ip = new System.Windows.Forms.TextBox();
            this.lbl_IP = new System.Windows.Forms.Label();
            this.lbl_times = new System.Windows.Forms.Label();
            this.btn_close = new System.Windows.Forms.Button();
            this.Times = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Returncode = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button1.Location = new System.Drawing.Point(608, 118);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 21);
            this.button1.TabIndex = 0;
            this.button1.Text = "Test IP";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Ip_address,
            this.Is_black_listed,
            this.On_Server,
            this.Times,
            this.Returncode});
            listViewGroup11.Header = "Black listed";
            listViewGroup11.Name = "Black_listed";
            listViewGroup12.Header = "White listed";
            listViewGroup12.Name = "White_listed";
            this.listView1.Groups.AddRange(new System.Windows.Forms.ListViewGroup[] {
            listViewGroup11,
            listViewGroup12});
            this.listView1.Location = new System.Drawing.Point(12, 11);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(564, 381);
            this.listView1.TabIndex = 2;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            // 
            // Ip_address
            // 
            this.Ip_address.Text = "Ip address";
            this.Ip_address.Width = 91;
            // 
            // Is_black_listed
            // 
            this.Is_black_listed.Text = "Is black listed";
            this.Is_black_listed.Width = 81;
            // 
            // On_Server
            // 
            this.On_Server.Text = "On Server";
            this.On_Server.Width = 121;
            // 
            // txb_ip
            // 
            this.txb_ip.Location = new System.Drawing.Point(608, 71);
            this.txb_ip.Name = "txb_ip";
            this.txb_ip.Size = new System.Drawing.Size(178, 21);
            this.txb_ip.TabIndex = 3;
            this.txb_ip.Text = " 111.23.152.101";
            // 
            // lbl_IP
            // 
            this.lbl_IP.AutoSize = true;
            this.lbl_IP.Location = new System.Drawing.Point(606, 45);
            this.lbl_IP.Name = "lbl_IP";
            this.lbl_IP.Size = new System.Drawing.Size(47, 12);
            this.lbl_IP.TabIndex = 4;
            this.lbl_IP.Text = "Test IP";
            // 
            // lbl_times
            // 
            this.lbl_times.AutoSize = true;
            this.lbl_times.Location = new System.Drawing.Point(553, 204);
            this.lbl_times.Name = "lbl_times";
            this.lbl_times.Size = new System.Drawing.Size(0, 12);
            this.lbl_times.TabIndex = 6;
            // 
            // btn_close
            // 
            this.btn_close.Location = new System.Drawing.Point(608, 281);
            this.btn_close.Name = "btn_close";
            this.btn_close.Size = new System.Drawing.Size(75, 23);
            this.btn_close.TabIndex = 7;
            this.btn_close.Text = "¹Ø±Õ";
            this.btn_close.UseVisualStyleBackColor = true;
            this.btn_close.Click += new System.EventHandler(this.btn_close_Click);
            // 
            // Times
            // 
            this.Times.Text = "Times";
            this.Times.Width = 120;
            // 
            // Returncode
            // 
            this.Returncode.Text = "Returncode";
            this.Returncode.Width = 100;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(826, 402);
            this.Controls.Add(this.btn_close);
            this.Controls.Add(this.lbl_times);
            this.Controls.Add(this.lbl_IP);
            this.Controls.Add(this.txb_ip);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "DNSBL lookup test application by Paw Jershauge";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader Ip_address;
        private System.Windows.Forms.ColumnHeader Is_black_listed;
        private System.Windows.Forms.ColumnHeader On_Server;
        private System.Windows.Forms.TextBox txb_ip;
        private System.Windows.Forms.Label lbl_IP;
        private System.Windows.Forms.Label lbl_times;
        private System.Windows.Forms.Button btn_close;
        private System.Windows.Forms.ColumnHeader Times;
        private System.Windows.Forms.ColumnHeader Returncode;
    }
}

