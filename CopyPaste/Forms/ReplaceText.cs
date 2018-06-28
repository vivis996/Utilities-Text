using System;
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

            txbFinal.Text = original.Replace(search, replace);
         }
         catch (Exception ex)
         {
            const string message = "Error al reemplazr\n", title = "Error";
            MessageBox.Show(message + ex, title,  MessageBoxButtons.OK, MessageBoxIcon.Error);
         }
      }
   }
}