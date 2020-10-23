/*
 * Created by SharpDevelop.
 * User: Elad
 * Date: 23/10/2020
 * Time: 14:17
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Windows.Forms;

namespace input2stdout{
  /// <summary>
  /// Class with program entry point.
  /// </summary>
  internal sealed class Program{
    /// <summary>
    /// Program entry point.
    /// </summary>

    public static string info_prompt = string.Empty;
    public static string info_title = string.Empty;
    public static string info_default = string.Empty;

    [STAThread]
    public static void Main(string[] args){
      foreach (string arg in args){
        string tmp = arg.Trim();
        
        if (tmp.StartsWith("-prompt=", StringComparison.CurrentCultureIgnoreCase)){
          info_prompt = tmp.Replace("-prompt=", string.Empty).Replace("\"", string.Empty).Replace("\r", string.Empty).Replace("\\n", "\n").Replace("\\t", "    ");
        } else if (tmp.StartsWith("-title=", StringComparison.CurrentCultureIgnoreCase)){
          info_title = tmp.Replace("-title=", string.Empty).Replace("\"", string.Empty).Replace("\r", string.Empty).Replace("\\n", "\n").Replace("\\t", "    ");
        } else if (tmp.StartsWith("-default=", StringComparison.CurrentCultureIgnoreCase)){
          info_default = tmp.Replace("-default=", string.Empty).Replace("\"", string.Empty).Replace("\r", string.Empty).Replace("\\n", "\n").Replace("\\t", "    ");
        }
      }
/*
      if (string.IsNullOrEmpty(info_prompt) && string.IsNullOrEmpty(info_title) && string.IsNullOrEmpty(info_default)){
        Console.Error.WriteLine("Error: missing -prompt=\"..\" or -title=\"..\" or -default=\"..\"");
        Environment.ExitCode = 1;
        Environment.Exit(Environment.ExitCode);
      }
*/

      if (string.IsNullOrEmpty(info_prompt)){  info_prompt  = "Please Enter Something:";}
      if (string.IsNullOrEmpty(info_title)){   info_title   = "input2stdout";}
      if (string.IsNullOrEmpty(info_default)){ info_default = "Something...";}
            
      Application.EnableVisualStyles();
      Application.SetCompatibleTextRenderingDefault(false);
      
      Application.Run(new MainForm());
    }
    
  }
}
