namespace rpg_damage_sim
{
    partial class mainForm
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
            this.startHp = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.hpGroup = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.baseDamage = new System.Windows.Forms.TextBox();
            this.startCombat = new System.Windows.Forms.Button();
            this.hpProgressBar = new System.Windows.Forms.ProgressBar();
            this.label3 = new System.Windows.Forms.Label();
            this.currentHpDisplay = new System.Windows.Forms.Label();
            this.resetCombat = new System.Windows.Forms.Button();
            this.hpGroup.SuspendLayout();
            this.SuspendLayout();
            // 
            // startHp
            // 
            this.startHp.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.startHp.Location = new System.Drawing.Point(106, 41);
            this.startHp.Name = "startHp";
            this.startHp.Size = new System.Drawing.Size(100, 20);
            this.startHp.TabIndex = 0;
            this.startHp.Text = "100";
            this.startHp.TextChanged += new System.EventHandler(this.startHp_TextChanged);
            this.startHp.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.startHp_KeyPress);
            this.startHp.Validating += new System.ComponentModel.CancelEventHandler(this.validate_Int);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(39, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Starting HP";
            // 
            // hpGroup
            // 
            this.hpGroup.Controls.Add(this.resetCombat);
            this.hpGroup.Controls.Add(this.label2);
            this.hpGroup.Controls.Add(this.baseDamage);
            this.hpGroup.Controls.Add(this.startCombat);
            this.hpGroup.Location = new System.Drawing.Point(13, 13);
            this.hpGroup.Name = "hpGroup";
            this.hpGroup.Size = new System.Drawing.Size(329, 87);
            this.hpGroup.TabIndex = 2;
            this.hpGroup.TabStop = false;
            this.hpGroup.Text = "HitPoints";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(40, 58);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Damage";
            // 
            // baseDamage
            // 
            this.baseDamage.Location = new System.Drawing.Point(93, 55);
            this.baseDamage.Name = "baseDamage";
            this.baseDamage.Size = new System.Drawing.Size(100, 20);
            this.baseDamage.TabIndex = 1;
            this.baseDamage.Text = "5";
            this.baseDamage.TextChanged += new System.EventHandler(this.baseDamage_TextChanged);
            this.baseDamage.Validating += new System.ComponentModel.CancelEventHandler(this.validate_Int);
            // 
            // startCombat
            // 
            this.startCombat.Location = new System.Drawing.Point(215, 26);
            this.startCombat.Name = "startCombat";
            this.startCombat.Size = new System.Drawing.Size(100, 23);
            this.startCombat.TabIndex = 0;
            this.startCombat.Text = "Start Combat";
            this.startCombat.UseVisualStyleBackColor = true;
            this.startCombat.Click += new System.EventHandler(this.startCombat_Click);
            // 
            // hpProgressBar
            // 
            this.hpProgressBar.Location = new System.Drawing.Point(56, 154);
            this.hpProgressBar.Name = "hpProgressBar";
            this.hpProgressBar.RightToLeftLayout = true;
            this.hpProgressBar.Size = new System.Drawing.Size(286, 23);
            this.hpProgressBar.Step = 1;
            this.hpProgressBar.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.hpProgressBar.TabIndex = 3;
            this.hpProgressBar.Value = 100;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(134, 138);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(89, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Current Hit Points";
            // 
            // currentHpDisplay
            // 
            this.currentHpDisplay.AutoSize = true;
            this.currentHpDisplay.Location = new System.Drawing.Point(159, 180);
            this.currentHpDisplay.Name = "currentHpDisplay";
            this.currentHpDisplay.Size = new System.Drawing.Size(22, 13);
            this.currentHpDisplay.TabIndex = 5;
            this.currentHpDisplay.Text = "NA";
            // 
            // resetCombat
            // 
            this.resetCombat.Location = new System.Drawing.Point(215, 58);
            this.resetCombat.Name = "resetCombat";
            this.resetCombat.Size = new System.Drawing.Size(100, 23);
            this.resetCombat.TabIndex = 3;
            this.resetCombat.Text = "Reset Combat";
            this.resetCombat.UseVisualStyleBackColor = true;
            this.resetCombat.Click += new System.EventHandler(this.resetCombat_Click);
            // 
            // mainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(392, 214);
            this.Controls.Add(this.currentHpDisplay);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.hpProgressBar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.startHp);
            this.Controls.Add(this.hpGroup);
            this.Name = "mainForm";
            this.Text = "Combat Simulator";
            this.hpGroup.ResumeLayout(false);
            this.hpGroup.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox hpGroup;
        private System.Windows.Forms.ProgressBar hpProgressBar;
        private System.Windows.Forms.Button startCombat;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox baseDamage;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label currentHpDisplay;
        private System.Windows.Forms.TextBox startHp;
        private System.Windows.Forms.Button resetCombat;
    }
}

