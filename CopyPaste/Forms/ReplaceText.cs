using System;
using System.Windows.Forms;

namespace ReplaceText.Forms
{
   public partial class ReplaceText : Form
   {
      public ReplaceText()
      {
         InitializeComponent();
      }

      private void BtnReplace_Click(object sender, EventArgs e)
      {
         var search = txbSearch.Text;
         var replace = txbReplace.Text;
         if (string.IsNullOrEmpty(search)) return;
         var original = txbOriginal.Text;

         txbFinal.Text = original.Replace(search, replace);
      }
   }
}