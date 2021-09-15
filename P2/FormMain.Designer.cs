
namespace P2
{
    partial class FormMain
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.radioButtonCrappie = new System.Windows.Forms.RadioButton();
            this.radioButtonPerch = new System.Windows.Forms.RadioButton();
            this.radioButtonWalleye = new System.Windows.Forms.RadioButton();
            this.buttonSeeFish = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.radioButtonWalleye);
            this.groupBox1.Controls.Add(this.radioButtonPerch);
            this.groupBox1.Controls.Add(this.radioButtonCrappie);
            this.groupBox1.Location = new System.Drawing.Point(64, 38);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(220, 193);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Choose a fish to see";
            // 
            // radioButtonCrappie
            // 
            this.radioButtonCrappie.AutoSize = true;
            this.radioButtonCrappie.Location = new System.Drawing.Point(29, 36);
            this.radioButtonCrappie.Name = "radioButtonCrappie";
            this.radioButtonCrappie.Size = new System.Drawing.Size(61, 17);
            this.radioButtonCrappie.TabIndex = 0;
            this.radioButtonCrappie.TabStop = true;
            this.radioButtonCrappie.Text = "Crappie";
            this.radioButtonCrappie.UseVisualStyleBackColor = true;
            // 
            // radioButtonPerch
            // 
            this.radioButtonPerch.AutoSize = true;
            this.radioButtonPerch.Location = new System.Drawing.Point(29, 86);
            this.radioButtonPerch.Name = "radioButtonPerch";
            this.radioButtonPerch.Size = new System.Drawing.Size(53, 17);
            this.radioButtonPerch.TabIndex = 1;
            this.radioButtonPerch.TabStop = true;
            this.radioButtonPerch.Text = "Perch";
            this.radioButtonPerch.UseVisualStyleBackColor = true;
            // 
            // radioButtonWalleye
            // 
            this.radioButtonWalleye.AutoSize = true;
            this.radioButtonWalleye.Location = new System.Drawing.Point(29, 140);
            this.radioButtonWalleye.Name = "radioButtonWalleye";
            this.radioButtonWalleye.Size = new System.Drawing.Size(63, 17);
            this.radioButtonWalleye.TabIndex = 2;
            this.radioButtonWalleye.TabStop = true;
            this.radioButtonWalleye.Text = "Walleye";
            this.radioButtonWalleye.UseVisualStyleBackColor = true;
            // 
            // buttonSeeFish
            // 
            this.buttonSeeFish.Location = new System.Drawing.Point(188, 244);
            this.buttonSeeFish.Name = "buttonSeeFish";
            this.buttonSeeFish.Size = new System.Drawing.Size(131, 46);
            this.buttonSeeFish.TabIndex = 1;
            this.buttonSeeFish.Text = "See Fish";
            this.buttonSeeFish.UseVisualStyleBackColor = true;
            this.buttonSeeFish.Click += new System.EventHandler(this.buttonSeeFish_Click);
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(343, 310);
            this.Controls.Add(this.buttonSeeFish);
            this.Controls.Add(this.groupBox1);
            this.Name = "FormMain";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.FormMain_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton radioButtonWalleye;
        private System.Windows.Forms.RadioButton radioButtonPerch;
        private System.Windows.Forms.RadioButton radioButtonCrappie;
        private System.Windows.Forms.Button buttonSeeFish;
    }
}

