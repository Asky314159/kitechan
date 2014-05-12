﻿namespace Kitechan
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
            this.headerPanel = new System.Windows.Forms.Panel();
            this.streamHeartsLabel = new System.Windows.Forms.Label();
            this.streamNameLabel = new System.Windows.Forms.Label();
            this.commentTextBox = new System.Windows.Forms.TextBox();
            this.postButton = new System.Windows.Forms.Button();
            this.loginLabel = new System.Windows.Forms.LinkLabel();
            this.jeffPictureBox = new Kitechan.SmoothPictureBox();
            this.bodyPanel = new Kitechan.ScrollablePanel();
            this.headerPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.jeffPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // headerPanel
            // 
            this.headerPanel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.headerPanel.Controls.Add(this.loginLabel);
            this.headerPanel.Controls.Add(this.streamHeartsLabel);
            this.headerPanel.Controls.Add(this.jeffPictureBox);
            this.headerPanel.Controls.Add(this.streamNameLabel);
            this.headerPanel.Location = new System.Drawing.Point(12, 12);
            this.headerPanel.Name = "headerPanel";
            this.headerPanel.Size = new System.Drawing.Size(615, 57);
            this.headerPanel.TabIndex = 1;
            // 
            // streamHeartsLabel
            // 
            this.streamHeartsLabel.AutoSize = true;
            this.streamHeartsLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.streamHeartsLabel.Location = new System.Drawing.Point(59, 34);
            this.streamHeartsLabel.Name = "streamHeartsLabel";
            this.streamHeartsLabel.Size = new System.Drawing.Size(114, 15);
            this.streamHeartsLabel.TabIndex = 3;
            this.streamHeartsLabel.Text = "[STREAM HEARTS]";
            // 
            // streamNameLabel
            // 
            this.streamNameLabel.AutoSize = true;
            this.streamNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.streamNameLabel.Location = new System.Drawing.Point(59, 3);
            this.streamNameLabel.Name = "streamNameLabel";
            this.streamNameLabel.Size = new System.Drawing.Size(101, 15);
            this.streamNameLabel.TabIndex = 0;
            this.streamNameLabel.Text = "[STREAM NAME]";
            // 
            // commentTextBox
            // 
            this.commentTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.commentTextBox.Location = new System.Drawing.Point(15, 369);
            this.commentTextBox.Multiline = true;
            this.commentTextBox.Name = "commentTextBox";
            this.commentTextBox.Size = new System.Drawing.Size(531, 49);
            this.commentTextBox.TabIndex = 2;
            this.commentTextBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.commentTextBox_KeyDown);
            // 
            // postButton
            // 
            this.postButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.postButton.Location = new System.Drawing.Point(552, 369);
            this.postButton.Name = "postButton";
            this.postButton.Size = new System.Drawing.Size(75, 49);
            this.postButton.TabIndex = 3;
            this.postButton.Text = "Post";
            this.postButton.UseVisualStyleBackColor = true;
            this.postButton.Click += new System.EventHandler(this.postButton_Click);
            // 
            // loginLabel
            // 
            this.loginLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.loginLabel.AutoSize = true;
            this.loginLabel.Location = new System.Drawing.Point(579, 5);
            this.loginLabel.Name = "loginLabel";
            this.loginLabel.Size = new System.Drawing.Size(33, 13);
            this.loginLabel.TabIndex = 4;
            this.loginLabel.TabStop = true;
            this.loginLabel.Text = "Login";
            this.loginLabel.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.loginLabel_LinkClicked);
            // 
            // jeffPictureBox
            // 
            this.jeffPictureBox.Location = new System.Drawing.Point(3, 3);
            this.jeffPictureBox.Name = "jeffPictureBox";
            this.jeffPictureBox.Size = new System.Drawing.Size(50, 50);
            this.jeffPictureBox.TabIndex = 1;
            this.jeffPictureBox.TabStop = false;
            // 
            // bodyPanel
            // 
            this.bodyPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.bodyPanel.AutoScroll = true;
            this.bodyPanel.Location = new System.Drawing.Point(12, 75);
            this.bodyPanel.Name = "bodyPanel";
            this.bodyPanel.Size = new System.Drawing.Size(615, 288);
            this.bodyPanel.TabIndex = 0;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(639, 430);
            this.Controls.Add(this.postButton);
            this.Controls.Add(this.commentTextBox);
            this.Controls.Add(this.headerPanel);
            this.Controls.Add(this.bodyPanel);
            this.Name = "MainForm";
            this.Text = "Kitechan";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.headerPanel.ResumeLayout(false);
            this.headerPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.jeffPictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ScrollablePanel bodyPanel;
        private System.Windows.Forms.Panel headerPanel;
        private System.Windows.Forms.Label streamNameLabel;
        private SmoothPictureBox jeffPictureBox;
        private System.Windows.Forms.Label streamHeartsLabel;
        private System.Windows.Forms.TextBox commentTextBox;
        private System.Windows.Forms.Button postButton;
        private System.Windows.Forms.LinkLabel loginLabel;



    }
}

