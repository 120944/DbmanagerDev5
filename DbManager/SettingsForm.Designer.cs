namespace DbManager {
  partial class SettingsForm {
    /// <summary>
    /// Required designer variable.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary>
    /// Clean up any resources being used.
    /// </summary>
    /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
    protected override void Dispose(bool disposing) {
      if (disposing && (components != null)) {
        components.Dispose();
      }
      base.Dispose(disposing);
    }

    #region Windows Form Designer generated code

    /// <summary>
    /// Required method for Designer support - do not modify
    /// the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent() {
      this.resetButton = new System.Windows.Forms.Button();
      this.cancelButton = new System.Windows.Forms.Button();
      this.saveButton = new System.Windows.Forms.Button();
      this.label1 = new System.Windows.Forms.Label();
      this.textBox1 = new System.Windows.Forms.TextBox();
      this.label2 = new System.Windows.Forms.Label();
      this.label3 = new System.Windows.Forms.Label();
      this.textBox2 = new System.Windows.Forms.TextBox();
      this.label4 = new System.Windows.Forms.Label();
      this.textBox3 = new System.Windows.Forms.TextBox();
      this.label5 = new System.Windows.Forms.Label();
      this.textBox4 = new System.Windows.Forms.TextBox();
      this.label6 = new System.Windows.Forms.Label();
      this.textBox5 = new System.Windows.Forms.TextBox();
      this.SuspendLayout();
      // 
      // resetButton
      // 
      this.resetButton.AutoSize = true;
      this.resetButton.Location = new System.Drawing.Point(235, 320);
      this.resetButton.Name = "resetButton";
      this.resetButton.Size = new System.Drawing.Size(150, 30);
      this.resetButton.TabIndex = 1;
      this.resetButton.Text = "Reset";
      this.resetButton.UseVisualStyleBackColor = true;
      this.resetButton.Click += new System.EventHandler(this.resetButton_Click);
      // 
      // cancelButton
      // 
      this.cancelButton.AutoSize = true;
      this.cancelButton.Location = new System.Drawing.Point(10, 320);
      this.cancelButton.Name = "cancelButton";
      this.cancelButton.Size = new System.Drawing.Size(150, 30);
      this.cancelButton.TabIndex = 2;
      this.cancelButton.Text = "Cancel";
      this.cancelButton.UseVisualStyleBackColor = true;
      this.cancelButton.Click += new System.EventHandler(this.cancelButton_Click);
      // 
      // saveButton
      // 
      this.saveButton.AutoSize = true;
      this.saveButton.Location = new System.Drawing.Point(460, 320);
      this.saveButton.Name = "saveButton";
      this.saveButton.Size = new System.Drawing.Size(150, 30);
      this.saveButton.TabIndex = 3;
      this.saveButton.Text = "Save";
      this.saveButton.UseVisualStyleBackColor = true;
      this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
      // 
      // label1
      // 
      this.label1.AutoSize = true;
      this.label1.Location = new System.Drawing.Point(12, 9);
      this.label1.Name = "label1";
      this.label1.Size = new System.Drawing.Size(102, 13);
      this.label1.TabIndex = 4;
      this.label1.Text = "PostgresDB settings";
      // 
      // textBox1
      // 
      this.textBox1.Location = new System.Drawing.Point(15, 44);
      this.textBox1.Name = "textBox1";
      this.textBox1.Size = new System.Drawing.Size(100, 20);
      this.textBox1.TabIndex = 5;
      this.textBox1.Text = global::DbManager.Properties.Settings.Default.DBHost;
      // 
      // label2
      // 
      this.label2.AutoSize = true;
      this.label2.Location = new System.Drawing.Point(15, 26);
      this.label2.Name = "label2";
      this.label2.Size = new System.Drawing.Size(29, 13);
      this.label2.TabIndex = 6;
      this.label2.Text = "Host";
      // 
      // label3
      // 
      this.label3.AutoSize = true;
      this.label3.Location = new System.Drawing.Point(15, 72);
      this.label3.Name = "label3";
      this.label3.Size = new System.Drawing.Size(26, 13);
      this.label3.TabIndex = 8;
      this.label3.Text = "Port";
      // 
      // textBox2
      // 
      this.textBox2.Location = new System.Drawing.Point(15, 90);
      this.textBox2.Name = "textBox2";
      this.textBox2.Size = new System.Drawing.Size(100, 20);
      this.textBox2.TabIndex = 7;
      this.textBox2.Text = global::DbManager.Properties.Settings.Default.DBPort;
      // 
      // label4
      // 
      this.label4.AutoSize = true;
      this.label4.Location = new System.Drawing.Point(15, 114);
      this.label4.Name = "label4";
      this.label4.Size = new System.Drawing.Size(53, 13);
      this.label4.TabIndex = 10;
      this.label4.Text = "Database";
      // 
      // textBox3
      // 
      this.textBox3.Location = new System.Drawing.Point(15, 132);
      this.textBox3.Name = "textBox3";
      this.textBox3.Size = new System.Drawing.Size(100, 20);
      this.textBox3.TabIndex = 9;
      this.textBox3.Text = global::DbManager.Properties.Settings.Default.DBName;
      // 
      // label5
      // 
      this.label5.AutoSize = true;
      this.label5.Location = new System.Drawing.Point(15, 157);
      this.label5.Name = "label5";
      this.label5.Size = new System.Drawing.Size(41, 13);
      this.label5.TabIndex = 12;
      this.label5.Text = "User Id";
      // 
      // textBox4
      // 
      this.textBox4.Location = new System.Drawing.Point(15, 175);
      this.textBox4.Name = "textBox4";
      this.textBox4.Size = new System.Drawing.Size(100, 20);
      this.textBox4.TabIndex = 11;
      this.textBox4.Text = global::DbManager.Properties.Settings.Default.DBUserID;
      // 
      // label6
      // 
      this.label6.AutoSize = true;
      this.label6.Location = new System.Drawing.Point(15, 203);
      this.label6.Name = "label6";
      this.label6.Size = new System.Drawing.Size(53, 13);
      this.label6.TabIndex = 14;
      this.label6.Text = "Password";
      // 
      // textBox5
      // 
      this.textBox5.Location = new System.Drawing.Point(15, 221);
      this.textBox5.Name = "textBox5";
      this.textBox5.PasswordChar = '*';
      this.textBox5.Size = new System.Drawing.Size(100, 20);
      this.textBox5.TabIndex = 13;
      this.textBox5.Text = global::DbManager.Properties.Settings.Default.DBPassword;
      // 
      // SettingsForm
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.AutoSize = true;
      this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
      this.ClientSize = new System.Drawing.Size(620, 360);
      this.ControlBox = false;
      this.Controls.Add(this.label6);
      this.Controls.Add(this.textBox5);
      this.Controls.Add(this.label5);
      this.Controls.Add(this.textBox4);
      this.Controls.Add(this.label4);
      this.Controls.Add(this.textBox3);
      this.Controls.Add(this.label3);
      this.Controls.Add(this.textBox2);
      this.Controls.Add(this.label2);
      this.Controls.Add(this.textBox1);
      this.Controls.Add(this.label1);
      this.Controls.Add(this.saveButton);
      this.Controls.Add(this.cancelButton);
      this.Controls.Add(this.resetButton);
      this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
      this.Name = "SettingsForm";
      this.ShowIcon = false;
      this.ShowInTaskbar = false;
      this.Text = "SettingsForm";
      this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion
    private System.Windows.Forms.Button resetButton;
    private System.Windows.Forms.Button cancelButton;
    private System.Windows.Forms.Button saveButton;
    private System.Windows.Forms.Label label1;
    private System.Windows.Forms.TextBox textBox1;
    private System.Windows.Forms.Label label2;
    private System.Windows.Forms.Label label3;
    private System.Windows.Forms.TextBox textBox2;
    private System.Windows.Forms.Label label4;
    private System.Windows.Forms.TextBox textBox3;
    private System.Windows.Forms.Label label5;
    private System.Windows.Forms.TextBox textBox4;
    private System.Windows.Forms.Label label6;
    private System.Windows.Forms.TextBox textBox5;
  }
}