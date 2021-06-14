namespace Refrigerant_Project_TU_3
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.button1 = new System.Windows.Forms.Button();
            this.fridge_btn = new System.Windows.Forms.Button();
            this.aircon_btn = new System.Windows.Forms.Button();
            this.exit_login = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // backgroundWorker1
            // 
            this.backgroundWorker1.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker1_DoWork);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Transparent;
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.FlatAppearance.BorderColor = System.Drawing.Color.LightBlue;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Location = new System.Drawing.Point(858, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(25, 27);
            this.button1.TabIndex = 0;
            this.button1.Text = "X";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            this.button1.MouseEnter += new System.EventHandler(this.exit_btn_color_change);
            this.button1.MouseLeave += new System.EventHandler(this.exit_bttn_color_back);
            // 
            // fridge_btn
            // 
            this.fridge_btn.BackColor = System.Drawing.Color.Transparent;
            this.fridge_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.fridge_btn.FlatAppearance.BorderSize = 0;
            this.fridge_btn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.fridge_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.fridge_btn.Location = new System.Drawing.Point(-1, 51);
            this.fridge_btn.Name = "fridge_btn";
            this.fridge_btn.Size = new System.Drawing.Size(420, 584);
            this.fridge_btn.TabIndex = 1;
            this.fridge_btn.UseVisualStyleBackColor = false;
            this.fridge_btn.Click += new System.EventHandler(this.fridge_btn_Click);
            // 
            // aircon_btn
            // 
            this.aircon_btn.BackColor = System.Drawing.Color.Transparent;
            this.aircon_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.aircon_btn.FlatAppearance.BorderSize = 0;
            this.aircon_btn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.aircon_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.aircon_btn.Location = new System.Drawing.Point(416, 51);
            this.aircon_btn.Name = "aircon_btn";
            this.aircon_btn.Size = new System.Drawing.Size(430, 584);
            this.aircon_btn.TabIndex = 2;
            this.aircon_btn.UseVisualStyleBackColor = false;
            this.aircon_btn.Click += new System.EventHandler(this.aircon_btn_Click);
            // 
            // exit_login
            // 
            this.exit_login.BackColor = System.Drawing.Color.Transparent;
            this.exit_login.Cursor = System.Windows.Forms.Cursors.Hand;
            this.exit_login.FlatAppearance.BorderSize = 0;
            this.exit_login.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.exit_login.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.exit_login.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exit_login.Location = new System.Drawing.Point(817, 1);
            this.exit_login.Name = "exit_login";
            this.exit_login.Size = new System.Drawing.Size(29, 29);
            this.exit_login.TabIndex = 13;
            this.exit_login.Text = "X";
            this.exit_login.UseVisualStyleBackColor = false;
            this.exit_login.Click += new System.EventHandler(this.exit_login_Click);
            this.exit_login.MouseEnter += new System.EventHandler(this.exit_btn_color_change);
            this.exit_login.MouseLeave += new System.EventHandler(this.exit_bttn_color_back);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(846, 637);
            this.Controls.Add(this.exit_login);
            this.Controls.Add(this.aircon_btn);
            this.Controls.Add(this.fridge_btn);
            this.Controls.Add(this.button1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button fridge;
        private System.Windows.Forms.Button fridge_btn;
        private System.Windows.Forms.Button aircon_btn;
        private System.Windows.Forms.Button exit_login;

        public System.Windows.Forms.Button isFridge { get; set; }
    }
}

