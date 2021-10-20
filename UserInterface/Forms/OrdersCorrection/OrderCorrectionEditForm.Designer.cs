
namespace SmayDbEditor.UserInterface.Forms.OrdersCorrection
{
    partial class OrderCorrectionEditForm
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
            this.lblOrderCorrection = new System.Windows.Forms.Label();
            this.txtPodet_Id = new System.Windows.Forms.TextBox();
            this.txtPorel_Itemcode = new System.Windows.Forms.TextBox();
            this.txtPorel_Pono = new System.Windows.Forms.TextBox();
            this.txtPorel_Poline = new System.Windows.Forms.TextBox();
            this.dtpPorel_Tstamp = new System.Windows.Forms.DateTimePicker();
            this.txtPorel_Qty = new System.Windows.Forms.TextBox();
            this.lblPorel_Tstamp = new System.Windows.Forms.Label();
            this.lblPorel_Qty = new System.Windows.Forms.Label();
            this.lblPorel_Poline = new System.Windows.Forms.Label();
            this.lblPorel_Pono = new System.Windows.Forms.Label();
            this.lblPorel_Itemcode = new System.Windows.Forms.Label();
            this.lblPodet_Id = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.epPorel_Pono = new System.Windows.Forms.ErrorProvider(this.components);
            this.epPorel_Qty = new System.Windows.Forms.ErrorProvider(this.components);
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.epPorel_Pono)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.epPorel_Qty)).BeginInit();
            this.SuspendLayout();
            // 
            // lblOrderCorrection
            // 
            this.lblOrderCorrection.AutoSize = true;
            this.lblOrderCorrection.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblOrderCorrection.Location = new System.Drawing.Point(12, 9);
            this.lblOrderCorrection.Name = "lblOrderCorrection";
            this.lblOrderCorrection.Size = new System.Drawing.Size(178, 30);
            this.lblOrderCorrection.TabIndex = 0;
            this.lblOrderCorrection.Text = "Dane zamówienia";
            // 
            // txtPodet_Id
            // 
            this.txtPodet_Id.Enabled = false;
            this.txtPodet_Id.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.txtPodet_Id.Location = new System.Drawing.Point(140, 25);
            this.txtPodet_Id.Name = "txtPodet_Id";
            this.txtPodet_Id.Size = new System.Drawing.Size(150, 25);
            this.txtPodet_Id.TabIndex = 3;
            // 
            // txtPorel_Itemcode
            // 
            this.txtPorel_Itemcode.Enabled = false;
            this.txtPorel_Itemcode.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.txtPorel_Itemcode.Location = new System.Drawing.Point(140, 64);
            this.txtPorel_Itemcode.Name = "txtPorel_Itemcode";
            this.txtPorel_Itemcode.Size = new System.Drawing.Size(150, 25);
            this.txtPorel_Itemcode.TabIndex = 4;
            // 
            // txtPorel_Pono
            // 
            this.txtPorel_Pono.Enabled = false;
            this.txtPorel_Pono.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.txtPorel_Pono.Location = new System.Drawing.Point(140, 23);
            this.txtPorel_Pono.Name = "txtPorel_Pono";
            this.txtPorel_Pono.Size = new System.Drawing.Size(150, 25);
            this.txtPorel_Pono.TabIndex = 6;
            this.txtPorel_Pono.TextChanged += new System.EventHandler(this.txtPorel_Pono_TextChanged);
            this.txtPorel_Pono.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPorel_Pono_KeyPress);
            // 
            // txtPorel_Poline
            // 
            this.txtPorel_Poline.Enabled = false;
            this.txtPorel_Poline.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.txtPorel_Poline.Location = new System.Drawing.Point(140, 104);
            this.txtPorel_Poline.Name = "txtPorel_Poline";
            this.txtPorel_Poline.Size = new System.Drawing.Size(150, 25);
            this.txtPorel_Poline.TabIndex = 9;
            // 
            // dtpPorel_Tstamp
            // 
            this.dtpPorel_Tstamp.CustomFormat = " ";
            this.dtpPorel_Tstamp.Enabled = false;
            this.dtpPorel_Tstamp.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.dtpPorel_Tstamp.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpPorel_Tstamp.Location = new System.Drawing.Point(140, 144);
            this.dtpPorel_Tstamp.Name = "dtpPorel_Tstamp";
            this.dtpPorel_Tstamp.Size = new System.Drawing.Size(150, 25);
            this.dtpPorel_Tstamp.TabIndex = 10;
            this.dtpPorel_Tstamp.ValueChanged += new System.EventHandler(this.dtp_ValueChanged);
            // 
            // txtPorel_Qty
            // 
            this.txtPorel_Qty.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.txtPorel_Qty.Location = new System.Drawing.Point(140, 60);
            this.txtPorel_Qty.Name = "txtPorel_Qty";
            this.txtPorel_Qty.Size = new System.Drawing.Size(150, 25);
            this.txtPorel_Qty.TabIndex = 12;
            this.txtPorel_Qty.TextChanged += new System.EventHandler(this.txtPorel_Qty_TextChanged);
            this.txtPorel_Qty.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPorel_Qty_KeyPress);
            // 
            // lblPorel_Tstamp
            // 
            this.lblPorel_Tstamp.AutoSize = true;
            this.lblPorel_Tstamp.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblPorel_Tstamp.Location = new System.Drawing.Point(2, 150);
            this.lblPorel_Tstamp.Name = "lblPorel_Tstamp";
            this.lblPorel_Tstamp.Size = new System.Drawing.Size(37, 17);
            this.lblPorel_Tstamp.TabIndex = 8;
            this.lblPorel_Tstamp.Text = "Data";
            // 
            // lblPorel_Qty
            // 
            this.lblPorel_Qty.AutoSize = true;
            this.lblPorel_Qty.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblPorel_Qty.Location = new System.Drawing.Point(2, 64);
            this.lblPorel_Qty.Name = "lblPorel_Qty";
            this.lblPorel_Qty.Size = new System.Drawing.Size(41, 16);
            this.lblPorel_Qty.TabIndex = 11;
            this.lblPorel_Qty.Text = "Ilość";
            // 
            // lblPorel_Poline
            // 
            this.lblPorel_Poline.AutoSize = true;
            this.lblPorel_Poline.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblPorel_Poline.Location = new System.Drawing.Point(2, 107);
            this.lblPorel_Poline.Name = "lblPorel_Poline";
            this.lblPorel_Poline.Size = new System.Drawing.Size(67, 17);
            this.lblPorel_Poline.TabIndex = 7;
            this.lblPorel_Poline.Text = "Kod Scala";
            // 
            // lblPorel_Pono
            // 
            this.lblPorel_Pono.AutoSize = true;
            this.lblPorel_Pono.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblPorel_Pono.Location = new System.Drawing.Point(2, 26);
            this.lblPorel_Pono.Name = "lblPorel_Pono";
            this.lblPorel_Pono.Size = new System.Drawing.Size(127, 17);
            this.lblPorel_Pono.TabIndex = 5;
            this.lblPorel_Pono.Text = "Numer zamówienia";
            // 
            // lblPorel_Itemcode
            // 
            this.lblPorel_Itemcode.AutoSize = true;
            this.lblPorel_Itemcode.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblPorel_Itemcode.Location = new System.Drawing.Point(2, 67);
            this.lblPorel_Itemcode.Name = "lblPorel_Itemcode";
            this.lblPorel_Itemcode.Size = new System.Drawing.Size(79, 17);
            this.lblPorel_Itemcode.TabIndex = 2;
            this.lblPorel_Itemcode.Text = "Kod towaru";
            // 
            // lblPodet_Id
            // 
            this.lblPodet_Id.AutoSize = true;
            this.lblPodet_Id.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblPodet_Id.Location = new System.Drawing.Point(2, 28);
            this.lblPodet_Id.Name = "lblPodet_Id";
            this.lblPodet_Id.Size = new System.Drawing.Size(22, 17);
            this.lblPodet_Id.TabIndex = 1;
            this.lblPodet_Id.Text = "ID";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lblPorel_Pono);
            this.groupBox1.Controls.Add(this.txtPorel_Qty);
            this.groupBox1.Controls.Add(this.txtPorel_Pono);
            this.groupBox1.Controls.Add(this.lblPorel_Qty);
            this.groupBox1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.groupBox1.Location = new System.Drawing.Point(12, 54);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(310, 102);
            this.groupBox1.TabIndex = 13;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Edytuj";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lblPodet_Id);
            this.groupBox2.Controls.Add(this.txtPodet_Id);
            this.groupBox2.Controls.Add(this.dtpPorel_Tstamp);
            this.groupBox2.Controls.Add(this.lblPorel_Itemcode);
            this.groupBox2.Controls.Add(this.lblPorel_Tstamp);
            this.groupBox2.Controls.Add(this.txtPorel_Poline);
            this.groupBox2.Controls.Add(this.txtPorel_Itemcode);
            this.groupBox2.Controls.Add(this.lblPorel_Poline);
            this.groupBox2.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.groupBox2.Location = new System.Drawing.Point(12, 171);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(310, 184);
            this.groupBox2.TabIndex = 14;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Dodatkowe informacje";
            // 
            // btnCancel
            // 
            this.btnCancel.BackColor = System.Drawing.Color.White;
            this.btnCancel.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnCancel.Image = global::SmayDbEditor.UserInterface.Properties.Resources.cancel_32;
            this.btnCancel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCancel.Location = new System.Drawing.Point(231, 361);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(91, 42);
            this.btnCancel.TabIndex = 16;
            this.btnCancel.Text = "Anuluj";
            this.btnCancel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.White;
            this.btnSave.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnSave.Image = global::SmayDbEditor.UserInterface.Properties.Resources.save_32;
            this.btnSave.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSave.Location = new System.Drawing.Point(132, 361);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(92, 42);
            this.btnSave.TabIndex = 15;
            this.btnSave.Text = "Zapisz";
            this.btnSave.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // epPorel_Pono
            // 
            this.epPorel_Pono.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
            this.epPorel_Pono.ContainerControl = this;
            // 
            // epPorel_Qty
            // 
            this.epPorel_Qty.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
            this.epPorel_Qty.ContainerControl = this;
            // 
            // OrderCorrectionEditForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(334, 411);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.lblOrderCorrection);
            this.KeyPreview = true;
            this.Name = "OrderCorrectionEditForm";
            this.Text = "Edytuj zamówienie";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.epPorel_Pono)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.epPorel_Qty)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblOrderCorrection;
        private System.Windows.Forms.TextBox txtPodet_Id;
        private System.Windows.Forms.TextBox txtPorel_Itemcode;
        private System.Windows.Forms.TextBox txtPorel_Pono;
        private System.Windows.Forms.TextBox txtPorel_Poline;
        private System.Windows.Forms.DateTimePicker dtpPorel_Tstamp;
        private System.Windows.Forms.TextBox txtPorel_Qty;
        private System.Windows.Forms.Label lblPorel_Tstamp;
        private System.Windows.Forms.Label lblPorel_Qty;
        private System.Windows.Forms.Label lblPorel_Poline;
        private System.Windows.Forms.Label lblPorel_Pono;
        private System.Windows.Forms.Label lblPorel_Itemcode;
        private System.Windows.Forms.Label lblPodet_Id;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.ErrorProvider epPorel_Pono;
        private System.Windows.Forms.ErrorProvider epPorel_Qty;
    }
}