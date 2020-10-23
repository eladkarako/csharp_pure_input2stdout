/*
 * Created by SharpDevelop.
 * User: Elad
 * Date: 23/10/2020
 * Time: 14:17
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace input2stdout
{
  /// <summary>
  /// Description of MainForm.
  /// </summary>
  public partial class MainForm : Form
  {
    public MainForm()
    {
      //
      // The InitializeComponent() call is required for Windows Forms designer support.
      //
      InitializeComponent();
      
      //
      // TODO: Add constructor code after the InitializeComponent() call.
      //
    }
    void MainFormLoad(object sender, EventArgs e){

    }
    void Button_OKClick(object sender, EventArgs e){
      System.Console.Out.Write(this.text_input.Text);
      Environment.ExitCode = 0;
      Environment.Exit(0);
    }
    void Button_CANCELClick(object sender, EventArgs e){
      //System.Console.Out.Write("");
      Environment.ExitCode = 1;
      Environment.Exit(1);
    }

  }
}
