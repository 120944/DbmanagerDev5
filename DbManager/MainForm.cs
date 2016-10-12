using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DbManager.Properties;
using Logic;

namespace DbManager {
  public partial class MainForm : Form {
    private DbConnector _dbConnector;

    public MainForm() {
      InitializeComponent();
      _dbConnector = new PostgreSqlDbConnector(PostgreSqlDbConnector.FromAppSettings(Settings.Default));
    }

    private void settingsToolStripMenuItem_Click(object sender, EventArgs e) {
      try {
        var settingsForm = new SettingsForm {
          TopLevel = false,
          AutoScroll = true,
          Dock = DockStyle.Fill
        };
        if (splitContainer2.Panel1.Controls.Contains(settingsForm)) {
          return;
        }
        splitContainer2.Panel1.Controls.Add(settingsForm);
        settingsForm.Show();
      }
      catch (Exception) {
        throw;
      }
    }

    private void queryToolStripMenuItem_Click(object sender, EventArgs e) {
      try {
        var queryForm = new QueryForm {
          TopLevel = false,
          AutoScroll = true,
          Dock = DockStyle.Fill
        };

        if (splitContainer2.Panel1.Controls.Contains(queryForm)) {
          return;
        }
        splitContainer2.Panel1.Controls.Add(queryForm);
        queryForm.Show();
      }
      catch (Exception) {
        throw;
      }
    }

    private void Main_Load(object sender, EventArgs e) {
      var table = new TableForm {
        TopLevel = false,
        AutoScroll = true,
        Dock = DockStyle.Fill
      };
      splitContainer1.Panel2.Controls.Add(table);
      table.Show();
    }

    protected override void OnResizeEnd(EventArgs e) {
      base.OnResizeEnd(e);
    }

    private void mainToolStripMenuItem_Click(object sender, EventArgs e) {

    }

  }
}
