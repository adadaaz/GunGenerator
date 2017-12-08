namespace GunGenerator
{
    partial class frmGunGenerator
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
            this.btnGenerate = new System.Windows.Forms.Button();
            this.btnExport = new System.Windows.Forms.Button();
            this.cmboxGunType = new System.Windows.Forms.ComboBox();
            this.txtGunName = new System.Windows.Forms.TextBox();
            this.lblDamage = new System.Windows.Forms.Label();
            this.lblAccuracy = new System.Windows.Forms.Label();
            this.lblFireRate = new System.Windows.Forms.Label();
            this.lblReloadSpeed = new System.Windows.Forms.Label();
            this.lblMagazine = new System.Windows.Forms.Label();
            this.txtDamage = new System.Windows.Forms.TextBox();
            this.txtAccuracy = new System.Windows.Forms.TextBox();
            this.txtFireRate = new System.Windows.Forms.TextBox();
            this.txtReload = new System.Windows.Forms.TextBox();
            this.txtMagazine = new System.Windows.Forms.TextBox();
            this.btnReroll = new System.Windows.Forms.Button();
            this.cmboxManufacturer = new System.Windows.Forms.ComboBox();
            this.btnCreate = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnGenerate
            // 
            this.btnGenerate.Location = new System.Drawing.Point(44, 340);
            this.btnGenerate.Name = "btnGenerate";
            this.btnGenerate.Size = new System.Drawing.Size(209, 23);
            this.btnGenerate.TabIndex = 0;
            this.btnGenerate.Text = "Generate";
            this.btnGenerate.UseVisualStyleBackColor = true;
            // 
            // btnExport
            // 
            this.btnExport.Location = new System.Drawing.Point(112, 378);
            this.btnExport.Name = "btnExport";
            this.btnExport.Size = new System.Drawing.Size(75, 23);
            this.btnExport.TabIndex = 1;
            this.btnExport.Text = "Export";
            this.btnExport.UseVisualStyleBackColor = true;
            // 
            // cmboxGunType
            // 
            this.cmboxGunType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmboxGunType.FormattingEnabled = true;
            this.cmboxGunType.Location = new System.Drawing.Point(46, 116);
            this.cmboxGunType.Name = "cmboxGunType";
            this.cmboxGunType.Size = new System.Drawing.Size(209, 21);
            this.cmboxGunType.TabIndex = 2;
            // 
            // txtGunName
            // 
            this.txtGunName.Location = new System.Drawing.Point(46, 25);
            this.txtGunName.Name = "txtGunName";
            this.txtGunName.Size = new System.Drawing.Size(209, 20);
            this.txtGunName.TabIndex = 3;
            // 
            // lblDamage
            // 
            this.lblDamage.AutoSize = true;
            this.lblDamage.Location = new System.Drawing.Point(43, 159);
            this.lblDamage.Name = "lblDamage";
            this.lblDamage.Size = new System.Drawing.Size(47, 13);
            this.lblDamage.TabIndex = 4;
            this.lblDamage.Text = "Damage";
            // 
            // lblAccuracy
            // 
            this.lblAccuracy.AutoSize = true;
            this.lblAccuracy.Location = new System.Drawing.Point(43, 185);
            this.lblAccuracy.Name = "lblAccuracy";
            this.lblAccuracy.Size = new System.Drawing.Size(52, 13);
            this.lblAccuracy.TabIndex = 5;
            this.lblAccuracy.Text = "Accuracy";
            // 
            // lblFireRate
            // 
            this.lblFireRate.AutoSize = true;
            this.lblFireRate.Location = new System.Drawing.Point(43, 211);
            this.lblFireRate.Name = "lblFireRate";
            this.lblFireRate.Size = new System.Drawing.Size(50, 13);
            this.lblFireRate.TabIndex = 6;
            this.lblFireRate.Text = "Fire Rate";
            // 
            // lblReloadSpeed
            // 
            this.lblReloadSpeed.AutoSize = true;
            this.lblReloadSpeed.Location = new System.Drawing.Point(42, 237);
            this.lblReloadSpeed.Name = "lblReloadSpeed";
            this.lblReloadSpeed.Size = new System.Drawing.Size(75, 13);
            this.lblReloadSpeed.TabIndex = 7;
            this.lblReloadSpeed.Text = "Reload Speed";
            // 
            // lblMagazine
            // 
            this.lblMagazine.AutoSize = true;
            this.lblMagazine.Location = new System.Drawing.Point(43, 263);
            this.lblMagazine.Name = "lblMagazine";
            this.lblMagazine.Size = new System.Drawing.Size(76, 13);
            this.lblMagazine.TabIndex = 8;
            this.lblMagazine.Text = "Magazine Size";
            // 
            // txtDamage
            // 
            this.txtDamage.Location = new System.Drawing.Point(162, 152);
            this.txtDamage.Name = "txtDamage";
            this.txtDamage.ReadOnly = true;
            this.txtDamage.Size = new System.Drawing.Size(91, 20);
            this.txtDamage.TabIndex = 9;
            // 
            // txtAccuracy
            // 
            this.txtAccuracy.Location = new System.Drawing.Point(162, 178);
            this.txtAccuracy.Name = "txtAccuracy";
            this.txtAccuracy.ReadOnly = true;
            this.txtAccuracy.Size = new System.Drawing.Size(91, 20);
            this.txtAccuracy.TabIndex = 10;
            // 
            // txtFireRate
            // 
            this.txtFireRate.Location = new System.Drawing.Point(162, 204);
            this.txtFireRate.Name = "txtFireRate";
            this.txtFireRate.ReadOnly = true;
            this.txtFireRate.Size = new System.Drawing.Size(91, 20);
            this.txtFireRate.TabIndex = 11;
            // 
            // txtReload
            // 
            this.txtReload.Location = new System.Drawing.Point(162, 230);
            this.txtReload.Name = "txtReload";
            this.txtReload.ReadOnly = true;
            this.txtReload.Size = new System.Drawing.Size(91, 20);
            this.txtReload.TabIndex = 12;
            // 
            // txtMagazine
            // 
            this.txtMagazine.Location = new System.Drawing.Point(162, 256);
            this.txtMagazine.Name = "txtMagazine";
            this.txtMagazine.ReadOnly = true;
            this.txtMagazine.Size = new System.Drawing.Size(91, 20);
            this.txtMagazine.TabIndex = 13;
            // 
            // btnReroll
            // 
            this.btnReroll.Location = new System.Drawing.Point(162, 299);
            this.btnReroll.Name = "btnReroll";
            this.btnReroll.Size = new System.Drawing.Size(91, 23);
            this.btnReroll.TabIndex = 14;
            this.btnReroll.Text = "Reroll";
            this.btnReroll.UseVisualStyleBackColor = true;
            // 
            // cmboxManufacturer
            // 
            this.cmboxManufacturer.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmboxManufacturer.FormattingEnabled = true;
            this.cmboxManufacturer.Items.AddRange(new object[] {
            "a",
            "b",
            "c",
            "d"});
            this.cmboxManufacturer.Location = new System.Drawing.Point(46, 69);
            this.cmboxManufacturer.Name = "cmboxManufacturer";
            this.cmboxManufacturer.Size = new System.Drawing.Size(209, 21);
            this.cmboxManufacturer.TabIndex = 15;
            this.cmboxManufacturer.SelectedIndexChanged += new System.EventHandler(this.cmboxManufacturer_SelectedIndexChanged);
            // 
            // btnCreate
            // 
            this.btnCreate.Location = new System.Drawing.Point(46, 299);
            this.btnCreate.Name = "btnCreate";
            this.btnCreate.Size = new System.Drawing.Size(91, 23);
            this.btnCreate.TabIndex = 16;
            this.btnCreate.Text = "Create";
            this.btnCreate.UseVisualStyleBackColor = true;
            // 
            // frmGunGenerator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(680, 415);
            this.Controls.Add(this.btnCreate);
            this.Controls.Add(this.cmboxManufacturer);
            this.Controls.Add(this.btnReroll);
            this.Controls.Add(this.txtMagazine);
            this.Controls.Add(this.txtReload);
            this.Controls.Add(this.txtFireRate);
            this.Controls.Add(this.txtAccuracy);
            this.Controls.Add(this.txtDamage);
            this.Controls.Add(this.lblMagazine);
            this.Controls.Add(this.lblReloadSpeed);
            this.Controls.Add(this.lblFireRate);
            this.Controls.Add(this.lblAccuracy);
            this.Controls.Add(this.lblDamage);
            this.Controls.Add(this.txtGunName);
            this.Controls.Add(this.cmboxGunType);
            this.Controls.Add(this.btnExport);
            this.Controls.Add(this.btnGenerate);
            this.Name = "frmGunGenerator";
            this.Text = "Gun Generator";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnGenerate;
        private System.Windows.Forms.Button btnExport;
        private System.Windows.Forms.ComboBox cmboxGunType;
        private System.Windows.Forms.TextBox txtGunName;
        private System.Windows.Forms.Label lblDamage;
        private System.Windows.Forms.Label lblAccuracy;
        private System.Windows.Forms.Label lblFireRate;
        private System.Windows.Forms.Label lblReloadSpeed;
        private System.Windows.Forms.Label lblMagazine;
        private System.Windows.Forms.TextBox txtDamage;
        private System.Windows.Forms.TextBox txtAccuracy;
        private System.Windows.Forms.TextBox txtFireRate;
        private System.Windows.Forms.TextBox txtReload;
        private System.Windows.Forms.TextBox txtMagazine;
        private System.Windows.Forms.Button btnReroll;
        private System.Windows.Forms.ComboBox cmboxManufacturer;
        private System.Windows.Forms.Button btnCreate;
    }
}

