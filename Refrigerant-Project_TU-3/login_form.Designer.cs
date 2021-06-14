namespace Refrigerant_Project_TU_3
{
    partial class login_form
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(login_form));
            this.user_email_tx = new System.Windows.Forms.TextBox();
            this.exit_login = new System.Windows.Forms.Button();
            this.password_tx = new System.Windows.Forms.TextBox();
            this.login_bt = new System.Windows.Forms.Button();
            this.signup_btn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // user_email_tx
            // 
            this.user_email_tx.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.user_email_tx.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.user_email_tx.Location = new System.Drawing.Point(315, 296);
            this.user_email_tx.Name = "user_email_tx";
            this.user_email_tx.Size = new System.Drawing.Size(220, 17);
            this.user_email_tx.TabIndex = 1;
            // 
            // exit_login
            // 
            this.exit_login.BackColor = System.Drawing.Color.Transparent;
            this.exit_login.Cursor = System.Windows.Forms.Cursors.Hand;
            this.exit_login.FlatAppearance.BorderSize = 0;
            this.exit_login.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.exit_login.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exit_login.Location = new System.Drawing.Point(826, 1);
            this.exit_login.Name = "exit_login";
            this.exit_login.Size = new System.Drawing.Size(27, 26);
            this.exit_login.TabIndex = 0;
            this.exit_login.Text = "X";
            this.exit_login.UseVisualStyleBackColor = false;
            this.exit_login.Click += new System.EventHandler(this.exit_login_Click);
            this.exit_login.MouseEnter += new System.EventHandler(this.exit_btn_color);
            this.exit_login.MouseLeave += new System.EventHandler(this.exit_bttn_color);
            // 
            // password_tx
            // 
            this.password_tx.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.password_tx.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.password_tx.Location = new System.Drawing.Point(315, 362);
            this.password_tx.Name = "password_tx";
            this.password_tx.PasswordChar = '*';
            this.password_tx.Size = new System.Drawing.Size(220, 17);
            this.password_tx.TabIndex = 9;
            // 
            // login_bt
            // 
            this.login_bt.BackColor = System.Drawing.Color.Transparent;
            this.login_bt.Cursor = System.Windows.Forms.Cursors.Hand;
            this.login_bt.FlatAppearance.BorderSize = 0;
            this.login_bt.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.login_bt.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.login_bt.Font = new System.Drawing.Font("BankGothic Lt BT", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.login_bt.Location = new System.Drawing.Point(385, 444);
            this.login_bt.Name = "login_bt";
            this.login_bt.Size = new System.Drawing.Size(85, 25);
            this.login_bt.TabIndex = 11;
            this.login_bt.Text = "Вход";
            this.login_bt.UseVisualStyleBackColor = false;
            this.login_bt.Click += new System.EventHandler(this.login_bt_Click);
            // 
            // signup_btn
            // 
            this.signup_btn.BackColor = System.Drawing.Color.Transparent;
            this.signup_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.signup_btn.FlatAppearance.BorderSize = 0;
            this.signup_btn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.signup_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.signup_btn.Font = new System.Drawing.Font("BankGothic Lt BT", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.signup_btn.Location = new System.Drawing.Point(360, 398);
            this.signup_btn.Name = "signup_btn";
            this.signup_btn.Size = new System.Drawing.Size(139, 30);
            this.signup_btn.TabIndex = 12;
            this.signup_btn.Text = "регистрация";
            this.signup_btn.UseVisualStyleBackColor = false;
            this.signup_btn.Click += new System.EventHandler(this.signup_btn_Click);
            // 
            // login_form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightGray;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(856, 642);
            this.Controls.Add(this.signup_btn);
            this.Controls.Add(this.login_bt);
            this.Controls.Add(this.password_tx);
            this.Controls.Add(this.exit_login);
            this.Controls.Add(this.user_email_tx);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "login_form";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "login_form";
            this.Load += new System.EventHandler(this.login_form_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox user_email_tx;
        private System.Windows.Forms.Button exit_login;
        private System.Windows.Forms.TextBox password_tx;
        private System.Windows.Forms.Button login_bt;
        private System.Windows.Forms.Button signup_btn;
    }
}