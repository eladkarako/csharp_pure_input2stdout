/*
 * Created by SharpDevelop.
 * User: Elad
 * Date: 23/10/2020
 * Time: 14:17
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace input2stdout
{
  partial class MainForm
  {
    /// <summary>
    /// Designer variable used to keep track of non-visual components.
    /// </summary>
    private System.ComponentModel.IContainer components = null;
    private System.Windows.Forms.Button button_OK;
    private System.Windows.Forms.Button button_CANCEL;
    private System.Windows.Forms.TextBox text_input;
    private System.Windows.Forms.TextBox text_prompt;
    
    /// <summary>
    /// Disposes resources used by the form.
    /// </summary>
    /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
    protected override void Dispose(bool disposing)
    {
      if (disposing) {
        if (components != null) {
          components.Dispose();
        }
      }
      base.Dispose(disposing);
    }
    
    /// <summary>
    /// This method is required for Windows Forms designer support.
    /// Do not change the method contents inside the source code editor. The Forms designer might
    /// not be able to load this method if it was changed manually.
    /// </summary>
    private void InitializeComponent()
    {
      this.button_OK = new System.Windows.Forms.Button();
      this.button_CANCEL = new System.Windows.Forms.Button();
      this.text_input = new System.Windows.Forms.TextBox();
      this.text_prompt = new System.Windows.Forms.TextBox();
      this.SuspendLayout();
      // 
      // button_OK
      // 
      this.button_OK.BackColor = System.Drawing.Color.Lime;
      this.button_OK.Location = new System.Drawing.Point(368, 208);
      this.button_OK.Name = "button_OK";
      this.button_OK.Size = new System.Drawing.Size(120, 40);
      this.button_OK.TabIndex = 1;
      this.button_OK.Text = "V";
      this.button_OK.UseVisualStyleBackColor = false;
      this.button_OK.Click += new System.EventHandler(this.Button_OKClick);
      // 
      // button_CANCEL
      // 
      this.button_CANCEL.BackColor = System.Drawing.Color.Red;
      this.button_CANCEL.DialogResult = System.Windows.Forms.DialogResult.Cancel;
      this.button_CANCEL.Location = new System.Drawing.Point(240, 208);
      this.button_CANCEL.Name = "button_CANCEL";
      this.button_CANCEL.Size = new System.Drawing.Size(120, 40);
      this.button_CANCEL.TabIndex = 2;
      this.button_CANCEL.Text = "X";
      this.button_CANCEL.UseVisualStyleBackColor = false;
      this.button_CANCEL.Click += new System.EventHandler(this.Button_CANCELClick);
      // 
      // text_input
      // 
      this.text_input.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
      this.text_input.Font = new System.Drawing.Font("Courier New", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
      this.text_input.Location = new System.Drawing.Point(8, 128);
      this.text_input.Name = "text_input";
      this.text_input.Size = new System.Drawing.Size(480, 53);
      this.text_input.TabIndex = 0;
      this.text_input.Text = "Something...";
      // 
      // text_prompt
      // 
      this.text_prompt.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
      this.text_prompt.BorderStyle = System.Windows.Forms.BorderStyle.None;
      this.text_prompt.Cursor = System.Windows.Forms.Cursors.Arrow;
      this.text_prompt.Font = new System.Drawing.Font("Tahoma", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.text_prompt.Location = new System.Drawing.Point(8, 8);
      this.text_prompt.Multiline = true;
      this.text_prompt.Name = "text_prompt";
      this.text_prompt.ReadOnly = true;
      this.text_prompt.Size = new System.Drawing.Size(480, 112);
      this.text_prompt.TabIndex = 3;
      this.text_prompt.Text = "Enter Something:";
      // 
      // MainForm
      // 
      this.AcceptButton = this.button_OK;
      this.AutoScaleDimensions = new System.Drawing.SizeF(15F, 33F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.BackColor = System.Drawing.Color.Yellow;
      this.CancelButton = this.button_CANCEL;
      this.ClientSize = new System.Drawing.Size(494, 258);
      this.ControlBox = false;
      this.Controls.Add(this.text_prompt);
      this.Controls.Add(this.text_input);
      this.Controls.Add(this.button_CANCEL);
      this.Controls.Add(this.button_OK);
      this.DoubleBuffered = true;
      this.Font = new System.Drawing.Font("Tahoma", 20.25F);
      this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
      this.KeyPreview = true;
      this.Margin = new System.Windows.Forms.Padding(8);
      this.MaximizeBox = false;
      this.MinimizeBox = false;
      this.Name = "MainForm";
      this.Opacity = 0.8D;
      this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
      this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
      this.Text = "input2stdout";
      this.TopMost = true;
      this.Load += new System.EventHandler(this.MainFormLoad);
      this.ResumeLayout(false);
      this.PerformLayout();

    }
  }
}
