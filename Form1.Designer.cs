
namespace FTP
{
    partial class Form1
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
            this.addr_box = new System.Windows.Forms.TextBox();
            this.user_box = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.pwd_box = new System.Windows.Forms.TextBox();
            this.port_box = new System.Windows.Forms.TextBox();
            this.label_addr = new System.Windows.Forms.Label();
            this.label_user = new System.Windows.Forms.Label();
            this.label_pwd = new System.Windows.Forms.Label();
            this.label_port = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.path_box = new System.Windows.Forms.TextBox();
            this.filename_box = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // addr_box
            // 
            this.addr_box.Location = new System.Drawing.Point(153, 51);
            this.addr_box.Name = "addr_box";
            this.addr_box.Size = new System.Drawing.Size(125, 27);
            this.addr_box.TabIndex = 0;
            // 
            // user_box
            // 
            this.user_box.Location = new System.Drawing.Point(153, 110);
            this.user_box.Name = "user_box";
            this.user_box.Size = new System.Drawing.Size(125, 27);
            this.user_box.TabIndex = 1;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(369, 51);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(94, 29);
            this.button1.TabIndex = 2;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // pwd_box
            // 
            this.pwd_box.Location = new System.Drawing.Point(153, 171);
            this.pwd_box.Name = "pwd_box";
            this.pwd_box.Size = new System.Drawing.Size(125, 27);
            this.pwd_box.TabIndex = 3;
            // 
            // port_box
            // 
            this.port_box.Location = new System.Drawing.Point(153, 235);
            this.port_box.Name = "port_box";
            this.port_box.Size = new System.Drawing.Size(125, 27);
            this.port_box.TabIndex = 4;
            // 
            // label_addr
            // 
            this.label_addr.AutoSize = true;
            this.label_addr.Font = new System.Drawing.Font("맑은 고딕", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label_addr.Location = new System.Drawing.Point(60, 53);
            this.label_addr.Name = "label_addr";
            this.label_addr.Size = new System.Drawing.Size(51, 25);
            this.label_addr.TabIndex = 5;
            this.label_addr.Text = "addr";
            // 
            // label_user
            // 
            this.label_user.AutoSize = true;
            this.label_user.Font = new System.Drawing.Font("맑은 고딕", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label_user.Location = new System.Drawing.Point(60, 110);
            this.label_user.Name = "label_user";
            this.label_user.Size = new System.Drawing.Size(48, 25);
            this.label_user.TabIndex = 6;
            this.label_user.Text = "user";
            // 
            // label_pwd
            // 
            this.label_pwd.AutoSize = true;
            this.label_pwd.Font = new System.Drawing.Font("맑은 고딕", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label_pwd.Location = new System.Drawing.Point(60, 169);
            this.label_pwd.Name = "label_pwd";
            this.label_pwd.Size = new System.Drawing.Size(48, 25);
            this.label_pwd.TabIndex = 7;
            this.label_pwd.Text = "pwd";
            // 
            // label_port
            // 
            this.label_port.AutoSize = true;
            this.label_port.Font = new System.Drawing.Font("맑은 고딕", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label_port.Location = new System.Drawing.Point(60, 237);
            this.label_port.Name = "label_port";
            this.label_port.Size = new System.Drawing.Size(48, 25);
            this.label_port.TabIndex = 8;
            this.label_port.Text = "port";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("맑은 고딕", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(63, 302);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 25);
            this.label1.TabIndex = 9;
            this.label1.Text = "path";
            // 
            // path_box
            // 
            this.path_box.Location = new System.Drawing.Point(153, 304);
            this.path_box.Name = "path_box";
            this.path_box.Size = new System.Drawing.Size(125, 27);
            this.path_box.TabIndex = 10;
            // 
            // filename_box
            // 
            this.filename_box.Location = new System.Drawing.Point(440, 304);
            this.filename_box.Name = "filename_box";
            this.filename_box.Size = new System.Drawing.Size(125, 27);
            this.filename_box.TabIndex = 11;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("맑은 고딕", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(325, 306);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(90, 25);
            this.label2.TabIndex = 12;
            this.label2.Text = "fileName";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.filename_box);
            this.Controls.Add(this.path_box);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label_port);
            this.Controls.Add(this.label_pwd);
            this.Controls.Add(this.label_user);
            this.Controls.Add(this.label_addr);
            this.Controls.Add(this.port_box);
            this.Controls.Add(this.pwd_box);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.user_box);
            this.Controls.Add(this.addr_box);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox addr_box;
        private System.Windows.Forms.TextBox user_box;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox pwd_box;
        private System.Windows.Forms.TextBox port_box;
        private System.Windows.Forms.Label label_addr;
        private System.Windows.Forms.Label label_user;
        private System.Windows.Forms.Label label_pwd;
        private System.Windows.Forms.Label label_port;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox path_box;
        private System.Windows.Forms.TextBox filename_box;
        private System.Windows.Forms.Label label2;
    }
}

