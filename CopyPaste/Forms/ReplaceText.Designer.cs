namespace ReplaceText.Forms
{
   partial class ReplaceText
   {
      /// <summary>
      /// Required designer variable.
      /// </summary>
      private System.ComponentModel.IContainer components = null;

      /// <summary>
      /// Clean up any resources being used.
      /// </summary>
      /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
      protected override void Dispose(bool disposing)
      {
         if (disposing && (components != null))
         {
            components.Dispose();
         }
         base.Dispose(disposing);
      }

      #region Windows Form Designer generated code

      /// <summary>
      /// Required method for Designer support - do not modify
      /// the contents of this method with the code editor.
      /// </summary>
      private void InitializeComponent()
      {
         this.txbSearch = new System.Windows.Forms.RichTextBox();
         this.txbReplace = new System.Windows.Forms.RichTextBox();
         this.txbOriginal = new System.Windows.Forms.RichTextBox();
         this.txbFinal = new System.Windows.Forms.RichTextBox();
         this.btnReplace = new System.Windows.Forms.Button();
         this.label1 = new System.Windows.Forms.Label();
         this.label2 = new System.Windows.Forms.Label();
         this.label3 = new System.Windows.Forms.Label();
         this.label4 = new System.Windows.Forms.Label();
         this.SuspendLayout();
         // 
         // txbSearch
         // 
         this.txbSearch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(55)))), ((int)(((byte)(55)))));
         this.txbSearch.BorderStyle = System.Windows.Forms.BorderStyle.None;
         this.txbSearch.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(222)))), ((int)(((byte)(222)))));
         this.txbSearch.Location = new System.Drawing.Point(12, 25);
         this.txbSearch.Name = "txbSearch";
         this.txbSearch.Size = new System.Drawing.Size(274, 55);
         this.txbSearch.TabIndex = 0;
         this.txbSearch.Text = "";
         // 
         // txbReplace
         // 
         this.txbReplace.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(55)))), ((int)(((byte)(55)))));
         this.txbReplace.BorderStyle = System.Windows.Forms.BorderStyle.None;
         this.txbReplace.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(222)))), ((int)(((byte)(222)))));
         this.txbReplace.Location = new System.Drawing.Point(12, 99);
         this.txbReplace.Name = "txbReplace";
         this.txbReplace.Size = new System.Drawing.Size(355, 52);
         this.txbReplace.TabIndex = 1;
         this.txbReplace.Text = "";
         // 
         // txbOriginal
         // 
         this.txbOriginal.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(55)))), ((int)(((byte)(55)))));
         this.txbOriginal.BorderStyle = System.Windows.Forms.BorderStyle.None;
         this.txbOriginal.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(222)))), ((int)(((byte)(222)))));
         this.txbOriginal.Location = new System.Drawing.Point(12, 170);
         this.txbOriginal.Name = "txbOriginal";
         this.txbOriginal.Size = new System.Drawing.Size(355, 122);
         this.txbOriginal.TabIndex = 2;
         this.txbOriginal.Text = "";
         // 
         // txbFinal
         // 
         this.txbFinal.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(55)))), ((int)(((byte)(55)))));
         this.txbFinal.BorderStyle = System.Windows.Forms.BorderStyle.None;
         this.txbFinal.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(222)))), ((int)(((byte)(222)))));
         this.txbFinal.Location = new System.Drawing.Point(12, 311);
         this.txbFinal.Name = "txbFinal";
         this.txbFinal.Size = new System.Drawing.Size(355, 122);
         this.txbFinal.TabIndex = 4;
         this.txbFinal.Text = "";
         // 
         // btnReplace
         // 
         this.btnReplace.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(55)))), ((int)(((byte)(55)))));
         this.btnReplace.FlatAppearance.BorderSize = 0;
         this.btnReplace.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
         this.btnReplace.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(222)))), ((int)(((byte)(222)))));
         this.btnReplace.Location = new System.Drawing.Point(292, 25);
         this.btnReplace.Name = "btnReplace";
         this.btnReplace.Size = new System.Drawing.Size(75, 23);
         this.btnReplace.TabIndex = 3;
         this.btnReplace.Text = "Replace";
         this.btnReplace.UseVisualStyleBackColor = false;
         this.btnReplace.Click += new System.EventHandler(this.BtnReplace_Click);
         // 
         // label1
         // 
         this.label1.AutoSize = true;
         this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(222)))), ((int)(((byte)(222)))));
         this.label1.Location = new System.Drawing.Point(12, 9);
         this.label1.Name = "label1";
         this.label1.Size = new System.Drawing.Size(41, 13);
         this.label1.TabIndex = 5;
         this.label1.Text = "Search";
         // 
         // label2
         // 
         this.label2.AutoSize = true;
         this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(222)))), ((int)(((byte)(222)))));
         this.label2.Location = new System.Drawing.Point(12, 83);
         this.label2.Name = "label2";
         this.label2.Size = new System.Drawing.Size(47, 13);
         this.label2.TabIndex = 6;
         this.label2.Text = "Replace";
         // 
         // label3
         // 
         this.label3.AutoSize = true;
         this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(222)))), ((int)(((byte)(222)))));
         this.label3.Location = new System.Drawing.Point(12, 154);
         this.label3.Name = "label3";
         this.label3.Size = new System.Drawing.Size(42, 13);
         this.label3.TabIndex = 7;
         this.label3.Text = "Original";
         // 
         // label4
         // 
         this.label4.AutoSize = true;
         this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(222)))), ((int)(((byte)(222)))));
         this.label4.Location = new System.Drawing.Point(12, 295);
         this.label4.Name = "label4";
         this.label4.Size = new System.Drawing.Size(29, 13);
         this.label4.TabIndex = 8;
         this.label4.Text = "Final";
         // 
         // ReplaceText
         // 
         this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
         this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
         this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
         this.ClientSize = new System.Drawing.Size(379, 448);
         this.Controls.Add(this.label4);
         this.Controls.Add(this.label3);
         this.Controls.Add(this.label2);
         this.Controls.Add(this.label1);
         this.Controls.Add(this.btnReplace);
         this.Controls.Add(this.txbFinal);
         this.Controls.Add(this.txbOriginal);
         this.Controls.Add(this.txbReplace);
         this.Controls.Add(this.txbSearch);
         this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
         this.MaximizeBox = false;
         this.Name = "ReplaceText";
         this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
         this.Text = "ReplaceText";
         this.ResumeLayout(false);
         this.PerformLayout();

      }

      #endregion

      private System.Windows.Forms.RichTextBox txbSearch;
      private System.Windows.Forms.RichTextBox txbReplace;
      private System.Windows.Forms.RichTextBox txbOriginal;
      private System.Windows.Forms.RichTextBox txbFinal;
      private System.Windows.Forms.Button btnReplace;
      private System.Windows.Forms.Label label1;
      private System.Windows.Forms.Label label2;
      private System.Windows.Forms.Label label3;
      private System.Windows.Forms.Label label4;
   }
}

