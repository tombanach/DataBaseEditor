namespace SmayDbEditor.UserInterface.Forms.OrdersStatistics
{
    partial class OrdersStatisticsForm
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
            this.tlpOrdersStatistics = new System.Windows.Forms.TableLayoutPanel();
            this.pOrdersStatistics = new System.Windows.Forms.Panel();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.dgvOrdersStatistics = new System.Windows.Forms.DataGridView();
            this.tlpOrdersStatistics.SuspendLayout();
            this.pOrdersStatistics.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOrdersStatistics)).BeginInit();
            this.SuspendLayout();
            // 
            // tlpOrdersStatistics
            // 
            this.tlpOrdersStatistics.ColumnCount = 1;
            this.tlpOrdersStatistics.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpOrdersStatistics.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tlpOrdersStatistics.Controls.Add(this.pOrdersStatistics, 0, 0);
            this.tlpOrdersStatistics.Controls.Add(this.dgvOrdersStatistics, 0, 1);
            this.tlpOrdersStatistics.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpOrdersStatistics.Location = new System.Drawing.Point(0, 0);
            this.tlpOrdersStatistics.Name = "tlpOrdersStatistics";
            this.tlpOrdersStatistics.RowCount = 2;
            this.tlpOrdersStatistics.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tlpOrdersStatistics.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpOrdersStatistics.Size = new System.Drawing.Size(800, 450);
            this.tlpOrdersStatistics.TabIndex = 0;
            // 
            // pOrdersStatistics
            // 
            this.pOrdersStatistics.Controls.Add(this.btnRefresh);
            this.pOrdersStatistics.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pOrdersStatistics.Location = new System.Drawing.Point(3, 3);
            this.pOrdersStatistics.Name = "pOrdersStatistics";
            this.pOrdersStatistics.Size = new System.Drawing.Size(794, 34);
            this.pOrdersStatistics.TabIndex = 0;
            // 
            // btnRefresh
            // 
            this.btnRefresh.BackColor = System.Drawing.Color.White;
            this.btnRefresh.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnRefresh.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnRefresh.Image = global::SmayDbEditor.UserInterface.Properties.Resources.refresh_24;
            this.btnRefresh.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnRefresh.Location = new System.Drawing.Point(0, 0);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(100, 34);
            this.btnRefresh.TabIndex = 0;
            this.btnRefresh.Text = "Odśwież";
            this.btnRefresh.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnRefresh.UseVisualStyleBackColor = false;
            // 
            // dgvOrdersStatistics
            // 
            this.dgvOrdersStatistics.AllowUserToAddRows = false;
            this.dgvOrdersStatistics.AllowUserToDeleteRows = false;
            this.dgvOrdersStatistics.BackgroundColor = System.Drawing.Color.White;
            this.dgvOrdersStatistics.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvOrdersStatistics.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvOrdersStatistics.Location = new System.Drawing.Point(3, 43);
            this.dgvOrdersStatistics.Name = "dgvOrdersStatistics";
            this.dgvOrdersStatistics.ReadOnly = true;
            this.dgvOrdersStatistics.Size = new System.Drawing.Size(794, 404);
            this.dgvOrdersStatistics.TabIndex = 1;
            // 
            // OrdersStatisticsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tlpOrdersStatistics);
            this.Name = "OrdersStatisticsForm";
            this.Text = "Statystyki zam.";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.OrdersStatisticsForm_FormClosed);
            this.tlpOrdersStatistics.ResumeLayout(false);
            this.pOrdersStatistics.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvOrdersStatistics)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tlpOrdersStatistics;
        private System.Windows.Forms.Panel pOrdersStatistics;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.DataGridView dgvOrdersStatistics;
    }
}