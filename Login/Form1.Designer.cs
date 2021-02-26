
namespace Login
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
            this.loginbutt = new System.Windows.Forms.Button();
            this.usernamelabel = new System.Windows.Forms.Label();
            this.usernameinput = new System.Windows.Forms.TextBox();
            this.registerbutt = new System.Windows.Forms.Button();
            this.passwordinput = new System.Windows.Forms.TextBox();
            this.passwordlabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // loginbutt
            // 
            this.loginbutt.Location = new System.Drawing.Point(32, 133);
            this.loginbutt.Name = "loginbutt";
            this.loginbutt.Size = new System.Drawing.Size(75, 23);
            this.loginbutt.TabIndex = 0;
            this.loginbutt.Text = "Login";
            this.loginbutt.UseVisualStyleBackColor = true;
            this.loginbutt.Click += new System.EventHandler(this.loginbutt_Click);
            // 
            // usernamelabel
            // 
            this.usernamelabel.AutoSize = true;
            this.usernamelabel.Location = new System.Drawing.Point(29, 26);
            this.usernamelabel.Name = "usernamelabel";
            this.usernamelabel.Size = new System.Drawing.Size(55, 13);
            this.usernamelabel.TabIndex = 1;
            this.usernamelabel.Text = "Username";
            // 
            // usernameinput
            // 
            this.usernameinput.Location = new System.Drawing.Point(32, 42);
            this.usernameinput.Name = "usernameinput";
            this.usernameinput.Size = new System.Drawing.Size(156, 20);
            this.usernameinput.TabIndex = 2;
            this.usernameinput.TextChanged += new System.EventHandler(this.usernameinput_TextChanged);
            // 
            // registerbutt
            // 
            this.registerbutt.Location = new System.Drawing.Point(113, 133);
            this.registerbutt.Name = "registerbutt";
            this.registerbutt.Size = new System.Drawing.Size(75, 23);
            this.registerbutt.TabIndex = 3;
            this.registerbutt.Text = "Register";
            this.registerbutt.UseVisualStyleBackColor = true;
            this.registerbutt.Click += new System.EventHandler(this.registerbutt_Click);
            // 
            // passwordinput
            // 
            this.passwordinput.Location = new System.Drawing.Point(32, 89);
            this.passwordinput.Name = "passwordinput";
            this.passwordinput.Size = new System.Drawing.Size(156, 20);
            this.passwordinput.TabIndex = 4;
            // 
            // passwordlabel
            // 
            this.passwordlabel.AutoSize = true;
            this.passwordlabel.Location = new System.Drawing.Point(29, 73);
            this.passwordlabel.Name = "passwordlabel";
            this.passwordlabel.Size = new System.Drawing.Size(53, 13);
            this.passwordlabel.TabIndex = 5;
            this.passwordlabel.Text = "Password";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(229, 205);
            this.Controls.Add(this.passwordlabel);
            this.Controls.Add(this.passwordinput);
            this.Controls.Add(this.registerbutt);
            this.Controls.Add(this.usernameinput);
            this.Controls.Add(this.usernamelabel);
            this.Controls.Add(this.loginbutt);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button loginbutt;
        private System.Windows.Forms.Label usernamelabel;
        private System.Windows.Forms.TextBox usernameinput;
        private System.Windows.Forms.Button registerbutt;
        private System.Windows.Forms.TextBox passwordinput;
        private System.Windows.Forms.Label passwordlabel;
    }
}

