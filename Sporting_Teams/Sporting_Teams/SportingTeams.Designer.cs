namespace Sporting_Teams
{
    partial class SportingTeamsForm
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
            this.rbSoccer = new System.Windows.Forms.RadioButton();
            this.rbFootball = new System.Windows.Forms.RadioButton();
            this.gBxSport = new System.Windows.Forms.GroupBox();
            this.txtBxInfo = new System.Windows.Forms.RichTextBox();
            this.txtBxBudgetInfo = new System.Windows.Forms.RichTextBox();
            this.lblPhoto = new System.Windows.Forms.Label();
            this.lblSportTitle = new System.Windows.Forms.Label();
            this.gBxSport.SuspendLayout();
            this.SuspendLayout();
            // 
            // rbSoccer
            // 
            this.rbSoccer.AutoSize = true;
            this.rbSoccer.Location = new System.Drawing.Point(68, 21);
            this.rbSoccer.Name = "rbSoccer";
            this.rbSoccer.Size = new System.Drawing.Size(95, 29);
            this.rbSoccer.TabIndex = 4;
            this.rbSoccer.TabStop = true;
            this.rbSoccer.Text = "Soccer";
            this.rbSoccer.UseVisualStyleBackColor = true;
            this.rbSoccer.CheckedChanged += new System.EventHandler(this.rbSoccer_CheckedChanged);
            // 
            // rbFootball
            // 
            this.rbFootball.AutoSize = true;
            this.rbFootball.Location = new System.Drawing.Point(68, 56);
            this.rbFootball.Name = "rbFootball";
            this.rbFootball.Size = new System.Drawing.Size(102, 29);
            this.rbFootball.TabIndex = 5;
            this.rbFootball.TabStop = true;
            this.rbFootball.Text = "Football";
            this.rbFootball.UseVisualStyleBackColor = true;
            this.rbFootball.CheckedChanged += new System.EventHandler(this.rbFootball_CheckedChanged);
            // 
            // gBxSport
            // 
            this.gBxSport.Controls.Add(this.rbSoccer);
            this.gBxSport.Controls.Add(this.rbFootball);
            this.gBxSport.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gBxSport.Location = new System.Drawing.Point(110, 116);
            this.gBxSport.Name = "gBxSport";
            this.gBxSport.Size = new System.Drawing.Size(239, 100);
            this.gBxSport.TabIndex = 6;
            this.gBxSport.TabStop = false;
            this.gBxSport.Text = "Sport";
            // 
            // txtBxInfo
            // 
            this.txtBxInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBxInfo.Location = new System.Drawing.Point(397, 51);
            this.txtBxInfo.Name = "txtBxInfo";
            this.txtBxInfo.Size = new System.Drawing.Size(341, 355);
            this.txtBxInfo.TabIndex = 20;
            this.txtBxInfo.Text = "";
            // 
            // txtBxBudgetInfo
            // 
            this.txtBxBudgetInfo.Location = new System.Drawing.Point(110, 222);
            this.txtBxBudgetInfo.Name = "txtBxBudgetInfo";
            this.txtBxBudgetInfo.Size = new System.Drawing.Size(239, 184);
            this.txtBxBudgetInfo.TabIndex = 22;
            this.txtBxBudgetInfo.Text = "";
            // 
            // lblPhoto
            // 
            this.lblPhoto.AutoSize = true;
            this.lblPhoto.BackColor = System.Drawing.Color.DarkOliveGreen;
            this.lblPhoto.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblPhoto.Location = new System.Drawing.Point(611, 425);
            this.lblPhoto.Name = "lblPhoto";
            this.lblPhoto.Size = new System.Drawing.Size(147, 16);
            this.lblPhoto.TabIndex = 23;
            this.lblPhoto.Text = "Photo by Sandro Schuh";
            // 
            // lblSportTitle
            // 
            this.lblSportTitle.AutoSize = true;
            this.lblSportTitle.BackColor = System.Drawing.Color.OliveDrab;
            this.lblSportTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSportTitle.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblSportTitle.Location = new System.Drawing.Point(3, 51);
            this.lblSportTitle.Name = "lblSportTitle";
            this.lblSportTitle.Size = new System.Drawing.Size(346, 36);
            this.lblSportTitle.TabIndex = 24;
            this.lblSportTitle.Text = "Sport Team Information";
            // 
            // SportingTeamsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.GhostWhite;
            this.BackgroundImage = global::Sporting_Teams.Properties.Resources.sandro_schuh_HgwY_YQ1m0w_unsplash;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(803, 450);
            this.Controls.Add(this.lblSportTitle);
            this.Controls.Add(this.lblPhoto);
            this.Controls.Add(this.txtBxBudgetInfo);
            this.Controls.Add(this.txtBxInfo);
            this.Controls.Add(this.gBxSport);
            this.Name = "SportingTeamsForm";
            this.Text = "Sporting Teams";
            this.Load += new System.EventHandler(this.SportingTeamsForm_Load);
            this.gBxSport.ResumeLayout(false);
            this.gBxSport.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.RadioButton rbSoccer;
        private System.Windows.Forms.RadioButton rbFootball;
        private System.Windows.Forms.GroupBox gBxSport;
        private System.Windows.Forms.RichTextBox txtBxInfo;
        private System.Windows.Forms.RichTextBox txtBxBudgetInfo;
        private System.Windows.Forms.Label lblPhoto;
        private System.Windows.Forms.Label lblSportTitle;
    }
}

