
namespace SmayDbEditor.UserInterface.Forms
{
    partial class MainForm
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
            this.ssMain = new System.Windows.Forms.StatusStrip();
            this.tsslVersion = new System.Windows.Forms.ToolStripStatusLabel();
            this.tsslUser = new System.Windows.Forms.ToolStripStatusLabel();
            this.tcMain = new System.Windows.Forms.TabControl();
            this.tpFunctions = new System.Windows.Forms.TabPage();
            this.btnUnlockProductions = new System.Windows.Forms.Button();
            this.splitter5 = new System.Windows.Forms.Splitter();
            this.btnPrintersAdding = new System.Windows.Forms.Button();
            this.splitter4 = new System.Windows.Forms.Splitter();
            this.btnOrdersAddressChange = new System.Windows.Forms.Button();
            this.splitter3 = new System.Windows.Forms.Splitter();
            this.btnKanbansRemove = new System.Windows.Forms.Button();
            this.splitter2 = new System.Windows.Forms.Splitter();
            this.btnStatusChange = new System.Windows.Forms.Button();
            this.splitter1 = new System.Windows.Forms.Splitter();
            this.btnOrdersCorrection = new System.Windows.Forms.Button();
            this.tpAddictional = new System.Windows.Forms.TabPage();
            this.btnRegister = new System.Windows.Forms.Button();
            this.splitter7 = new System.Windows.Forms.Splitter();
            this.btnLogs = new System.Windows.Forms.Button();
            this.pMain = new System.Windows.Forms.Panel();
            this.tcTabs = new System.Windows.Forms.TabControl();
            this.ssMain.SuspendLayout();
            this.tcMain.SuspendLayout();
            this.tpFunctions.SuspendLayout();
            this.tpAddictional.SuspendLayout();
            this.pMain.SuspendLayout();
            this.SuspendLayout();
            // 
            // ssMain
            // 
            this.ssMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsslVersion,
            this.tsslUser});
            this.ssMain.Location = new System.Drawing.Point(0, 539);
            this.ssMain.Name = "ssMain";
            this.ssMain.Size = new System.Drawing.Size(984, 22);
            this.ssMain.TabIndex = 1;
            this.ssMain.Text = "statusStrip1";
            // 
            // tsslVersion
            // 
            this.tsslVersion.Name = "tsslVersion";
            this.tsslVersion.Size = new System.Drawing.Size(81, 17);
            this.tsslVersion.Text = "Wersja: 1.0.0.0";
            // 
            // tsslUser
            // 
            this.tsslUser.Image = global::SmayDbEditor.UserInterface.Properties.Resources.User_16;
            this.tsslUser.Name = "tsslUser";
            this.tsslUser.Size = new System.Drawing.Size(158, 17);
            this.tsslUser.Text = "Użytkownik: dbEditorUser";
            // 
            // tcMain
            // 
            this.tcMain.Controls.Add(this.tpFunctions);
            this.tcMain.Controls.Add(this.tpAddictional);
            this.tcMain.Dock = System.Windows.Forms.DockStyle.Left;
            this.tcMain.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.tcMain.Location = new System.Drawing.Point(0, 0);
            this.tcMain.Name = "tcMain";
            this.tcMain.SelectedIndex = 0;
            this.tcMain.Size = new System.Drawing.Size(139, 539);
            this.tcMain.TabIndex = 2;
            // 
            // tpFunctions
            // 
            this.tpFunctions.Controls.Add(this.btnUnlockProductions);
            this.tpFunctions.Controls.Add(this.splitter5);
            this.tpFunctions.Controls.Add(this.btnPrintersAdding);
            this.tpFunctions.Controls.Add(this.splitter4);
            this.tpFunctions.Controls.Add(this.btnOrdersAddressChange);
            this.tpFunctions.Controls.Add(this.splitter3);
            this.tpFunctions.Controls.Add(this.btnKanbansRemove);
            this.tpFunctions.Controls.Add(this.splitter2);
            this.tpFunctions.Controls.Add(this.btnStatusChange);
            this.tpFunctions.Controls.Add(this.splitter1);
            this.tpFunctions.Controls.Add(this.btnOrdersCorrection);
            this.tpFunctions.Location = new System.Drawing.Point(4, 24);
            this.tpFunctions.Name = "tpFunctions";
            this.tpFunctions.Padding = new System.Windows.Forms.Padding(3);
            this.tpFunctions.Size = new System.Drawing.Size(131, 511);
            this.tpFunctions.TabIndex = 0;
            this.tpFunctions.Text = "Funkcje";
            this.tpFunctions.UseVisualStyleBackColor = true;
            // 
            // btnUnlockProductions
            // 
            this.btnUnlockProductions.BackColor = System.Drawing.Color.White;
            this.btnUnlockProductions.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnUnlockProductions.Location = new System.Drawing.Point(3, 306);
            this.btnUnlockProductions.Name = "btnUnlockProductions";
            this.btnUnlockProductions.Size = new System.Drawing.Size(125, 59);
            this.btnUnlockProductions.TabIndex = 10;
            this.btnUnlockProductions.Text = "Odblokowanie produkcji";
            this.btnUnlockProductions.UseVisualStyleBackColor = false;
            this.btnUnlockProductions.Click += new System.EventHandler(this.btnUnlockProductions_Click);
            // 
            // splitter5
            // 
            this.splitter5.Dock = System.Windows.Forms.DockStyle.Top;
            this.splitter5.Location = new System.Drawing.Point(3, 301);
            this.splitter5.Name = "splitter5";
            this.splitter5.Size = new System.Drawing.Size(125, 5);
            this.splitter5.TabIndex = 9;
            this.splitter5.TabStop = false;
            // 
            // btnPrintersAdding
            // 
            this.btnPrintersAdding.BackColor = System.Drawing.Color.White;
            this.btnPrintersAdding.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnPrintersAdding.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnPrintersAdding.Location = new System.Drawing.Point(3, 250);
            this.btnPrintersAdding.Name = "btnPrintersAdding";
            this.btnPrintersAdding.Size = new System.Drawing.Size(125, 51);
            this.btnPrintersAdding.TabIndex = 8;
            this.btnPrintersAdding.Text = "Serwer wydruku";
            this.btnPrintersAdding.UseVisualStyleBackColor = false;
            this.btnPrintersAdding.Click += new System.EventHandler(this.btnPrintersAdding_Click);
            // 
            // splitter4
            // 
            this.splitter4.Dock = System.Windows.Forms.DockStyle.Top;
            this.splitter4.Location = new System.Drawing.Point(3, 245);
            this.splitter4.Name = "splitter4";
            this.splitter4.Size = new System.Drawing.Size(125, 5);
            this.splitter4.TabIndex = 7;
            this.splitter4.TabStop = false;
            // 
            // btnOrdersAddressChange
            // 
            this.btnOrdersAddressChange.BackColor = System.Drawing.Color.White;
            this.btnOrdersAddressChange.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnOrdersAddressChange.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnOrdersAddressChange.Location = new System.Drawing.Point(3, 188);
            this.btnOrdersAddressChange.Name = "btnOrdersAddressChange";
            this.btnOrdersAddressChange.Size = new System.Drawing.Size(125, 57);
            this.btnOrdersAddressChange.TabIndex = 6;
            this.btnOrdersAddressChange.Text = "Zmiana adresu zamówienia";
            this.btnOrdersAddressChange.UseVisualStyleBackColor = false;
            this.btnOrdersAddressChange.Click += new System.EventHandler(this.btnOrdersAddressChange_Click);
            // 
            // splitter3
            // 
            this.splitter3.Dock = System.Windows.Forms.DockStyle.Top;
            this.splitter3.Location = new System.Drawing.Point(3, 183);
            this.splitter3.Name = "splitter3";
            this.splitter3.Size = new System.Drawing.Size(125, 5);
            this.splitter3.TabIndex = 5;
            this.splitter3.TabStop = false;
            // 
            // btnKanbansRemove
            // 
            this.btnKanbansRemove.BackColor = System.Drawing.Color.White;
            this.btnKanbansRemove.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnKanbansRemove.Location = new System.Drawing.Point(3, 125);
            this.btnKanbansRemove.Name = "btnKanbansRemove";
            this.btnKanbansRemove.Size = new System.Drawing.Size(125, 58);
            this.btnKanbansRemove.TabIndex = 4;
            this.btnKanbansRemove.Text = "Usuwanie kanbanów";
            this.btnKanbansRemove.UseVisualStyleBackColor = false;
            this.btnKanbansRemove.Click += new System.EventHandler(this.btnKanbansRemove_Click);
            // 
            // splitter2
            // 
            this.splitter2.Dock = System.Windows.Forms.DockStyle.Top;
            this.splitter2.Location = new System.Drawing.Point(3, 120);
            this.splitter2.Name = "splitter2";
            this.splitter2.Size = new System.Drawing.Size(125, 5);
            this.splitter2.TabIndex = 3;
            this.splitter2.TabStop = false;
            // 
            // btnStatusChange
            // 
            this.btnStatusChange.BackColor = System.Drawing.Color.White;
            this.btnStatusChange.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnStatusChange.Location = new System.Drawing.Point(3, 66);
            this.btnStatusChange.Name = "btnStatusChange";
            this.btnStatusChange.Size = new System.Drawing.Size(125, 54);
            this.btnStatusChange.TabIndex = 2;
            this.btnStatusChange.Text = "Zmiana statusu";
            this.btnStatusChange.UseVisualStyleBackColor = false;
            this.btnStatusChange.Click += new System.EventHandler(this.btnStatusChanges_Click);
            // 
            // splitter1
            // 
            this.splitter1.Dock = System.Windows.Forms.DockStyle.Top;
            this.splitter1.Location = new System.Drawing.Point(3, 61);
            this.splitter1.Name = "splitter1";
            this.splitter1.Size = new System.Drawing.Size(125, 5);
            this.splitter1.TabIndex = 1;
            this.splitter1.TabStop = false;
            // 
            // btnOrdersCorrection
            // 
            this.btnOrdersCorrection.BackColor = System.Drawing.Color.White;
            this.btnOrdersCorrection.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnOrdersCorrection.Location = new System.Drawing.Point(3, 3);
            this.btnOrdersCorrection.Name = "btnOrdersCorrection";
            this.btnOrdersCorrection.Size = new System.Drawing.Size(125, 58);
            this.btnOrdersCorrection.TabIndex = 0;
            this.btnOrdersCorrection.Text = "Korekta zamówienia";
            this.btnOrdersCorrection.UseVisualStyleBackColor = false;
            this.btnOrdersCorrection.Click += new System.EventHandler(this.btnOrdersCorrection_Click);
            // 
            // tpAddictional
            // 
            this.tpAddictional.Controls.Add(this.btnRegister);
            this.tpAddictional.Controls.Add(this.splitter7);
            this.tpAddictional.Controls.Add(this.btnLogs);
            this.tpAddictional.Location = new System.Drawing.Point(4, 24);
            this.tpAddictional.Name = "tpAddictional";
            this.tpAddictional.Padding = new System.Windows.Forms.Padding(3);
            this.tpAddictional.Size = new System.Drawing.Size(131, 511);
            this.tpAddictional.TabIndex = 1;
            this.tpAddictional.Text = "Dodatkowe";
            this.tpAddictional.UseVisualStyleBackColor = true;
            // 
            // btnRegister
            // 
            this.btnRegister.BackColor = System.Drawing.Color.White;
            this.btnRegister.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnRegister.Location = new System.Drawing.Point(3, 79);
            this.btnRegister.Name = "btnRegister";
            this.btnRegister.Size = new System.Drawing.Size(125, 66);
            this.btnRegister.TabIndex = 4;
            this.btnRegister.Text = "Dodaj użytkownika";
            this.btnRegister.UseVisualStyleBackColor = false;
            this.btnRegister.Click += new System.EventHandler(this.btnRegister_Click);
            // 
            // splitter7
            // 
            this.splitter7.BackColor = System.Drawing.Color.White;
            this.splitter7.Dock = System.Windows.Forms.DockStyle.Top;
            this.splitter7.Location = new System.Drawing.Point(3, 69);
            this.splitter7.Name = "splitter7";
            this.splitter7.Size = new System.Drawing.Size(125, 10);
            this.splitter7.TabIndex = 3;
            this.splitter7.TabStop = false;
            // 
            // btnLogs
            // 
            this.btnLogs.BackColor = System.Drawing.Color.White;
            this.btnLogs.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnLogs.Location = new System.Drawing.Point(3, 3);
            this.btnLogs.Name = "btnLogs";
            this.btnLogs.Size = new System.Drawing.Size(125, 66);
            this.btnLogs.TabIndex = 2;
            this.btnLogs.Text = "Logi";
            this.btnLogs.UseVisualStyleBackColor = false;
            this.btnLogs.Click += new System.EventHandler(this.btnLogs_Click);
            // 
            // pMain
            // 
            this.pMain.BackColor = System.Drawing.Color.White;
            this.pMain.Controls.Add(this.tcTabs);
            this.pMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pMain.Location = new System.Drawing.Point(139, 0);
            this.pMain.Name = "pMain";
            this.pMain.Size = new System.Drawing.Size(845, 539);
            this.pMain.TabIndex = 3;
            // 
            // tcTabs
            // 
            this.tcTabs.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tcTabs.DrawMode = System.Windows.Forms.TabDrawMode.OwnerDrawFixed;
            this.tcTabs.ItemSize = new System.Drawing.Size(150, 18);
            this.tcTabs.Location = new System.Drawing.Point(0, 0);
            this.tcTabs.Name = "tcTabs";
            this.tcTabs.SelectedIndex = 0;
            this.tcTabs.Size = new System.Drawing.Size(845, 539);
            this.tcTabs.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
            this.tcTabs.TabIndex = 0;
            this.tcTabs.DrawItem += new System.Windows.Forms.DrawItemEventHandler(this.tcTabs_DrawItem);
            this.tcTabs.MouseDown += new System.Windows.Forms.MouseEventHandler(this.tcTabs_MouseDown);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(984, 561);
            this.Controls.Add(this.pMain);
            this.Controls.Add(this.tcMain);
            this.Controls.Add(this.ssMain);
            this.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Name = "MainForm";
            this.Text = "Smay DB Editor";
            this.ssMain.ResumeLayout(false);
            this.ssMain.PerformLayout();
            this.tcMain.ResumeLayout(false);
            this.tpFunctions.ResumeLayout(false);
            this.tpAddictional.ResumeLayout(false);
            this.pMain.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.StatusStrip ssMain;
        private System.Windows.Forms.TabControl tcMain;
        private System.Windows.Forms.TabPage tpFunctions;
        private System.Windows.Forms.TabPage tpAddictional;
        private System.Windows.Forms.Button btnOrdersCorrection;
        private System.Windows.Forms.Panel pMain;
        private System.Windows.Forms.Button btnStatusChange;
        private System.Windows.Forms.Splitter splitter1;
        private System.Windows.Forms.Splitter splitter2;
        private System.Windows.Forms.Button btnOrdersAddressChange;
        private System.Windows.Forms.Splitter splitter3;
        private System.Windows.Forms.Button btnKanbansRemove;
        private System.Windows.Forms.Splitter splitter4;
        private System.Windows.Forms.ToolStripStatusLabel tsslVersion;
        private System.Windows.Forms.ToolStripStatusLabel tsslUser;
        private System.Windows.Forms.TabControl tcTabs;
        private System.Windows.Forms.Button btnPrintersAdding;
        private System.Windows.Forms.Button btnUnlockProductions;
        private System.Windows.Forms.Splitter splitter5;
        private System.Windows.Forms.Button btnRegister;
        private System.Windows.Forms.Splitter splitter7;
        private System.Windows.Forms.Button btnLogs;
    }
}