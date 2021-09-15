
namespace P2
{
    partial class FormSeeFish
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
            this.pictureBoxFish = new System.Windows.Forms.PictureBox();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.buttonThrowItBack = new System.Windows.Forms.Button();
            this.buttonKeepIt = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxFish)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBoxFish
            // 
            this.pictureBoxFish.Location = new System.Drawing.Point(45, 12);
            this.pictureBoxFish.Name = "pictureBoxFish";
            this.pictureBoxFish.Size = new System.Drawing.Size(800, 600);
            this.pictureBoxFish.TabIndex = 0;
            this.pictureBoxFish.TabStop = false;
            // 
            // buttonCancel
            // 
            this.buttonCancel.Location = new System.Drawing.Point(80, 630);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(174, 34);
            this.buttonCancel.TabIndex = 1;
            this.buttonCancel.Text = "Cancel";
            this.buttonCancel.UseVisualStyleBackColor = true;
            this.buttonCancel.Click += new System.EventHandler(this.buttonCancel_Click);
            // 
            // buttonThrowItBack
            // 
            this.buttonThrowItBack.Location = new System.Drawing.Point(351, 630);
            this.buttonThrowItBack.Name = "buttonThrowItBack";
            this.buttonThrowItBack.Size = new System.Drawing.Size(174, 34);
            this.buttonThrowItBack.TabIndex = 2;
            this.buttonThrowItBack.Text = "Throw It Back";
            this.buttonThrowItBack.UseVisualStyleBackColor = true;
            this.buttonThrowItBack.Click += new System.EventHandler(this.buttonThrowItBack_Click);
            // 
            // buttonKeepIt
            // 
            this.buttonKeepIt.Location = new System.Drawing.Point(627, 630);
            this.buttonKeepIt.Name = "buttonKeepIt";
            this.buttonKeepIt.Size = new System.Drawing.Size(174, 34);
            this.buttonKeepIt.TabIndex = 3;
            this.buttonKeepIt.Text = "Keep It";
            this.buttonKeepIt.UseVisualStyleBackColor = true;
            this.buttonKeepIt.Click += new System.EventHandler(this.buttonKeepIt_Click);
            // 
            // FormSeeFish
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(884, 675);
            this.Controls.Add(this.buttonKeepIt);
            this.Controls.Add(this.buttonThrowItBack);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.pictureBoxFish);
            this.Name = "FormSeeFish";
            this.Text = "Keep it or let it go";
            this.Load += new System.EventHandler(this.FormSeeFish_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxFish)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBoxFish;
        private System.Windows.Forms.Button buttonCancel;
        private System.Windows.Forms.Button buttonThrowItBack;
        private System.Windows.Forms.Button buttonKeepIt;
    }
}