﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DbManager {
  public partial class QueryForm : Form {
    public QueryForm() {
      InitializeComponent();
    }

    private void richTextBox1_TextChanged(object sender, EventArgs e) {

    }

    private void cancelButton_Click(object sender, EventArgs e) {
        Hide();
    }
  }
}
