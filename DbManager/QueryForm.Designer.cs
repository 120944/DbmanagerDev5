namespace DbManager {
  partial class QueryForm {
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
      this.richTextBox1 = new System.Windows.Forms.RichTextBox();
      this.cancelButton = new System.Windows.Forms.Button();
      this.SuspendLayout();
      // 
      // richTextBox1
      // 
      this.richTextBox1.Location = new System.Drawing.Point(13, 13);
      this.richTextBox1.Name = "richTextBox1";
      this.richTextBox1.Size = new System.Drawing.Size(595, 276);
      this.richTextBox1.TabIndex = 0;
      this.richTextBox1.Text = "";
      this.richTextBox1.TextChanged += new System.EventHandler(this.richTextBox1_TextChanged);
      // 
      // cancelButton
      // 
      this.cancelButton.Location = new System.Drawing.Point(13, 318);
      this.cancelButton.Name = "cancelButton";
      this.cancelButton.Size = new System.Drawing.Size(150, 30);
      this.cancelButton.TabIndex = 1;
      this.cancelButton.Text = "Cancel";
      this.cancelButton.UseVisualStyleBackColor = true;
      this.cancelButton.Click += new System.EventHandler(this.cancelButton_Click);
      // 
      // QueryForm
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.AutoSize = true;
      this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
      this.ClientSize = new System.Drawing.Size(620, 360);
      this.ControlBox = false;
      this.Controls.Add(this.cancelButton);
      this.Controls.Add(this.richTextBox1);
      this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
      this.Name = "QueryForm";
      this.ShowIcon = false;
      this.ShowInTaskbar = false;
      this.Text = "QueryForm";
      this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
      this.ResumeLayout(false);

    }

    #endregion

    private System.Windows.Forms.RichTextBox richTextBox1;
    private System.Windows.Forms.Button cancelButton;
  }
}