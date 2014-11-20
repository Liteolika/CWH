namespace CWH.WinGui
{
    partial class Form1
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
            this.SearchText = new System.Windows.Forms.TextBox();
            this.SearchButton = new System.Windows.Forms.Button();
            this.SearchLabel = new System.Windows.Forms.Label();
            this.SearchPartial = new System.Windows.Forms.CheckBox();
            this.SearchType = new System.Windows.Forms.ComboBox();
            this.ResultGrid = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.ResultGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // SearchText
            // 
            this.SearchText.Location = new System.Drawing.Point(13, 36);
            this.SearchText.Name = "SearchText";
            this.SearchText.Size = new System.Drawing.Size(254, 20);
            this.SearchText.TabIndex = 0;
            // 
            // SearchButton
            // 
            this.SearchButton.Location = new System.Drawing.Point(273, 36);
            this.SearchButton.Name = "SearchButton";
            this.SearchButton.Size = new System.Drawing.Size(75, 20);
            this.SearchButton.TabIndex = 1;
            this.SearchButton.Text = "Search";
            this.SearchButton.UseVisualStyleBackColor = true;
            this.SearchButton.Click += new System.EventHandler(this.SearchButton_Click);
            // 
            // SearchLabel
            // 
            this.SearchLabel.AutoSize = true;
            this.SearchLabel.Location = new System.Drawing.Point(13, 17);
            this.SearchLabel.Name = "SearchLabel";
            this.SearchLabel.Size = new System.Drawing.Size(41, 13);
            this.SearchLabel.TabIndex = 2;
            this.SearchLabel.Text = "Search";
            // 
            // SearchPartial
            // 
            this.SearchPartial.AutoSize = true;
            this.SearchPartial.Location = new System.Drawing.Point(141, 64);
            this.SearchPartial.Name = "SearchPartial";
            this.SearchPartial.Size = new System.Drawing.Size(126, 17);
            this.SearchPartial.TabIndex = 3;
            this.SearchPartial.Text = "Search Partial Words";
            this.SearchPartial.UseVisualStyleBackColor = true;
            // 
            // SearchType
            // 
            this.SearchType.FormattingEnabled = true;
            this.SearchType.Location = new System.Drawing.Point(13, 62);
            this.SearchType.Name = "SearchType";
            this.SearchType.Size = new System.Drawing.Size(117, 21);
            this.SearchType.TabIndex = 4;
            // 
            // ResultGrid
            // 
            this.ResultGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ResultGrid.Location = new System.Drawing.Point(12, 137);
            this.ResultGrid.Name = "ResultGrid";
            this.ResultGrid.Size = new System.Drawing.Size(585, 242);
            this.ResultGrid.TabIndex = 5;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(609, 391);
            this.Controls.Add(this.ResultGrid);
            this.Controls.Add(this.SearchType);
            this.Controls.Add(this.SearchPartial);
            this.Controls.Add(this.SearchLabel);
            this.Controls.Add(this.SearchButton);
            this.Controls.Add(this.SearchText);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.ResultGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox SearchText;
        private System.Windows.Forms.Button SearchButton;
        private System.Windows.Forms.Label SearchLabel;
        private System.Windows.Forms.CheckBox SearchPartial;
        private System.Windows.Forms.ComboBox SearchType;
        private System.Windows.Forms.DataGridView ResultGrid;
    }
}

