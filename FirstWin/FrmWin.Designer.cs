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
      this.components = new System.ComponentModel.Container();
      this.label1 = new System.Windows.Forms.Label();
      this.txtUserName = new System.Windows.Forms.TextBox();
      this.btnConfirm = new System.Windows.Forms.Button();
      this.checkBox1 = new System.Windows.Forms.CheckBox();
      this.comboBox1 = new System.Windows.Forms.ComboBox();
      this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
      this.label2 = new System.Windows.Forms.Label();
      this.linkLabel1 = new System.Windows.Forms.LinkLabel();
      this.listBox1 = new System.Windows.Forms.ListBox();
      this.listView1 = new System.Windows.Forms.ListView();
      this.maskedTextBox1 = new System.Windows.Forms.MaskedTextBox();
      this.timer1 = new System.Windows.Forms.Timer(this.components);
      this.eventLog1 = new System.Diagnostics.EventLog();
      this.process1 = new System.Diagnostics.Process();
      this.toolStrip1 = new System.Windows.Forms.ToolStrip();
      this.statusStrip1 = new System.Windows.Forms.StatusStrip();
      this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
      ((System.ComponentModel.ISupportInitialize)(this.eventLog1)).BeginInit();
      this.toolStrip1.SuspendLayout();
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
      this.txtUserName.Location = new System.Drawing.Point(142, 70);
      this.txtUserName.Name = "txtUserName";
      this.txtUserName.Size = new System.Drawing.Size(100, 20);
      this.txtUserName.TabIndex = 1;
      // 
      // btnConfirm
      // 
      this.btnConfirm.Location = new System.Drawing.Point(167, 174);
      this.btnConfirm.Name = "btnConfirm";
      this.btnConfirm.Size = new System.Drawing.Size(141, 23);
      this.btnConfirm.TabIndex = 2;
      this.btnConfirm.Text = "打开一个弹出窗口";
      this.btnConfirm.UseVisualStyleBackColor = true;
      this.btnConfirm.Click += new System.EventHandler(this.btnConfirm_Click);
      // 
      // checkBox1
      // 
      this.checkBox1.AutoSize = true;
      this.checkBox1.Location = new System.Drawing.Point(335, 33);
      this.checkBox1.Name = "checkBox1";
      this.checkBox1.Size = new System.Drawing.Size(80, 17);
      this.checkBox1.TabIndex = 3;
      this.checkBox1.Text = "checkBox1";
      this.checkBox1.UseVisualStyleBackColor = true;
      // 
      // comboBox1
      // 
      this.comboBox1.FormattingEnabled = true;
      this.comboBox1.Location = new System.Drawing.Point(368, 73);
      this.comboBox1.Name = "comboBox1";
      this.comboBox1.Size = new System.Drawing.Size(121, 21);
      this.comboBox1.TabIndex = 4;
      // 
      // dateTimePicker1
      // 
      this.dateTimePicker1.Location = new System.Drawing.Point(252, 128);
      this.dateTimePicker1.Name = "dateTimePicker1";
      this.dateTimePicker1.Size = new System.Drawing.Size(200, 20);
      this.dateTimePicker1.TabIndex = 5;
      // 
      // label2
      // 
      this.label2.AutoSize = true;
      this.label2.Location = new System.Drawing.Point(99, 134);
      this.label2.Name = "label2";
      this.label2.Size = new System.Drawing.Size(35, 13);
      this.label2.TabIndex = 6;
      this.label2.Text = "label2";
      // 
      // linkLabel1
      // 
      this.linkLabel1.AutoSize = true;
      this.linkLabel1.Location = new System.Drawing.Point(51, 196);
      this.linkLabel1.Name = "linkLabel1";
      this.linkLabel1.Size = new System.Drawing.Size(55, 13);
      this.linkLabel1.TabIndex = 7;
      this.linkLabel1.TabStop = true;
      this.linkLabel1.Text = "linkLabel1";
      // 
      // listBox1
      // 
      this.listBox1.FormattingEnabled = true;
      this.listBox1.Items.AddRange(new object[] {
            "gg",
            "dd",
            "aa",
            "vv",
            "zz",
            "fd",
            "fasdf"});
      this.listBox1.Location = new System.Drawing.Point(43, 233);
      this.listBox1.Name = "listBox1";
      this.listBox1.Size = new System.Drawing.Size(120, 95);
      this.listBox1.TabIndex = 8;
      // 
      // listView1
      // 
      this.listView1.HideSelection = false;
      this.listView1.Location = new System.Drawing.Point(204, 224);
      this.listView1.Name = "listView1";
      this.listView1.Size = new System.Drawing.Size(121, 97);
      this.listView1.TabIndex = 9;
      this.listView1.UseCompatibleStateImageBehavior = false;
      // 
      // maskedTextBox1
      // 
      this.maskedTextBox1.Location = new System.Drawing.Point(385, 244);
      this.maskedTextBox1.Name = "maskedTextBox1";
      this.maskedTextBox1.Size = new System.Drawing.Size(100, 20);
      this.maskedTextBox1.TabIndex = 10;
      // 
      // eventLog1
      // 
      this.eventLog1.SynchronizingObject = this;
      // 
      // process1
      // 
      this.process1.StartInfo.Domain = "";
      this.process1.StartInfo.LoadUserProfile = false;
      this.process1.StartInfo.Password = null;
      this.process1.StartInfo.StandardErrorEncoding = null;
      this.process1.StartInfo.StandardOutputEncoding = null;
      this.process1.StartInfo.UserName = "";
      this.process1.SynchronizingObject = this;
      // 
      // toolStrip1
      // 
      this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripLabel1});
      this.toolStrip1.Location = new System.Drawing.Point(0, 0);
      this.toolStrip1.Name = "toolStrip1";
      this.toolStrip1.Size = new System.Drawing.Size(563, 25);
      this.toolStrip1.TabIndex = 11;
      this.toolStrip1.Text = "toolStrip1";
      // 
      // statusStrip1
      // 
      this.statusStrip1.Location = new System.Drawing.Point(0, 379);
      this.statusStrip1.Name = "statusStrip1";
      this.statusStrip1.Size = new System.Drawing.Size(563, 22);
      this.statusStrip1.TabIndex = 12;
      this.statusStrip1.Text = "statusStrip1";
      // 
      // toolStripLabel1
      // 
      this.toolStripLabel1.Name = "toolStripLabel1";
      this.toolStripLabel1.Size = new System.Drawing.Size(96, 22);
      this.toolStripLabel1.Text = "toolStripLabel1";
      // 
      // FrmWin
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.BackColor = System.Drawing.SystemColors.ActiveCaption;
      this.ClientSize = new System.Drawing.Size(563, 401);
      this.Controls.Add(this.statusStrip1);
      this.Controls.Add(this.toolStrip1);
      this.Controls.Add(this.maskedTextBox1);
      this.Controls.Add(this.listView1);
      this.Controls.Add(this.listBox1);
      this.Controls.Add(this.linkLabel1);
      this.Controls.Add(this.label2);
      this.Controls.Add(this.dateTimePicker1);
      this.Controls.Add(this.comboBox1);
      this.Controls.Add(this.checkBox1);
      this.Controls.Add(this.btnConfirm);
      this.Controls.Add(this.txtUserName);
      this.Controls.Add(this.label1);
      this.ForeColor = System.Drawing.SystemColors.ControlText;
      this.MaximizeBox = false;
      this.Name = "FrmWin";
      this.ShowIcon = false;
      this.Text = "桌面程序";
      ((System.ComponentModel.ISupportInitialize)(this.eventLog1)).EndInit();
      this.toolStrip1.ResumeLayout(false);
      this.toolStrip1.PerformLayout();
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.Label label1;
    private System.Windows.Forms.TextBox txtUserName;
    private System.Windows.Forms.Button btnConfirm;
    private System.Windows.Forms.CheckBox checkBox1;
    private System.Windows.Forms.ComboBox comboBox1;
    private System.Windows.Forms.DateTimePicker dateTimePicker1;
    private System.Windows.Forms.Label label2;
    private System.Windows.Forms.LinkLabel linkLabel1;
    private System.Windows.Forms.ListBox listBox1;
    private System.Windows.Forms.ListView listView1;
    private System.Windows.Forms.MaskedTextBox maskedTextBox1;
    private System.Windows.Forms.Timer timer1;
    private System.Diagnostics.EventLog eventLog1;
    private System.Windows.Forms.StatusStrip statusStrip1;
    private System.Windows.Forms.ToolStrip toolStrip1;
    private System.Diagnostics.Process process1;
    private System.Windows.Forms.ToolStripLabel toolStripLabel1;
  }
}

