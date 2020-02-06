namespace StudentTime
{
  partial class Form1
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
      this.buttStatus = new System.Windows.Forms.Button();
      this.lblStatus = new System.Windows.Forms.Label();
      this.label2 = new System.Windows.Forms.Label();
      this.trkNumCredits = new System.Windows.Forms.TrackBar();
      this.lblNumCredits = new System.Windows.Forms.Label();
      ((System.ComponentModel.ISupportInitialize)(this.trkNumCredits)).BeginInit();
      this.SuspendLayout();
      // 
      // buttStatus
      // 
      this.buttStatus.Location = new System.Drawing.Point(240, 102);
      this.buttStatus.Name = "buttStatus";
      this.buttStatus.Size = new System.Drawing.Size(139, 65);
      this.buttStatus.TabIndex = 0;
      this.buttStatus.Text = "What\'s my Status?";
      this.buttStatus.UseVisualStyleBackColor = true;
      this.buttStatus.Click += new System.EventHandler(this.buttStatus_Click);
      // 
      // lblStatus
      // 
      this.lblStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.875F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.lblStatus.Location = new System.Drawing.Point(43, 102);
      this.lblStatus.Name = "lblStatus";
      this.lblStatus.Size = new System.Drawing.Size(186, 98);
      this.lblStatus.TabIndex = 1;
      this.lblStatus.TextAlign = System.Drawing.ContentAlignment.TopCenter;
      // 
      // label2
      // 
      this.label2.AutoSize = true;
      this.label2.Location = new System.Drawing.Point(43, 18);
      this.label2.Name = "label2";
      this.label2.Size = new System.Drawing.Size(191, 25);
      this.label2.TabIndex = 3;
      this.label2.Text = "Number of Credits:";
      // 
      // trkNumCredits
      // 
      this.trkNumCredits.Location = new System.Drawing.Point(48, 46);
      this.trkNumCredits.Maximum = 24;
      this.trkNumCredits.Name = "trkNumCredits";
      this.trkNumCredits.Size = new System.Drawing.Size(298, 90);
      this.trkNumCredits.TabIndex = 4;
      this.trkNumCredits.Scroll += new System.EventHandler(this.trkNumCredits_Scroll);
      // 
      // lblNumCredits
      // 
      this.lblNumCredits.Location = new System.Drawing.Point(330, 46);
      this.lblNumCredits.Name = "lblNumCredits";
      this.lblNumCredits.Size = new System.Drawing.Size(49, 53);
      this.lblNumCredits.TabIndex = 5;
      // 
      // Form1
      // 
      this.AcceptButton = this.buttStatus;
      this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(430, 241);
      this.Controls.Add(this.lblNumCredits);
      this.Controls.Add(this.buttStatus);
      this.Controls.Add(this.label2);
      this.Controls.Add(this.lblStatus);
      this.Controls.Add(this.trkNumCredits);
      this.Name = "Form1";
      this.Text = "Student Status!";
      ((System.ComponentModel.ISupportInitialize)(this.trkNumCredits)).EndInit();
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.Button buttStatus;
    private System.Windows.Forms.Label lblStatus;
    private System.Windows.Forms.Label label2;
    private System.Windows.Forms.TrackBar trkNumCredits;
    private System.Windows.Forms.Label lblNumCredits;
  }
}

