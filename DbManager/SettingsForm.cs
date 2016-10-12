using System;
using System.Windows.Forms;
using DbManager.Properties;

namespace DbManager {
  public partial class SettingsForm : Form {
    public SettingsForm() {
      InitializeComponent();
      ResetTextBoxes();
    }

    private void cancelButton_Click(object sender, EventArgs e) {
        Hide();
    }

    private void resetButton_Click(object sender, EventArgs e) {
      Settings.Default.Reset();
      ResetTextBoxes();
    }

    private void saveButton_Click(object sender, EventArgs e) {
      Properties.Settings.Default.DBHost = textBox1.Text;
      Properties.Settings.Default.DBPort = textBox2.Text;
      Properties.Settings.Default.DBName = textBox3.Text;
      Properties.Settings.Default.DBUserID = textBox4.Text;
      Properties.Settings.Default.DBPassword = textBox5.Text;
      Properties.Settings.Default.Save();
    }

    private void ResetTextBoxes() {
      textBox1.Text = Settings.Default.DBHost;
      textBox2.Text = Settings.Default.DBPort;
      textBox3.Text = Settings.Default.DBName;
      textBox4.Text = Settings.Default.DBUserID;
      textBox5.Text = Settings.Default.DBPassword;
    }
  }
}
