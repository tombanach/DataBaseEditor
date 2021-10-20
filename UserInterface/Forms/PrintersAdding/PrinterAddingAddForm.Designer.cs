
namespace SmayDbEditor.UserInterface.Forms.PrintersAdding
{
    partial class PrinterAddingAddForm
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
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblPrinter = new System.Windows.Forms.Label();
            this.lblComputerName = new System.Windows.Forms.Label();
            this.txtComputerName = new System.Windows.Forms.TextBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.txtPrinterName = new System.Windows.Forms.TextBox();
            this.epPrinterName = new System.Windows.Forms.ErrorProvider(this.components);
            this.epComputerName = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.epPrinterName)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.epComputerName)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblTitle.Location = new System.Drawing.Point(28, 30);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(281, 30);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "Dodanie drukarki etykietowej";
            // 
            // lblPrinter
            // 
            this.lblPrinter.AutoSize = true;
            this.lblPrinter.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblPrinter.Location = new System.Drawing.Point(12, 107);
            this.lblPrinter.Name = "lblPrinter";
            this.lblPrinter.Size = new System.Drawing.Size(118, 20);
            this.lblPrinter.TabIndex = 1;
            this.lblPrinter.Text = "Nazwa drukarki";
            // 
            // lblComputerName
            // 
            this.lblComputerName.AutoSize = true;
            this.lblComputerName.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblComputerName.Location = new System.Drawing.Point(12, 155);
            this.lblComputerName.Name = "lblComputerName";
            this.lblComputerName.Size = new System.Drawing.Size(137, 20);
            this.lblComputerName.TabIndex = 2;
            this.lblComputerName.Text = "Nazwa komputera";
            // 
            // txtComputerName
            // 
            this.txtComputerName.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.txtComputerName.Location = new System.Drawing.Point(164, 152);
            this.txtComputerName.Name = "txtComputerName";
            this.txtComputerName.Size = new System.Drawing.Size(145, 27);
            this.txtComputerName.TabIndex = 4;
            this.txtComputerName.TextChanged += new System.EventHandler(this.txtComputerName_TextChanged);
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.White;
            this.btnSave.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnSave.Image = global::SmayDbEditor.UserInterface.Properties.Resources.save_32;
            this.btnSave.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSave.Location = new System.Drawing.Point(116, 230);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(93, 40);
            this.btnSave.TabIndex = 5;
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
            this.btnCancel.Location = new System.Drawing.Point(216, 230);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(93, 40);
            this.btnCancel.TabIndex = 6;
            this.btnCancel.Text = "Anuluj";
            this.btnCancel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // txtPrinterName
            // 
            this.txtPrinterName.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.txtPrinterName.Location = new System.Drawing.Point(164, 104);
            this.txtPrinterName.Name = "txtPrinterName";
            this.txtPrinterName.Size = new System.Drawing.Size(145, 27);
            this.txtPrinterName.TabIndex = 7;
            this.txtPrinterName.TextChanged += new System.EventHandler(this.txtPrinterName_TextChanged);
            // 
            // epPrinterName
            // 
            this.epPrinterName.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
            this.epPrinterName.ContainerControl = this;
            // 
            // epComputerName
            // 
            this.epComputerName.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
            this.epComputerName.ContainerControl = this;
            // 
            // PrinterAddingAddForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(338, 282);
            this.Controls.Add(this.txtPrinterName);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.txtComputerName);
            this.Controls.Add(this.lblComputerName);
            this.Controls.Add(this.lblPrinter);
            this.Controls.Add(this.lblTitle);
            this.KeyPreview = true;
            this.Name = "PrinterAddingAddForm";
            this.Text = "Dodaj komputer do drukarki";
            ((System.ComponentModel.ISupportInitialize)(this.epPrinterName)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.epComputerName)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblPrinter;
        private System.Windows.Forms.Label lblComputerName;
        private System.Windows.Forms.TextBox txtComputerName;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.TextBox txtPrinterName;
        private System.Windows.Forms.ErrorProvider epPrinterName;
        private System.Windows.Forms.ErrorProvider epComputerName;
    }
}