﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FirstWin
{
  public partial class FrmWin : Form
  {
    public FrmWin()
    {
      InitializeComponent();
    }

    private void btnConfirm_Click(object sender, EventArgs e)
    {
      MessageBox.Show(this.txtUserName.Text);
    }
  }
}
