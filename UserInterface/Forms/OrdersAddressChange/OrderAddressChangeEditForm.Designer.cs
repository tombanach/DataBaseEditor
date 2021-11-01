
namespace SmayDbEditor.UserInterface.Forms.OrdersAddressChange
{
    partial class OrderAddressChangeEditForm
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
            this.lblOrderAddressChange = new System.Windows.Forms.Label();
            this.lbl_SOno = new System.Windows.Forms.Label();
            this.lbl_DestAddress = new System.Windows.Forms.Label();
            this.lbl_CustCode = new System.Windows.Forms.Label();
            this.lbl_ItemCode = new System.Windows.Forms.Label();
            this.lbl_textline1 = new System.Windows.Forms.Label();
            this.lbl_orddate = new System.Windows.Forms.Label();
            this.txt_SOno = new System.Windows.Forms.TextBox();
            this.txt_CustCode = new System.Windows.Forms.TextBox();
            this.txt_ItemCode = new System.Windows.Forms.TextBox();
            this.txt_textline1 = new System.Windows.Forms.TextBox();
            this.txt_DestAddress = new System.Windows.Forms.TextBox();
            this.gbArticle = new System.Windows.Forms.GroupBox();
            this.dtp_orddate = new System.Windows.Forms.DateTimePicker();
            this.gbOrder = new System.Windows.Forms.GroupBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.gbArticle.SuspendLayout();
            this.gbOrder.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblOrderAddressChange
            // 
            this.lblOrderAddressChange.AutoSize = true;
            this.lblOrderAddressChange.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblOrderAddressChange.Location = new System.Drawing.Point(32, 28);
            this.lblOrderAddressChange.Name = "lblOrderAddressChange";
            this.lblOrderAddressChange.Size = new System.Drawing.Size(265, 32);
            this.lblOrderAddressChange.TabIndex = 0;
            this.lblOrderAddressChange.Text = "Zmiana adresu dostawy";
            // 
            // lbl_SOno
            // 
            this.lbl_SOno.AutoSize = true;
            this.lbl_SOno.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lbl_SOno.Location = new System.Drawing.Point(14, 33);
            this.lbl_SOno.Name = "lbl_SOno";
            this.lbl_SOno.Size = new System.Drawing.Size(100, 17);
            this.lbl_SOno.TabIndex = 1;
            this.lbl_SOno.Text = "Nr zamówienia";
            // 
            // lbl_DestAddress
            // 
            this.lbl_DestAddress.AutoSize = true;
            this.lbl_DestAddress.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lbl_DestAddress.Location = new System.Drawing.Point(14, 118);
            this.lbl_DestAddress.Name = "lbl_DestAddress";
            this.lbl_DestAddress.Size = new System.Drawing.Size(98, 17);
            this.lbl_DestAddress.TabIndex = 2;
            this.lbl_DestAddress.Text = "Adres dostawy";
            // 
            // lbl_CustCode
            // 
            this.lbl_CustCode.AutoSize = true;
            this.lbl_CustCode.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lbl_CustCode.Location = new System.Drawing.Point(14, 33);
            this.lbl_CustCode.Name = "lbl_CustCode";
            this.lbl_CustCode.Size = new System.Drawing.Size(64, 17);
            this.lbl_CustCode.TabIndex = 3;
            this.lbl_CustCode.Text = "Nr klienta";
            // 
            // lbl_ItemCode
            // 
            this.lbl_ItemCode.AutoSize = true;
            this.lbl_ItemCode.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lbl_ItemCode.Location = new System.Drawing.Point(14, 75);
            this.lbl_ItemCode.Name = "lbl_ItemCode";
            this.lbl_ItemCode.Size = new System.Drawing.Size(76, 17);
            this.lbl_ItemCode.TabIndex = 4;
            this.lbl_ItemCode.Text = "Kod towaru";
            // 
            // lbl_textline1
            // 
            this.lbl_textline1.AutoSize = true;
            this.lbl_textline1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lbl_textline1.Location = new System.Drawing.Point(14, 118);
            this.lbl_textline1.Name = "lbl_textline1";
            this.lbl_textline1.Size = new System.Drawing.Size(91, 17);
            this.lbl_textline1.TabIndex = 5;
            this.lbl_textline1.Text = "Nazwa towaru";
            // 
            // lbl_orddate
            // 
            this.lbl_orddate.AutoSize = true;
            this.lbl_orddate.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lbl_orddate.Location = new System.Drawing.Point(14, 75);
            this.lbl_orddate.Name = "lbl_orddate";
            this.lbl_orddate.Size = new System.Drawing.Size(66, 17);
            this.lbl_orddate.TabIndex = 6;
            this.lbl_orddate.Text = "Data zam.";
            // 
            // txt_SOno
            // 
            this.txt_SOno.Enabled = false;
            this.txt_SOno.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.txt_SOno.Location = new System.Drawing.Point(120, 30);
            this.txt_SOno.Name = "txt_SOno";
            this.txt_SOno.Size = new System.Drawing.Size(149, 25);
            this.txt_SOno.TabIndex = 7;
            // 
            // txt_CustCode
            // 
            this.txt_CustCode.Enabled = false;
            this.txt_CustCode.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.txt_CustCode.Location = new System.Drawing.Point(118, 30);
            this.txt_CustCode.Name = "txt_CustCode";
            this.txt_CustCode.Size = new System.Drawing.Size(149, 25);
            this.txt_CustCode.TabIndex = 8;
            // 
            // txt_ItemCode
            // 
            this.txt_ItemCode.Enabled = false;
            this.txt_ItemCode.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.txt_ItemCode.Location = new System.Drawing.Point(120, 72);
            this.txt_ItemCode.Name = "txt_ItemCode";
            this.txt_ItemCode.Size = new System.Drawing.Size(149, 25);
            this.txt_ItemCode.TabIndex = 9;
            // 
            // txt_textline1
            // 
            this.txt_textline1.Enabled = false;
            this.txt_textline1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.txt_textline1.Location = new System.Drawing.Point(120, 115);
            this.txt_textline1.Name = "txt_textline1";
            this.txt_textline1.Size = new System.Drawing.Size(149, 25);
            this.txt_textline1.TabIndex = 10;
            // 
            // txt_DestAddress
            // 
            this.txt_DestAddress.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.txt_DestAddress.Location = new System.Drawing.Point(118, 115);
            this.txt_DestAddress.Name = "txt_DestAddress";
            this.txt_DestAddress.Size = new System.Drawing.Size(181, 25);
            this.txt_DestAddress.TabIndex = 12;
            // 
            // gbArticle
            // 
            this.gbArticle.Controls.Add(this.lbl_SOno);
            this.gbArticle.Controls.Add(this.lbl_ItemCode);
            this.gbArticle.Controls.Add(this.txt_textline1);
            this.gbArticle.Controls.Add(this.txt_ItemCode);
            this.gbArticle.Controls.Add(this.txt_SOno);
            this.gbArticle.Controls.Add(this.lbl_textline1);
            this.gbArticle.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.gbArticle.Location = new System.Drawing.Point(12, 86);
            this.gbArticle.Name = "gbArticle";
            this.gbArticle.Size = new System.Drawing.Size(286, 169);
            this.gbArticle.TabIndex = 13;
            this.gbArticle.TabStop = false;
            this.gbArticle.Text = "Zamówienie";
            // 
            // dtp_orddate
            // 
            this.dtp_orddate.CalendarFont = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.dtp_orddate.CustomFormat = " ";
            this.dtp_orddate.Enabled = false;
            this.dtp_orddate.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.dtp_orddate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtp_orddate.Location = new System.Drawing.Point(118, 72);
            this.dtp_orddate.Name = "dtp_orddate";
            this.dtp_orddate.Size = new System.Drawing.Size(149, 25);
            this.dtp_orddate.TabIndex = 13;
            this.dtp_orddate.ValueChanged += new System.EventHandler(this.dtp_ValueChanged);
            // 
            // gbOrder
            // 
            this.gbOrder.Controls.Add(this.dtp_orddate);
            this.gbOrder.Controls.Add(this.lbl_CustCode);
            this.gbOrder.Controls.Add(this.txt_DestAddress);
            this.gbOrder.Controls.Add(this.lbl_orddate);
            this.gbOrder.Controls.Add(this.txt_CustCode);
            this.gbOrder.Controls.Add(this.lbl_DestAddress);
            this.gbOrder.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.gbOrder.Location = new System.Drawing.Point(312, 86);
            this.gbOrder.Name = "gbOrder";
            this.gbOrder.Size = new System.Drawing.Size(316, 169);
            this.gbOrder.TabIndex = 14;
            this.gbOrder.TabStop = false;
            this.gbOrder.Text = "Towar";
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.White;
            this.btnSave.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnSave.Image = global::SmayDbEditor.UserInterface.Properties.Resources.save_32;
            this.btnSave.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSave.Location = new System.Drawing.Point(411, 264);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(97, 42);
            this.btnSave.TabIndex = 15;
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
            this.btnCancel.Location = new System.Drawing.Point(514, 264);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(97, 42);
            this.btnCancel.TabIndex = 16;
            this.btnCancel.Text = "Anuluj";
            this.btnCancel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // OrderAddressChangeEditForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(640, 318);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.gbOrder);
            this.Controls.Add(this.gbArticle);
            this.Controls.Add(this.lblOrderAddressChange);
            this.KeyPreview = true;
            this.Name = "OrderAddressChangeEditForm";
            this.Text = "Zmiana adresu dostawy";
            this.gbArticle.ResumeLayout(false);
            this.gbArticle.PerformLayout();
            this.gbOrder.ResumeLayout(false);
            this.gbOrder.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblOrderAddressChange;
        private System.Windows.Forms.Label lbl_SOno;
        private System.Windows.Forms.Label lbl_DestAddress;
        private System.Windows.Forms.Label lbl_CustCode;
        private System.Windows.Forms.Label lbl_ItemCode;
        private System.Windows.Forms.Label lbl_textline1;
        private System.Windows.Forms.Label lbl_orddate;
        private System.Windows.Forms.TextBox txt_SOno;
        private System.Windows.Forms.TextBox txt_CustCode;
        private System.Windows.Forms.TextBox txt_ItemCode;
        private System.Windows.Forms.TextBox txt_textline1;
        private System.Windows.Forms.TextBox txt_DestAddress;
        private System.Windows.Forms.GroupBox gbArticle;
        private System.Windows.Forms.GroupBox gbOrder;
        private System.Windows.Forms.DateTimePicker dtp_orddate;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnCancel;
    }
}