
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
            this.addr = new System.Windows.Forms.TextBox();
            this.user = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.pwd = new System.Windows.Forms.TextBox();
            this.port = new System.Windows.Forms.TextBox();
            this.label_addr = new System.Windows.Forms.Label();
            this.label_user = new System.Windows.Forms.Label();
            this.label_pwd = new System.Windows.Forms.Label();
            this.label_port = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // addr
            // 
            this.addr.Location = new System.Drawing.Point(153, 51);
            this.addr.Name = "addr";
            this.addr.Size = new System.Drawing.Size(125, 27);
            this.addr.TabIndex = 0;
            // 
            // user
            // 
            this.user.Location = new System.Drawing.Point(153, 110);
            this.user.Name = "user";
            this.user.Size = new System.Drawing.Size(125, 27);
            this.user.TabIndex = 1;
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
            // pwd
            // 
            this.pwd.Location = new System.Drawing.Point(153, 171);
            this.pwd.Name = "pwd";
            this.pwd.Size = new System.Drawing.Size(125, 27);
            this.pwd.TabIndex = 3;
            // 
            // port
            // 
            this.port.Location = new System.Drawing.Point(153, 235);
            this.port.Name = "port";
            this.port.Size = new System.Drawing.Size(125, 27);
            this.port.TabIndex = 4;
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
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label_port);
            this.Controls.Add(this.label_pwd);
            this.Controls.Add(this.label_user);
            this.Controls.Add(this.label_addr);
            this.Controls.Add(this.port);
            this.Controls.Add(this.pwd);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.user);
            this.Controls.Add(this.addr);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox addr;
        private System.Windows.Forms.TextBox user;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox pwd;
        private System.Windows.Forms.TextBox port;
        private System.Windows.Forms.Label label_addr;
        private System.Windows.Forms.Label label_user;
        private System.Windows.Forms.Label label_pwd;
        private System.Windows.Forms.Label label_port;
    }
}

