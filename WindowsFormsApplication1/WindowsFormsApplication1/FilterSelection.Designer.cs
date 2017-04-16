namespace WindowsFormsApplication1
{
    partial class FilterSelection
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
            this.helpProvider1 = new System.Windows.Forms.HelpProvider();
            this.cmbbxCountry = new System.Windows.Forms.ComboBox();
            this.cmbbxCategory = new System.Windows.Forms.ComboBox();
            this.cmbbxSubCategory = new System.Windows.Forms.ComboBox();
            this.chkbxlsCountry = new System.Windows.Forms.CheckedListBox();
            this.chkbxlsCategory = new System.Windows.Forms.CheckedListBox();
            this.chkbxlsSubCategory = new System.Windows.Forms.CheckedListBox();
            this.SuspendLayout();
            // 
            // cmbbxCountry
            // 
            this.cmbbxCountry.BackColor = System.Drawing.SystemColors.Window;
            this.cmbbxCountry.FormattingEnabled = true;
            this.cmbbxCountry.Location = new System.Drawing.Point(12, 41);
            this.cmbbxCountry.MaxDropDownItems = 1;
            this.cmbbxCountry.Name = "cmbbxCountry";
            this.cmbbxCountry.Size = new System.Drawing.Size(121, 21);
            this.cmbbxCountry.TabIndex = 0;
            this.cmbbxCountry.SelectedIndexChanged += new System.EventHandler(this.cmbbxCountry_SelectedIndexChanged);
            // 
            // cmbbxCategory
            // 
            this.cmbbxCategory.FormattingEnabled = true;
            this.cmbbxCategory.Location = new System.Drawing.Point(245, 41);
            this.cmbbxCategory.Name = "cmbbxCategory";
            this.cmbbxCategory.Size = new System.Drawing.Size(121, 21);
            this.cmbbxCategory.TabIndex = 1;
            // 
            // cmbbxSubCategory
            // 
            this.cmbbxSubCategory.FormattingEnabled = true;
            this.cmbbxSubCategory.Location = new System.Drawing.Point(553, 50);
            this.cmbbxSubCategory.Name = "cmbbxSubCategory";
            this.cmbbxSubCategory.Size = new System.Drawing.Size(121, 21);
            this.cmbbxSubCategory.TabIndex = 2;
            // 
            // chkbxlsCountry
            // 
            this.chkbxlsCountry.FormattingEnabled = true;
            this.chkbxlsCountry.Location = new System.Drawing.Point(12, 61);
            this.chkbxlsCountry.Name = "chkbxlsCountry";
            this.chkbxlsCountry.Size = new System.Drawing.Size(121, 94);
            this.chkbxlsCountry.TabIndex = 3;
            this.chkbxlsCountry.SelectedIndexChanged += new System.EventHandler(this.chkbxlsCountry_SelectedIndexChanged);
            // 
            // chkbxlsCategory
            // 
            this.chkbxlsCategory.FormattingEnabled = true;
            this.chkbxlsCategory.Location = new System.Drawing.Point(245, 61);
            this.chkbxlsCategory.Name = "chkbxlsCategory";
            this.chkbxlsCategory.Size = new System.Drawing.Size(121, 94);
            this.chkbxlsCategory.TabIndex = 4;
            this.chkbxlsCategory.SelectedIndexChanged += new System.EventHandler(this.chkbxlsCategory_SelectedIndexChanged);
            // 
            // chkbxlsSubCategory
            // 
            this.chkbxlsSubCategory.FormattingEnabled = true;
            this.chkbxlsSubCategory.Location = new System.Drawing.Point(553, 70);
            this.chkbxlsSubCategory.Name = "chkbxlsSubCategory";
            this.chkbxlsSubCategory.Size = new System.Drawing.Size(121, 94);
            this.chkbxlsSubCategory.TabIndex = 5;
            // 
            // FilterSelection
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(734, 261);
            this.Controls.Add(this.chkbxlsSubCategory);
            this.Controls.Add(this.chkbxlsCategory);
            this.Controls.Add(this.chkbxlsCountry);
            this.Controls.Add(this.cmbbxSubCategory);
            this.Controls.Add(this.cmbbxCategory);
            this.Controls.Add(this.cmbbxCountry);
            this.Name = "FilterSelection";
            this.Text = "FilterSelection";
            this.Load += new System.EventHandler(this.FilterSelection_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.HelpProvider helpProvider1;
        private System.Windows.Forms.ComboBox cmbbxCountry;
        private System.Windows.Forms.ComboBox cmbbxCategory;
        private System.Windows.Forms.ComboBox cmbbxSubCategory;
        private System.Windows.Forms.CheckedListBox chkbxlsCountry;
        private System.Windows.Forms.CheckedListBox chkbxlsCategory;
        private System.Windows.Forms.CheckedListBox chkbxlsSubCategory;
    }
}