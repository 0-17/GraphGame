﻿namespace GraphGame;

partial class Form1
{
    /// <summary>
    ///  Required designer variable.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary>
    ///  Clean up any resources being used.
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
    ///  Required method for Designer support - do not modify
    ///  the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent()
    {
        this.pictureBox = new System.Windows.Forms.PictureBox();
        ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).BeginInit();
        this.SuspendLayout();

        this.pictureBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
                                                                         | System.Windows.Forms.AnchorStyles.Left) 
                                                                        | System.Windows.Forms.AnchorStyles.Right)));
        this.pictureBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
        this.pictureBox.Location = new System.Drawing.Point(12, 12);
        this.pictureBox.Name = "pictureBox";
        this.pictureBox.Size = new System.Drawing.Size(776, 426);
        this.pictureBox.TabIndex = 0;
        this.pictureBox.TabStop = false;
        
        this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
        this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        this.ClientSize = new System.Drawing.Size(800, 450);
        this.Controls.Add(this.pictureBox);
        this.Name = "Form1";
        this.Load += new System.EventHandler(this.Form1_Load);
        ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).EndInit();
        this.ResumeLayout(false);
        this.Text = "Form1";
        
    }

    #endregion
    private System.Windows.Forms.PictureBox pictureBox;
}