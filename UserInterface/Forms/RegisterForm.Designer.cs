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
            this.btnCancelRegister = new System.Windows.Forms.Button();
            this.btnAddRegister = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblLoginUser
            // 
            this.lblLoginUser.AutoSize = true;
            this.lblLoginUser.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblLoginUser.Location = new System.Drawing.Point(52, 62);
            this.lblLoginUser.Name = "lblLoginUser";
            this.lblLoginUser.Size = new System.Drawing.Size(40, 17);
            this.lblLoginUser.TabIndex = 0;
            this.lblLoginUser.Text = "Login";
            // 
            // txtLoginUser
            // 
            this.txtLoginUser.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.txtLoginUser.Location = new System.Drawing.Point(150, 59);
            this.txtLoginUser.Name = "txtLoginUser";
            this.txtLoginUser.Size = new System.Drawing.Size(146, 25);
            this.txtLoginUser.TabIndex = 1;
            // 
            // lblPasswordUser
            // 
            this.lblPasswordUser.AutoSize = true;
            this.lblPasswordUser.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblPasswordUser.Location = new System.Drawing.Point(52, 103);
            this.lblPasswordUser.Name = "lblPasswordUser";
            this.lblPasswordUser.Size = new System.Drawing.Size(41, 17);
            this.lblPasswordUser.TabIndex = 2;
            this.lblPasswordUser.Text = "Hasło";
            // 
            // txtPasswordUser
            // 
            this.txtPasswordUser.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.txtPasswordUser.Location = new System.Drawing.Point(150, 100);
            this.txtPasswordUser.Name = "txtPasswordUser";
            this.txtPasswordUser.Size = new System.Drawing.Size(146, 25);
            this.txtPasswordUser.TabIndex = 3;
            // 
            // btnCancelRegister
            // 
            this.btnCancelRegister.Location = new System.Drawing.Point(195, 166);
            this.btnCancelRegister.Name = "btnCancelRegister";
            this.btnCancelRegister.Size = new System.Drawing.Size(101, 42);
            this.btnCancelRegister.TabIndex = 4;
            this.btnCancelRegister.Text = "Anuluj";
            this.btnCancelRegister.UseVisualStyleBackColor = true;
            this.btnCancelRegister.Click += new System.EventHandler(this.btnCancelRegister_Click);
            // 
            // btnAddRegister
            // 
            this.btnAddRegister.Location = new System.Drawing.Point(90, 166);
            this.btnAddRegister.Name = "btnAddRegister";
            this.btnAddRegister.Size = new System.Drawing.Size(99, 42);
            this.btnAddRegister.TabIndex = 5;
            this.btnAddRegister.Text = "Dodaj";
            this.btnAddRegister.UseVisualStyleBackColor = true;
            this.btnAddRegister.Click += new System.EventHandler(this.btnAddRegister_Click);
            // 
            // RegisterForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(336, 247);
            this.Controls.Add(this.btnAddRegister);
            this.Controls.Add(this.btnCancelRegister);
            this.Controls.Add(this.txtPasswordUser);
            this.Controls.Add(this.lblPasswordUser);
            this.Controls.Add(this.txtLoginUser);
            this.Controls.Add(this.lblLoginUser);
            this.Name = "RegisterForm";
            this.Text = "Dodaj użytkownika";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblLoginUser;
        private System.Windows.Forms.TextBox txtLoginUser;
        private System.Windows.Forms.Label lblPasswordUser;
        private System.Windows.Forms.TextBox txtPasswordUser;
        private System.Windows.Forms.Button btnCancelRegister;
        private System.Windows.Forms.Button btnAddRegister;
    }
}