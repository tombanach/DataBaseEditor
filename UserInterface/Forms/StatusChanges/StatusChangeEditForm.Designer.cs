
namespace SmayDbEditor.UserInterface.Forms.StatusChanges
{
    partial class StatusChangeEditForm
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
            this.components = new System.ComponentModel.Container();
            this.lblStatusChange = new System.Windows.Forms.Label();
            this.lblActiveStatus = new System.Windows.Forms.Label();
            this.txtimph_status = new System.Windows.Forms.TextBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.lblimph_num = new System.Windows.Forms.Label();
            this.lblimph_type = new System.Windows.Forms.Label();
            this.txtimph_num = new System.Windows.Forms.TextBox();
            this.txtimph_type = new System.Windows.Forms.TextBox();
            this.epStatus = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.epStatus)).BeginInit();
            this.SuspendLayout();
            // 
            // lblStatusChange
            // 
            this.lblStatusChange.AutoSize = true;
            this.lblStatusChange.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblStatusChange.Location = new System.Drawing.Point(12, 9);
            this.lblStatusChange.Name = "lblStatusChange";
            this.lblStatusChange.Size = new System.Drawing.Size(271, 30);
            this.lblStatusChange.TabIndex = 0;
            this.lblStatusChange.Text = "Zmiana statusu zamówienia";
            // 
            // lblActiveStatus
            // 
            this.lblActiveStatus.AutoSize = true;
            this.lblActiveStatus.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblActiveStatus.Location = new System.Drawing.Point(12, 151);
            this.lblActiveStatus.Name = "lblActiveStatus";
            this.lblActiveStatus.Size = new System.Drawing.Size(108, 21);
            this.lblActiveStatus.TabIndex = 1;
            this.lblActiveStatus.Text = "Zmień status";
            // 
            // txtimph_status
            // 
            this.txtimph_status.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.txtimph_status.Location = new System.Drawing.Point(126, 148);
            this.txtimph_status.Name = "txtimph_status";
            this.txtimph_status.Size = new System.Drawing.Size(55, 29);
            this.txtimph_status.TabIndex = 2;
            this.txtimph_status.TextChanged += new System.EventHandler(this.txtStatus_TextChanged);
            this.txtimph_status.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtStatus_KeyPress);
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.White;
            this.btnSave.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnSave.Image = global::SmayDbEditor.UserInterface.Properties.Resources.save_32;
            this.btnSave.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSave.Location = new System.Drawing.Point(106, 206);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(86, 38);
            this.btnSave.TabIndex = 3;
            this.btnSave.Text = "Zapisz";
            this.btnSave.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.BackColor = System.Drawing.Color.White;
            this.btnCancel.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnCancel.Image = global::SmayDbEditor.UserInterface.Properties.Resources.cancel_32;
            this.btnCancel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCancel.Location = new System.Drawing.Point(198, 206);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(86, 38);
            this.btnCancel.TabIndex = 4;
            this.btnCancel.Text = "Anuluj";
            this.btnCancel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // lblimph_num
            // 
            this.lblimph_num.AutoSize = true;
            this.lblimph_num.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblimph_num.Location = new System.Drawing.Point(17, 66);
            this.lblimph_num.Name = "lblimph_num";
            this.lblimph_num.Size = new System.Drawing.Size(48, 17);
            this.lblimph_num.TabIndex = 5;
            this.lblimph_num.Text = "Numer";
            // 
            // lblimph_type
            // 
            this.lblimph_type.AutoSize = true;
            this.lblimph_type.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblimph_type.Location = new System.Drawing.Point(17, 99);
            this.lblimph_type.Name = "lblimph_type";
            this.lblimph_type.Size = new System.Drawing.Size(28, 17);
            this.lblimph_type.TabIndex = 6;
            this.lblimph_type.Text = "Typ";
            // 
            // txtimph_num
            // 
            this.txtimph_num.Enabled = false;
            this.txtimph_num.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.txtimph_num.Location = new System.Drawing.Point(71, 63);
            this.txtimph_num.Name = "txtimph_num";
            this.txtimph_num.Size = new System.Drawing.Size(100, 25);
            this.txtimph_num.TabIndex = 7;
            // 
            // txtimph_type
            // 
            this.txtimph_type.Enabled = false;
            this.txtimph_type.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.txtimph_type.Location = new System.Drawing.Point(71, 96);
            this.txtimph_type.Name = "txtimph_type";
            this.txtimph_type.Size = new System.Drawing.Size(56, 25);
            this.txtimph_type.TabIndex = 8;
            // 
            // epStatus
            // 
            this.epStatus.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
            this.epStatus.ContainerControl = this;
            // 
            // StatusChangeEditForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(298, 256);
            this.Controls.Add(this.txtimph_type);
            this.Controls.Add(this.txtimph_num);
            this.Controls.Add(this.lblimph_type);
            this.Controls.Add(this.lblimph_num);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.txtimph_status);
            this.Controls.Add(this.lblActiveStatus);
            this.Controls.Add(this.lblStatusChange);
            this.KeyPreview = true;
            this.Name = "StatusChangeEditForm";
            this.Text = "Zmiana statusu zamówienia";
            ((System.ComponentModel.ISupportInitialize)(this.epStatus)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblStatusChange;
        private System.Windows.Forms.Label lblActiveStatus;
        private System.Windows.Forms.TextBox txtimph_status;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Label lblimph_num;
        private System.Windows.Forms.Label lblimph_type;
        private System.Windows.Forms.TextBox txtimph_num;
        private System.Windows.Forms.TextBox txtimph_type;
        private System.Windows.Forms.ErrorProvider epStatus;
    }
}