﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StudentTime
{
  public partial class Form1 : Form
  {
    public Form1()
    {
      InitializeComponent();
    }

    private void buttStatus_Click(object sender, EventArgs e)
    {
      int creditAmount = trkNumCredits.Value;
      if (creditAmount >= 12 && creditAmount <= 24)
      {
        lblStatus.Text = "You are here\nFull Time";
      }
      else if (creditAmount >= 6 && creditAmount <= 11)
      {
        lblStatus.Text = "You are here\nHalf Time";
      }
      else if (creditAmount > 0 && creditAmount <= 5)
      {
        lblStatus.Text = "You are here\nless then Half Time";
      }
      else if (creditAmount == 0)
      {
        lblStatus.Text = "You aren't even a student who let you in here?";
      }
    }

    private void trkNumCredits_Scroll(object sender, EventArgs e)
    {
      lblNumCredits.Text = trkNumCredits.Value.ToString();
    }
  }
}
