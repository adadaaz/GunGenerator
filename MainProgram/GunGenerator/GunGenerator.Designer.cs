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
<<<<<<< HEAD
            this.btnCreate = new System.Windows.Forms.Button();
=======
            this.lblManufacturer = new System.Windows.Forms.Label();
            this.lblWeapon = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.btnCreate = new System.Windows.Forms.Button();
            this.picBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.picBox1)).BeginInit();
>>>>>>> master
            this.SuspendLayout();
            // 
            // btnGenerate
            // 
<<<<<<< HEAD
            this.btnGenerate.Location = new System.Drawing.Point(44, 340);
=======
            this.btnGenerate.Location = new System.Drawing.Point(34, 363);
>>>>>>> master
            this.btnGenerate.Name = "btnGenerate";
            this.btnGenerate.Size = new System.Drawing.Size(207, 23);
            this.btnGenerate.TabIndex = 0;
            this.btnGenerate.Text = "Generate";
            this.btnGenerate.UseVisualStyleBackColor = true;
            this.btnGenerate.Click += new System.EventHandler(this.btnGenerate_Click);
            // 
            // btnExport
            // 
<<<<<<< HEAD
            this.btnExport.Location = new System.Drawing.Point(112, 378);
=======
            this.btnExport.Location = new System.Drawing.Point(100, 401);
>>>>>>> master
            this.btnExport.Name = "btnExport";
            this.btnExport.Size = new System.Drawing.Size(75, 23);
            this.btnExport.TabIndex = 1;
            this.btnExport.Text = "Export";
            this.btnExport.UseVisualStyleBackColor = true;
            this.btnExport.Click += new System.EventHandler(this.btnExport_Click);
            // 
            // cmboxGunType
            // 
            this.cmboxGunType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmboxGunType.FormattingEnabled = true;
<<<<<<< HEAD
            this.cmboxGunType.Location = new System.Drawing.Point(46, 116);
=======
            this.cmboxGunType.Location = new System.Drawing.Point(34, 138);
>>>>>>> master
            this.cmboxGunType.Name = "cmboxGunType";
            this.cmboxGunType.Size = new System.Drawing.Size(207, 21);
            this.cmboxGunType.TabIndex = 2;
            this.cmboxGunType.SelectedIndexChanged += new System.EventHandler(this.cmboxGunType_SelectedIndexChanged);
            // 
            // txtGunName
            // 
<<<<<<< HEAD
            this.txtGunName.Location = new System.Drawing.Point(46, 25);
=======
            this.txtGunName.Location = new System.Drawing.Point(34, 41);
>>>>>>> master
            this.txtGunName.Name = "txtGunName";
            this.txtGunName.Size = new System.Drawing.Size(207, 20);
            this.txtGunName.TabIndex = 3;
            // 
            // lblDamage
            // 
            this.lblDamage.AutoSize = true;
<<<<<<< HEAD
            this.lblDamage.Location = new System.Drawing.Point(43, 159);
=======
            this.lblDamage.Location = new System.Drawing.Point(32, 182);
>>>>>>> master
            this.lblDamage.Name = "lblDamage";
            this.lblDamage.Size = new System.Drawing.Size(47, 13);
            this.lblDamage.TabIndex = 4;
            this.lblDamage.Text = "Damage";
            // 
            // lblAccuracy
            // 
            this.lblAccuracy.AutoSize = true;
<<<<<<< HEAD
            this.lblAccuracy.Location = new System.Drawing.Point(43, 185);
=======
            this.lblAccuracy.Location = new System.Drawing.Point(32, 208);
>>>>>>> master
            this.lblAccuracy.Name = "lblAccuracy";
            this.lblAccuracy.Size = new System.Drawing.Size(52, 13);
            this.lblAccuracy.TabIndex = 5;
            this.lblAccuracy.Text = "Accuracy";
            // 
            // lblFireRate
            // 
            this.lblFireRate.AutoSize = true;
<<<<<<< HEAD
            this.lblFireRate.Location = new System.Drawing.Point(43, 211);
=======
            this.lblFireRate.Location = new System.Drawing.Point(32, 234);
>>>>>>> master
            this.lblFireRate.Name = "lblFireRate";
            this.lblFireRate.Size = new System.Drawing.Size(50, 13);
            this.lblFireRate.TabIndex = 6;
            this.lblFireRate.Text = "Fire Rate";
            // 
            // lblReloadSpeed
            // 
            this.lblReloadSpeed.AutoSize = true;
<<<<<<< HEAD
            this.lblReloadSpeed.Location = new System.Drawing.Point(42, 237);
=======
            this.lblReloadSpeed.Location = new System.Drawing.Point(32, 260);
>>>>>>> master
            this.lblReloadSpeed.Name = "lblReloadSpeed";
            this.lblReloadSpeed.Size = new System.Drawing.Size(75, 13);
            this.lblReloadSpeed.TabIndex = 7;
            this.lblReloadSpeed.Text = "Reload Speed";
            // 
            // lblMagazine
            // 
            this.lblMagazine.AutoSize = true;
<<<<<<< HEAD
            this.lblMagazine.Location = new System.Drawing.Point(43, 263);
=======
            this.lblMagazine.Location = new System.Drawing.Point(32, 286);
>>>>>>> master
            this.lblMagazine.Name = "lblMagazine";
            this.lblMagazine.Size = new System.Drawing.Size(76, 13);
            this.lblMagazine.TabIndex = 8;
            this.lblMagazine.Text = "Magazine Size";
            // 
            // txtDamage
            // 
<<<<<<< HEAD
            this.txtDamage.Location = new System.Drawing.Point(162, 152);
=======
            this.txtDamage.Location = new System.Drawing.Point(150, 175);
>>>>>>> master
            this.txtDamage.Name = "txtDamage";
            this.txtDamage.ReadOnly = true;
            this.txtDamage.Size = new System.Drawing.Size(91, 20);
            this.txtDamage.TabIndex = 9;
            // 
            // txtAccuracy
            // 
<<<<<<< HEAD
            this.txtAccuracy.Location = new System.Drawing.Point(162, 178);
=======
            this.txtAccuracy.Location = new System.Drawing.Point(150, 201);
>>>>>>> master
            this.txtAccuracy.Name = "txtAccuracy";
            this.txtAccuracy.ReadOnly = true;
            this.txtAccuracy.Size = new System.Drawing.Size(91, 20);
            this.txtAccuracy.TabIndex = 10;
            // 
            // txtFireRate
            // 
<<<<<<< HEAD
            this.txtFireRate.Location = new System.Drawing.Point(162, 204);
=======
            this.txtFireRate.Location = new System.Drawing.Point(150, 227);
>>>>>>> master
            this.txtFireRate.Name = "txtFireRate";
            this.txtFireRate.ReadOnly = true;
            this.txtFireRate.Size = new System.Drawing.Size(91, 20);
            this.txtFireRate.TabIndex = 11;
            // 
            // txtReload
            // 
<<<<<<< HEAD
            this.txtReload.Location = new System.Drawing.Point(162, 230);
=======
            this.txtReload.Location = new System.Drawing.Point(150, 253);
>>>>>>> master
            this.txtReload.Name = "txtReload";
            this.txtReload.ReadOnly = true;
            this.txtReload.Size = new System.Drawing.Size(91, 20);
            this.txtReload.TabIndex = 12;
            // 
            // txtMagazine
            // 
<<<<<<< HEAD
            this.txtMagazine.Location = new System.Drawing.Point(162, 256);
=======
            this.txtMagazine.Location = new System.Drawing.Point(150, 279);
>>>>>>> master
            this.txtMagazine.Name = "txtMagazine";
            this.txtMagazine.ReadOnly = true;
            this.txtMagazine.Size = new System.Drawing.Size(91, 20);
            this.txtMagazine.TabIndex = 13;
            // 
            // btnReroll
            // 
<<<<<<< HEAD
            this.btnReroll.Location = new System.Drawing.Point(162, 299);
=======
            this.btnReroll.Location = new System.Drawing.Point(150, 322);
>>>>>>> master
            this.btnReroll.Name = "btnReroll";
            this.btnReroll.Size = new System.Drawing.Size(91, 23);
            this.btnReroll.TabIndex = 14;
            this.btnReroll.Text = "Reroll";
            this.btnReroll.UseVisualStyleBackColor = true;
<<<<<<< HEAD
=======
            this.btnReroll.Click += new System.EventHandler(this.btnReroll_Click);
>>>>>>> master
            // 
            // cmboxManufacturer
            // 
            this.cmboxManufacturer.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmboxManufacturer.FormattingEnabled = true;
<<<<<<< HEAD
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
=======
            this.cmboxManufacturer.Location = new System.Drawing.Point(34, 91);
            this.cmboxManufacturer.Name = "cmboxManufacturer";
            this.cmboxManufacturer.Size = new System.Drawing.Size(207, 21);
            this.cmboxManufacturer.TabIndex = 15;
            this.cmboxManufacturer.SelectedIndexChanged += new System.EventHandler(this.comboxManufacturer_SelectedIndexChanged);
            // 
            // lblManufacturer
            // 
            this.lblManufacturer.AutoSize = true;
            this.lblManufacturer.Location = new System.Drawing.Point(32, 70);
            this.lblManufacturer.Name = "lblManufacturer";
            this.lblManufacturer.Size = new System.Drawing.Size(73, 13);
            this.lblManufacturer.TabIndex = 16;
            this.lblManufacturer.Text = "Manufacturer:";
            // 
            // lblWeapon
            // 
            this.lblWeapon.AutoSize = true;
            this.lblWeapon.Location = new System.Drawing.Point(32, 119);
            this.lblWeapon.Name = "lblWeapon";
            this.lblWeapon.Size = new System.Drawing.Size(51, 13);
            this.lblWeapon.TabIndex = 17;
            this.lblWeapon.Text = "Weapon:";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(32, 20);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(38, 13);
            this.lblName.TabIndex = 18;
            this.lblName.Text = "Name:";
            // 
            // btnCreate
            // 
            this.btnCreate.Location = new System.Drawing.Point(34, 322);
            this.btnCreate.Name = "btnCreate";
            this.btnCreate.Size = new System.Drawing.Size(91, 23);
            this.btnCreate.TabIndex = 19;
            this.btnCreate.Text = "Create";
            this.btnCreate.UseVisualStyleBackColor = true;
            this.btnCreate.Click += new System.EventHandler(this.btnCreate_Click);
            // 
            // picBox1
            // 
            this.picBox1.Location = new System.Drawing.Point(271, 41);
            this.picBox1.Name = "picBox1";
            this.picBox1.Size = new System.Drawing.Size(314, 243);
            this.picBox1.TabIndex = 20;
            this.picBox1.TabStop = false;
>>>>>>> master
            // 
            // frmGunGenerator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
<<<<<<< HEAD
            this.ClientSize = new System.Drawing.Size(680, 415);
            this.Controls.Add(this.btnCreate);
=======
            this.ClientSize = new System.Drawing.Size(626, 450);
            this.Controls.Add(this.picBox1);
            this.Controls.Add(this.btnCreate);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.lblWeapon);
            this.Controls.Add(this.lblManufacturer);
>>>>>>> master
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
            ((System.ComponentModel.ISupportInitialize)(this.picBox1)).EndInit();
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
<<<<<<< HEAD
        private System.Windows.Forms.ComboBox cmboxManufacturer;
        private System.Windows.Forms.Button btnCreate;
=======
        private System.Windows.Forms.Label lblManufacturer;
        private System.Windows.Forms.Label lblWeapon;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Button btnCreate;
        private System.Windows.Forms.PictureBox picBox1;
<<<<<<< HEAD
        private System.Windows.Forms.ComboBox cmboxManufacturer;
=======
>>>>>>> 19cc9c0f8750c221b5187168e7caf5ba180f30f6
>>>>>>> master
    }
}

