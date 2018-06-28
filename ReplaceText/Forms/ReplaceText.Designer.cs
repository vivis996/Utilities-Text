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
         this.components = new System.ComponentModel.Container();
         System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ReplaceText));
         this.txbOriginal = new FastColoredTextBoxNS.FastColoredTextBox();
         this.btnReplace = new System.Windows.Forms.Button();
         this.label3 = new System.Windows.Forms.Label();
         this.panel1 = new System.Windows.Forms.Panel();
         this.panel4 = new System.Windows.Forms.Panel();
         this.label1 = new System.Windows.Forms.Label();
         this.txbFinal = new FastColoredTextBoxNS.FastColoredTextBox();
         this.scText = new System.Windows.Forms.SplitContainer();
         this.scTextTools = new System.Windows.Forms.SplitContainer();
         this.panel5 = new System.Windows.Forms.Panel();
         this.label2 = new System.Windows.Forms.Label();
         this.txbSearch = new FastColoredTextBoxNS.FastColoredTextBox();
         this.panel6 = new System.Windows.Forms.Panel();
         this.label4 = new System.Windows.Forms.Label();
         this.txbReplace = new FastColoredTextBoxNS.FastColoredTextBox();
         this.tlpPrincipal = new System.Windows.Forms.TableLayoutPanel();
         this.panel2 = new System.Windows.Forms.Panel();
         ((System.ComponentModel.ISupportInitialize)(this.txbOriginal)).BeginInit();
         this.panel1.SuspendLayout();
         this.panel4.SuspendLayout();
         ((System.ComponentModel.ISupportInitialize)(this.txbFinal)).BeginInit();
         ((System.ComponentModel.ISupportInitialize)(this.scText)).BeginInit();
         this.scText.Panel1.SuspendLayout();
         this.scText.Panel2.SuspendLayout();
         this.scText.SuspendLayout();
         ((System.ComponentModel.ISupportInitialize)(this.scTextTools)).BeginInit();
         this.scTextTools.Panel1.SuspendLayout();
         this.scTextTools.Panel2.SuspendLayout();
         this.scTextTools.SuspendLayout();
         this.panel5.SuspendLayout();
         ((System.ComponentModel.ISupportInitialize)(this.txbSearch)).BeginInit();
         this.panel6.SuspendLayout();
         ((System.ComponentModel.ISupportInitialize)(this.txbReplace)).BeginInit();
         this.tlpPrincipal.SuspendLayout();
         this.panel2.SuspendLayout();
         this.SuspendLayout();
         // 
         // txbOriginal
         // 
         this.txbOriginal.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
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
         this.txbOriginal.Font = new System.Drawing.Font("Consolas", 8.25F);
         this.txbOriginal.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(222)))), ((int)(((byte)(222)))));
         this.txbOriginal.IndentBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
         this.txbOriginal.IsReplaceMode = false;
         this.txbOriginal.LineNumberColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
         this.txbOriginal.Location = new System.Drawing.Point(0, 16);
         this.txbOriginal.Name = "txbOriginal";
         this.txbOriginal.Paddings = new System.Windows.Forms.Padding(0);
         this.txbOriginal.SelectionColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
         this.txbOriginal.Size = new System.Drawing.Size(565, 136);
         this.txbOriginal.TabIndex = 9;
         this.txbOriginal.TextAreaBorderColor = System.Drawing.Color.Transparent;
         this.txbOriginal.Zoom = 100;
         // 
         // btnReplace
         // 
         this.btnReplace.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
         this.btnReplace.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(55)))), ((int)(((byte)(55)))));
         this.btnReplace.FlatAppearance.BorderSize = 0;
         this.btnReplace.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
         this.btnReplace.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(222)))), ((int)(((byte)(222)))));
         this.btnReplace.Location = new System.Drawing.Point(486, 8);
         this.btnReplace.Name = "btnReplace";
         this.btnReplace.Size = new System.Drawing.Size(75, 23);
         this.btnReplace.TabIndex = 3;
         this.btnReplace.Text = "Replace";
         this.btnReplace.UseVisualStyleBackColor = false;
         this.btnReplace.Click += new System.EventHandler(this.BtnReplace_Click);
         // 
         // label3
         // 
         this.label3.AutoSize = true;
         this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(222)))), ((int)(((byte)(222)))));
         this.label3.Location = new System.Drawing.Point(3, 0);
         this.label3.Name = "label3";
         this.label3.Size = new System.Drawing.Size(42, 13);
         this.label3.TabIndex = 7;
         this.label3.Text = "Original";
         // 
         // panel1
         // 
         this.panel1.Controls.Add(this.label3);
         this.panel1.Controls.Add(this.txbOriginal);
         this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
         this.panel1.Location = new System.Drawing.Point(0, 0);
         this.panel1.Name = "panel1";
         this.panel1.Size = new System.Drawing.Size(564, 156);
         this.panel1.TabIndex = 13;
         // 
         // panel4
         // 
         this.panel4.Controls.Add(this.label1);
         this.panel4.Controls.Add(this.txbFinal);
         this.panel4.Dock = System.Windows.Forms.DockStyle.Fill;
         this.panel4.Location = new System.Drawing.Point(0, 0);
         this.panel4.Name = "panel4";
         this.panel4.Size = new System.Drawing.Size(564, 158);
         this.panel4.TabIndex = 14;
         // 
         // label1
         // 
         this.label1.AutoSize = true;
         this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(222)))), ((int)(((byte)(222)))));
         this.label1.Location = new System.Drawing.Point(3, 0);
         this.label1.Name = "label1";
         this.label1.Size = new System.Drawing.Size(29, 13);
         this.label1.TabIndex = 7;
         this.label1.Text = "Final";
         // 
         // txbFinal
         // 
         this.txbFinal.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
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
         this.txbFinal.Location = new System.Drawing.Point(0, 16);
         this.txbFinal.Name = "txbFinal";
         this.txbFinal.Paddings = new System.Windows.Forms.Padding(0);
         this.txbFinal.SelectionColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
         this.txbFinal.Size = new System.Drawing.Size(565, 139);
         this.txbFinal.TabIndex = 9;
         this.txbFinal.TextAreaBorderColor = System.Drawing.Color.Transparent;
         this.txbFinal.Zoom = 100;
         // 
         // scText
         // 
         this.scText.Dock = System.Windows.Forms.DockStyle.Fill;
         this.scText.Location = new System.Drawing.Point(3, 193);
         this.scText.Name = "scText";
         this.scText.Orientation = System.Windows.Forms.Orientation.Horizontal;
         // 
         // scText.Panel1
         // 
         this.scText.Panel1.Controls.Add(this.panel1);
         // 
         // scText.Panel2
         // 
         this.scText.Panel2.Controls.Add(this.panel4);
         this.scText.Size = new System.Drawing.Size(564, 315);
         this.scText.SplitterDistance = 156;
         this.scText.SplitterWidth = 1;
         this.scText.TabIndex = 15;
         // 
         // scTextTools
         // 
         this.scTextTools.Dock = System.Windows.Forms.DockStyle.Fill;
         this.scTextTools.Location = new System.Drawing.Point(3, 3);
         this.scTextTools.Name = "scTextTools";
         this.scTextTools.Orientation = System.Windows.Forms.Orientation.Horizontal;
         // 
         // scTextTools.Panel1
         // 
         this.scTextTools.Panel1.Controls.Add(this.panel5);
         // 
         // scTextTools.Panel2
         // 
         this.scTextTools.Panel2.Controls.Add(this.panel6);
         this.scTextTools.Size = new System.Drawing.Size(564, 144);
         this.scTextTools.SplitterDistance = 70;
         this.scTextTools.SplitterWidth = 1;
         this.scTextTools.TabIndex = 16;
         // 
         // panel5
         // 
         this.panel5.Controls.Add(this.label2);
         this.panel5.Controls.Add(this.txbSearch);
         this.panel5.Dock = System.Windows.Forms.DockStyle.Fill;
         this.panel5.Location = new System.Drawing.Point(0, 0);
         this.panel5.Name = "panel5";
         this.panel5.Size = new System.Drawing.Size(564, 70);
         this.panel5.TabIndex = 13;
         // 
         // label2
         // 
         this.label2.AutoSize = true;
         this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(222)))), ((int)(((byte)(222)))));
         this.label2.Location = new System.Drawing.Point(3, 0);
         this.label2.Name = "label2";
         this.label2.Size = new System.Drawing.Size(41, 13);
         this.label2.TabIndex = 7;
         this.label2.Text = "Search";
         // 
         // txbSearch
         // 
         this.txbSearch.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
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
         this.txbSearch.Location = new System.Drawing.Point(0, 16);
         this.txbSearch.Name = "txbSearch";
         this.txbSearch.Paddings = new System.Windows.Forms.Padding(0);
         this.txbSearch.SelectionColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
         this.txbSearch.Size = new System.Drawing.Size(565, 62);
         this.txbSearch.TabIndex = 9;
         this.txbSearch.TextAreaBorderColor = System.Drawing.Color.Transparent;
         this.txbSearch.Zoom = 100;
         // 
         // panel6
         // 
         this.panel6.Controls.Add(this.label4);
         this.panel6.Controls.Add(this.txbReplace);
         this.panel6.Dock = System.Windows.Forms.DockStyle.Fill;
         this.panel6.Location = new System.Drawing.Point(0, 0);
         this.panel6.Name = "panel6";
         this.panel6.Size = new System.Drawing.Size(564, 73);
         this.panel6.TabIndex = 14;
         // 
         // label4
         // 
         this.label4.AutoSize = true;
         this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(222)))), ((int)(((byte)(222)))));
         this.label4.Location = new System.Drawing.Point(3, 0);
         this.label4.Name = "label4";
         this.label4.Size = new System.Drawing.Size(47, 13);
         this.label4.TabIndex = 7;
         this.label4.Text = "Replace";
         // 
         // txbReplace
         // 
         this.txbReplace.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
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
         this.txbReplace.Location = new System.Drawing.Point(0, 16);
         this.txbReplace.Name = "txbReplace";
         this.txbReplace.Paddings = new System.Windows.Forms.Padding(0);
         this.txbReplace.SelectionColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
         this.txbReplace.Size = new System.Drawing.Size(565, 54);
         this.txbReplace.TabIndex = 9;
         this.txbReplace.TextAreaBorderColor = System.Drawing.Color.Transparent;
         this.txbReplace.Zoom = 100;
         // 
         // tlpPrincipal
         // 
         this.tlpPrincipal.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
         this.tlpPrincipal.ColumnCount = 1;
         this.tlpPrincipal.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
         this.tlpPrincipal.Controls.Add(this.panel2, 0, 1);
         this.tlpPrincipal.Controls.Add(this.scTextTools, 0, 0);
         this.tlpPrincipal.Controls.Add(this.scText, 0, 2);
         this.tlpPrincipal.Location = new System.Drawing.Point(12, 12);
         this.tlpPrincipal.Name = "tlpPrincipal";
         this.tlpPrincipal.RowCount = 3;
         this.tlpPrincipal.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 150F));
         this.tlpPrincipal.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
         this.tlpPrincipal.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 61F));
         this.tlpPrincipal.Size = new System.Drawing.Size(570, 511);
         this.tlpPrincipal.TabIndex = 17;
         // 
         // panel2
         // 
         this.panel2.Controls.Add(this.btnReplace);
         this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
         this.panel2.Location = new System.Drawing.Point(3, 153);
         this.panel2.Name = "panel2";
         this.panel2.Size = new System.Drawing.Size(564, 34);
         this.panel2.TabIndex = 10;
         // 
         // ReplaceText
         // 
         this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
         this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
         this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
         this.ClientSize = new System.Drawing.Size(594, 535);
         this.Controls.Add(this.tlpPrincipal);
         this.MinimumSize = new System.Drawing.Size(610, 573);
         this.Name = "ReplaceText";
         this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
         this.Text = "ReplaceText";
         ((System.ComponentModel.ISupportInitialize)(this.txbOriginal)).EndInit();
         this.panel1.ResumeLayout(false);
         this.panel1.PerformLayout();
         this.panel4.ResumeLayout(false);
         this.panel4.PerformLayout();
         ((System.ComponentModel.ISupportInitialize)(this.txbFinal)).EndInit();
         this.scText.Panel1.ResumeLayout(false);
         this.scText.Panel2.ResumeLayout(false);
         ((System.ComponentModel.ISupportInitialize)(this.scText)).EndInit();
         this.scText.ResumeLayout(false);
         this.scTextTools.Panel1.ResumeLayout(false);
         this.scTextTools.Panel2.ResumeLayout(false);
         ((System.ComponentModel.ISupportInitialize)(this.scTextTools)).EndInit();
         this.scTextTools.ResumeLayout(false);
         this.panel5.ResumeLayout(false);
         this.panel5.PerformLayout();
         ((System.ComponentModel.ISupportInitialize)(this.txbSearch)).EndInit();
         this.panel6.ResumeLayout(false);
         this.panel6.PerformLayout();
         ((System.ComponentModel.ISupportInitialize)(this.txbReplace)).EndInit();
         this.tlpPrincipal.ResumeLayout(false);
         this.panel2.ResumeLayout(false);
         this.ResumeLayout(false);

      }

      #endregion
      private System.Windows.Forms.Button btnReplace;
      private System.Windows.Forms.Label label3;
      private FastColoredTextBoxNS.FastColoredTextBox txbOriginal;
      private System.Windows.Forms.Panel panel1;
      private System.Windows.Forms.Panel panel4;
      private System.Windows.Forms.Label label1;
      private FastColoredTextBoxNS.FastColoredTextBox txbFinal;
      private System.Windows.Forms.SplitContainer scText;
      private System.Windows.Forms.SplitContainer scTextTools;
      private System.Windows.Forms.Panel panel5;
      private System.Windows.Forms.Label label2;
      private FastColoredTextBoxNS.FastColoredTextBox txbSearch;
      private System.Windows.Forms.Panel panel6;
      private System.Windows.Forms.Label label4;
      private FastColoredTextBoxNS.FastColoredTextBox txbReplace;
      private System.Windows.Forms.TableLayoutPanel tlpPrincipal;
      private System.Windows.Forms.Panel panel2;
   }
}

