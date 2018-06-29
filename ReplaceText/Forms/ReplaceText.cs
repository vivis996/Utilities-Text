using System;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace ReplaceText.Forms
{
   internal partial class ReplaceText : Form
   {
      internal ReplaceText()
      {
         InitializeComponent();
      }

      private void BtnReplace_Click(object sender, EventArgs e)
      {
         var search = txbSearch.Text;
         var replace = txbReplace.Text;
         if (string.IsNullOrEmpty(search)) return;
         try
         {
            var original = txbOriginal.Text;
            string textFinal = null;
            if (rbtnNormal.Checked)
            {
               textFinal = original.Replace(search, replace);
            }
            else
            {
               if (rbtnRegex.Checked)
               {
                  var regex = new Regex(search);
                  textFinal = regex.Replace(original, replace);
               }
            }
            txbFinal.Text = textFinal;
         }
         catch (Exception ex)
         {
            const string message = "Error al reemplazr\n", title = "Error";
            MessageBox.Show(message + ex, title, MessageBoxButtons.OK, MessageBoxIcon.Error);
         }
      }
   }
}