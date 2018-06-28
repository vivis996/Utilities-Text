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
         this.txbSearch = new FastColoredTextBoxNS.FastColoredTextBox();
         this.txbReplace = new FastColoredTextBoxNS.FastColoredTextBox();
         this.txbOriginal = new FastColoredTextBoxNS.FastColoredTextBox();
         this.txbFinal = new FastColoredTextBoxNS.FastColoredTextBox();
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
         // txbOriginal
         // 
         this.txbOriginal.AutoCompleteBracketsList = new char[] {
        '(',
        ')',
        '{',
        '}',
        '[',
        ']',
        '\"',
        '\"',
        '\'',
        '\''};
         this.txbOriginal.AutoScrollMinSize = new System.Drawing.Size(23, 12);
         this.txbOriginal.BackBrush = null;
         this.txbOriginal.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(55)))), ((int)(((byte)(55)))));
         this.txbOriginal.CharHeight = 12;
         this.txbOriginal.CharWidth = 6;
         this.txbOriginal.Cursor = System.Windows.Forms.Cursors.IBeam;
         this.txbOriginal.DisabledColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(180)))), ((int)(((byte)(180)))), ((int)(((byte)(180)))));
         this.txbOriginal.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.txbOriginal.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(222)))), ((int)(((byte)(222)))));
         this.txbOriginal.IndentBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
         this.txbOriginal.IsReplaceMode = false;
         this.txbOriginal.LineNumberColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
         this.txbOriginal.Location = new System.Drawing.Point(12, 170);
         this.txbOriginal.Name = "txbOriginal";
         this.txbOriginal.Paddings = new System.Windows.Forms.Padding(0);
         this.txbOriginal.SelectionColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
         this.txbOriginal.Size = new System.Drawing.Size(355, 122);
         this.txbOriginal.TabIndex = 9;
         this.txbOriginal.TextAreaBorderColor = System.Drawing.Color.Transparent;
         this.txbOriginal.Zoom = 100;
         // 
         // txbFinal
         // 
         this.txbFinal.AutoCompleteBracketsList = new char[] {
        '(',
        ')',
        '{',
        '}',
        '[',
        ']',
        '\"',
        '\"',
        '\'',
        '\''};
         this.txbFinal.AutoScrollMinSize = new System.Drawing.Size(23, 12);
         this.txbFinal.BackBrush = null;
         this.txbFinal.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(55)))), ((int)(((byte)(55)))));
         this.txbFinal.CharHeight = 12;
         this.txbFinal.CharWidth = 6;
         this.txbFinal.Cursor = System.Windows.Forms.Cursors.IBeam;
         this.txbFinal.DisabledColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(180)))), ((int)(((byte)(180)))), ((int)(((byte)(180)))));
         this.txbFinal.Font = new System.Drawing.Font("Consolas", 8.25F);
         this.txbFinal.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(222)))), ((int)(((byte)(222)))));
         this.txbFinal.IndentBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
         this.txbFinal.IsReplaceMode = false;
         this.txbFinal.LineNumberColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
         this.txbFinal.Location = new System.Drawing.Point(12, 311);
         this.txbFinal.Name = "txbFinal";
         this.txbFinal.Paddings = new System.Windows.Forms.Padding(0);
         this.txbFinal.SelectionColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
         this.txbFinal.Size = new System.Drawing.Size(355, 125);
         this.txbFinal.TabIndex = 10;
         this.txbFinal.TextAreaBorderColor = System.Drawing.Color.Transparent;
         this.txbFinal.Zoom = 100;
         // 
         // txbReplace
         // 
         this.txbReplace.AutoCompleteBracketsList = new char[] {
        '(',
        ')',
        '{',
        '}',
        '[',
        ']',
        '\"',
        '\"',
        '\'',
        '\''};
         this.txbReplace.AutoScrollMinSize = new System.Drawing.Size(23, 12);
         this.txbReplace.BackBrush = null;
         this.txbReplace.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(55)))), ((int)(((byte)(55)))));
         this.txbReplace.CharHeight = 12;
         this.txbReplace.CharWidth = 6;
         this.txbReplace.Cursor = System.Windows.Forms.Cursors.IBeam;
         this.txbReplace.DisabledColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(180)))), ((int)(((byte)(180)))), ((int)(((byte)(180)))));
         this.txbReplace.Font = new System.Drawing.Font("Consolas", 8.25F);
         this.txbReplace.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(222)))), ((int)(((byte)(222)))));
         this.txbReplace.IndentBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
         this.txbReplace.IsReplaceMode = false;
         this.txbReplace.LineNumberColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
         this.txbReplace.Location = new System.Drawing.Point(12, 99);
         this.txbReplace.Name = "txbReplace";
         this.txbReplace.Paddings = new System.Windows.Forms.Padding(0);
         this.txbReplace.SelectionColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
         this.txbReplace.Size = new System.Drawing.Size(355, 52);
         this.txbReplace.TabIndex = 11;
         this.txbReplace.TextAreaBorderColor = System.Drawing.Color.Transparent;
         this.txbReplace.Zoom = 100;
         // 
         // txbSearch
         // 
         this.txbSearch.AutoCompleteBracketsList = new char[] {
        '(',
        ')',
        '{',
        '}',
        '[',
        ']',
        '\"',
        '\"',
        '\'',
        '\''};
         this.txbSearch.AutoScrollMinSize = new System.Drawing.Size(23, 12);
         this.txbSearch.BackBrush = null;
         this.txbSearch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(55)))), ((int)(((byte)(55)))));
         this.txbSearch.CharHeight = 12;
         this.txbSearch.CharWidth = 6;
         this.txbSearch.Cursor = System.Windows.Forms.Cursors.IBeam;
         this.txbSearch.DisabledColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(180)))), ((int)(((byte)(180)))), ((int)(((byte)(180)))));
         this.txbSearch.Font = new System.Drawing.Font("Consolas", 8.25F);
         this.txbSearch.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(222)))), ((int)(((byte)(222)))));
         this.txbSearch.IndentBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
         this.txbSearch.IsReplaceMode = false;
         this.txbSearch.LineNumberColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
         this.txbSearch.Location = new System.Drawing.Point(12, 25);
         this.txbSearch.Name = "txbSearch";
         this.txbSearch.Paddings = new System.Windows.Forms.Padding(0);
         this.txbSearch.SelectionColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
         this.txbSearch.Size = new System.Drawing.Size(274, 55);
         this.txbSearch.TabIndex = 12;
         this.txbSearch.TextAreaBorderColor = System.Drawing.Color.Transparent;
         this.txbSearch.Zoom = 100;
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
         ((System.ComponentModel.ISupportInitialize)(this.txbOriginal)).EndInit();
         ((System.ComponentModel.ISupportInitialize)(this.txbFinal)).EndInit();
         ((System.ComponentModel.ISupportInitialize)(this.txbReplace)).EndInit();
         ((System.ComponentModel.ISupportInitialize)(this.txbSearch)).EndInit();
         this.ResumeLayout(false);
         this.PerformLayout();

      }

      #endregion
      private System.Windows.Forms.Button btnReplace;
      private System.Windows.Forms.Label label1;
      private System.Windows.Forms.Label label2;
      private System.Windows.Forms.Label label3;
      private System.Windows.Forms.Label label4;
      private FastColoredTextBoxNS.FastColoredTextBox txbOriginal;
      private FastColoredTextBoxNS.FastColoredTextBox txbFinal;
      private FastColoredTextBoxNS.FastColoredTextBox txbReplace;
      private FastColoredTextBoxNS.FastColoredTextBox txbSearch;
   }
}

