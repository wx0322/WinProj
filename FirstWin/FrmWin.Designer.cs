namespace FirstWin
{
  partial class FrmWin
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
      this.label1 = new System.Windows.Forms.Label();
      this.txtUserName = new System.Windows.Forms.TextBox();
      this.btnConfirm = new System.Windows.Forms.Button();
      this.SuspendLayout();
      // 
      // label1
      // 
      this.label1.AutoSize = true;
      this.label1.Location = new System.Drawing.Point(68, 73);
      this.label1.Name = "label1";
      this.label1.Size = new System.Drawing.Size(67, 13);
      this.label1.TabIndex = 0;
      this.label1.Text = "我的名字：";
      // 
      // txtUserName
      // 
      this.txtUserName.Location = new System.Drawing.Point(132, 70);
      this.txtUserName.Name = "txtUserName";
      this.txtUserName.Size = new System.Drawing.Size(100, 20);
      this.txtUserName.TabIndex = 1;
      // 
      // btnConfirm
      // 
      this.btnConfirm.Location = new System.Drawing.Point(167, 174);
      this.btnConfirm.Name = "btnConfirm";
      this.btnConfirm.Size = new System.Drawing.Size(75, 23);
      this.btnConfirm.TabIndex = 2;
      this.btnConfirm.Text = "提交";
      this.btnConfirm.UseVisualStyleBackColor = true;
      this.btnConfirm.Click += new System.EventHandler(this.btnConfirm_Click);
      // 
      // FrmWin
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.BackColor = System.Drawing.SystemColors.ActiveCaption;
      this.ClientSize = new System.Drawing.Size(500, 319);
      this.Controls.Add(this.btnConfirm);
      this.Controls.Add(this.txtUserName);
      this.Controls.Add(this.label1);
      this.ForeColor = System.Drawing.SystemColors.ControlText;
      this.MaximizeBox = false;
      this.Name = "FrmWin";
      this.ShowIcon = false;
      this.Text = "桌面程序";
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.Label label1;
    private System.Windows.Forms.TextBox txtUserName;
    private System.Windows.Forms.Button btnConfirm;
  }
}

