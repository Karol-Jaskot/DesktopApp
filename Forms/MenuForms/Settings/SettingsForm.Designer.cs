﻿namespace DesktopApp.Forms.MenuForms.Settings
{
    partial class SettingsForm
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
            this.contentPanel = new System.Windows.Forms.Panel();
            this.themePanel = new System.Windows.Forms.Panel();
            this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            this.lightColorButton = new MaterialSkin.Controls.MaterialRaisedButton();
            this.darkColorButton = new MaterialSkin.Controls.MaterialRaisedButton();
            this.contentPanel.SuspendLayout();
            this.themePanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // contentPanel
            // 
            this.contentPanel.Controls.Add(this.themePanel);
            this.contentPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.contentPanel.Location = new System.Drawing.Point(0, 0);
            this.contentPanel.Name = "contentPanel";
            this.contentPanel.Size = new System.Drawing.Size(800, 600);
            this.contentPanel.TabIndex = 0;
            // 
            // themePanel
            // 
            this.themePanel.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.themePanel.Controls.Add(this.materialLabel1);
            this.themePanel.Controls.Add(this.lightColorButton);
            this.themePanel.Controls.Add(this.darkColorButton);
            this.themePanel.Location = new System.Drawing.Point(19, 19);
            this.themePanel.Margin = new System.Windows.Forms.Padding(10);
            this.themePanel.Name = "themePanel";
            this.themePanel.Size = new System.Drawing.Size(762, 120);
            this.themePanel.TabIndex = 3;
            // 
            // materialLabel1
            // 
            this.materialLabel1.AutoSize = true;
            this.materialLabel1.Depth = 0;
            this.materialLabel1.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel1.Location = new System.Drawing.Point(64, 52);
            this.materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel1.Name = "materialLabel1";
            this.materialLabel1.Size = new System.Drawing.Size(122, 19);
            this.materialLabel1.TabIndex = 3;
            this.materialLabel1.Text = "Motyw graficzny:";
            // 
            // lightColorButton
            // 
            this.lightColorButton.Depth = 0;
            this.lightColorButton.Location = new System.Drawing.Point(498, 40);
            this.lightColorButton.MouseState = MaterialSkin.MouseState.HOVER;
            this.lightColorButton.Name = "lightColorButton";
            this.lightColorButton.Primary = true;
            this.lightColorButton.Size = new System.Drawing.Size(193, 45);
            this.lightColorButton.TabIndex = 2;
            this.lightColorButton.Text = "Jasny";
            this.lightColorButton.UseVisualStyleBackColor = true;
            this.lightColorButton.Click += new System.EventHandler(this.lightColorButton_Click);
            // 
            // darkColorButton
            // 
            this.darkColorButton.Depth = 0;
            this.darkColorButton.Location = new System.Drawing.Point(252, 40);
            this.darkColorButton.MouseState = MaterialSkin.MouseState.HOVER;
            this.darkColorButton.Name = "darkColorButton";
            this.darkColorButton.Primary = true;
            this.darkColorButton.Size = new System.Drawing.Size(193, 45);
            this.darkColorButton.TabIndex = 1;
            this.darkColorButton.Text = "Ciemny";
            this.darkColorButton.UseVisualStyleBackColor = true;
            this.darkColorButton.Click += new System.EventHandler(this.darkColorButton_Click);
            // 
            // SettingsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 600);
            this.Controls.Add(this.contentPanel);
            this.Name = "SettingsForm";
            this.Text = "SettingsForm";
            this.contentPanel.ResumeLayout(false);
            this.themePanel.ResumeLayout(false);
            this.themePanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel contentPanel;
        private MaterialSkin.Controls.MaterialRaisedButton lightColorButton;
        private MaterialSkin.Controls.MaterialRaisedButton darkColorButton;
        private System.Windows.Forms.Panel themePanel;
        private MaterialSkin.Controls.MaterialLabel materialLabel1;
    }
}