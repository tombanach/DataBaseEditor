namespace SmayDbEditor.UserInterface.Forms
{
    partial class RegisterForm
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
            this.lblLoginUser = new System.Windows.Forms.Label();
            this.txtLoginUser = new System.Windows.Forms.TextBox();
            this.lblPasswordUser = new System.Windows.Forms.Label();
            this.txtPasswordUser = new System.Windows.Forms.TextBox();
            this.btnAddRegister = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cbAccountType = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblLoginUser
            // 
            this.lblLoginUser.AutoSize = true;
            this.lblLoginUser.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblLoginUser.Location = new System.Drawing.Point(273, 79);
            this.lblLoginUser.Name = "lblLoginUser";
            this.lblLoginUser.Size = new System.Drawing.Size(49, 21);
            this.lblLoginUser.TabIndex = 0;
            this.lblLoginUser.Text = "Login";
            // 
            // txtLoginUser
            // 
            this.txtLoginUser.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.txtLoginUser.Location = new System.Drawing.Point(360, 76);
            this.txtLoginUser.Name = "txtLoginUser";
            this.txtLoginUser.Size = new System.Drawing.Size(163, 29);
            this.txtLoginUser.TabIndex = 1;
            // 
            // lblPasswordUser
            // 
            this.lblPasswordUser.AutoSize = true;
            this.lblPasswordUser.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblPasswordUser.Location = new System.Drawing.Point(273, 134);
            this.lblPasswordUser.Name = "lblPasswordUser";
            this.lblPasswordUser.Size = new System.Drawing.Size(49, 21);
            this.lblPasswordUser.TabIndex = 2;
            this.lblPasswordUser.Text = "Hasło";
            // 
            // txtPasswordUser
            // 
            this.txtPasswordUser.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.txtPasswordUser.Location = new System.Drawing.Point(360, 131);
            this.txtPasswordUser.Name = "txtPasswordUser";
            this.txtPasswordUser.PasswordChar = '*';
            this.txtPasswordUser.Size = new System.Drawing.Size(163, 29);
            this.txtPasswordUser.TabIndex = 3;
            // 
            // btnAddRegister
            // 
            this.btnAddRegister.Location = new System.Drawing.Point(360, 256);
            this.btnAddRegister.Name = "btnAddRegister";
            this.btnAddRegister.Size = new System.Drawing.Size(112, 43);
            this.btnAddRegister.TabIndex = 5;
            this.btnAddRegister.Text = "Dodaj";
            this.btnAddRegister.UseVisualStyleBackColor = true;
            this.btnAddRegister.Click += new System.EventHandler(this.btnAddRegister_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(171, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(352, 20);
            this.label1.TabIndex = 6;
            this.label1.Text = "REJESTRACJA NOWEGO UŻYTKOWNIKA";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::SmayDbEditor.UserInterface.Properties.Resources._891399;
            this.pictureBox1.Location = new System.Drawing.Point(32, 76);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(138, 129);
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.Location = new System.Drawing.Point(274, 190);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 15);
            this.label2.TabIndex = 8;
            this.label2.Text = "Rodzaj Konta";
            // 
            // cbAccountType
            // 
            this.cbAccountType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbAccountType.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.cbAccountType.FormattingEnabled = true;
            this.cbAccountType.Items.AddRange(new object[] {
            "Standardowy",
            "Administrator"});
            this.cbAccountType.Location = new System.Drawing.Point(360, 185);
            this.cbAccountType.Name = "cbAccountType";
            this.cbAccountType.Size = new System.Drawing.Size(134, 25);
            this.cbAccountType.TabIndex = 9;
            // 
            // RegisterForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(778, 365);
            this.Controls.Add(this.cbAccountType);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnAddRegister);
            this.Controls.Add(this.txtPasswordUser);
            this.Controls.Add(this.lblPasswordUser);
            this.Controls.Add(this.txtLoginUser);
            this.Controls.Add(this.lblLoginUser);
            this.Name = "RegisterForm";
            this.Text = "Dodaj użytkownika";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblLoginUser;
        private System.Windows.Forms.TextBox txtLoginUser;
        private System.Windows.Forms.Label lblPasswordUser;
        private System.Windows.Forms.TextBox txtPasswordUser;
        private System.Windows.Forms.Button btnAddRegister;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbAccountType;
    }
}