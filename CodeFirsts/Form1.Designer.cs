namespace CodeFirsts
{
    partial class frmManageCategories
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            label2 = new Label();
            TxtCategoryId = new TextBox();
            TxtCategoryName = new TextBox();
            dvgCategories = new DataGridView();
            BtnInsert = new Button();
            BtnUpdate = new Button();
            BtnDelete = new Button();
            ((System.ComponentModel.ISupportInitialize)dvgCategories).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(128, 81);
            label1.Name = "label1";
            label1.Size = new Size(102, 25);
            label1.TabIndex = 0;
            label1.Text = "CategoryID";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(128, 129);
            label2.Name = "label2";
            label2.Size = new Size(131, 25);
            label2.TabIndex = 1;
            label2.Text = "CategoryName";
            // 
            // TxtCategoryId
            // 
            TxtCategoryId.Location = new Point(295, 78);
            TxtCategoryId.Name = "TxtCategoryId";
            TxtCategoryId.ReadOnly = true;
            TxtCategoryId.Size = new Size(348, 31);
            TxtCategoryId.TabIndex = 2;
            // 
            // TxtCategoryName
            // 
            TxtCategoryName.Location = new Point(295, 129);
            TxtCategoryName.Name = "TxtCategoryName";
            TxtCategoryName.Size = new Size(348, 31);
            TxtCategoryName.TabIndex = 3;
            // 
            // dvgCategories
            // 
            dvgCategories.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dvgCategories.Location = new Point(128, 179);
            dvgCategories.Name = "dvgCategories";
            dvgCategories.ReadOnly = true;
            dvgCategories.RowHeadersWidth = 62;
            dvgCategories.RowTemplate.Height = 33;
            dvgCategories.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dvgCategories.Size = new Size(515, 167);
            dvgCategories.TabIndex = 4;
            // 
            // BtnInsert
            // 
            BtnInsert.Location = new Point(128, 370);
            BtnInsert.Name = "BtnInsert";
            BtnInsert.Size = new Size(112, 34);
            BtnInsert.TabIndex = 5;
            BtnInsert.Text = "Insert";
            BtnInsert.UseVisualStyleBackColor = true;
            BtnInsert.Click += BtnInsert_Click;
            // 
            // BtnUpdate
            // 
            BtnUpdate.Location = new Point(328, 370);
            BtnUpdate.Name = "BtnUpdate";
            BtnUpdate.Size = new Size(112, 34);
            BtnUpdate.TabIndex = 6;
            BtnUpdate.Text = "Update";
            BtnUpdate.UseVisualStyleBackColor = true;
            BtnUpdate.Click += BtnUpdate_Click;
            // 
            // BtnDelete
            // 
            BtnDelete.Location = new Point(531, 370);
            BtnDelete.Name = "BtnDelete";
            BtnDelete.Size = new Size(112, 34);
            BtnDelete.TabIndex = 7;
            BtnDelete.Text = "Delete";
            BtnDelete.UseVisualStyleBackColor = true;
            BtnDelete.Click += BtnDelete_Click;
            // 
            // frmManageCategories
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(BtnDelete);
            Controls.Add(BtnUpdate);
            Controls.Add(BtnInsert);
            Controls.Add(dvgCategories);
            Controls.Add(TxtCategoryName);
            Controls.Add(TxtCategoryId);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "frmManageCategories";
            Text = "Form1";
            Load += frmManageCategories_Load;
            ((System.ComponentModel.ISupportInitialize)dvgCategories).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox TxtCategoryId;
        private TextBox TxtCategoryName;
        private DataGridView dvgCategories;
        private Button BtnInsert;
        private Button BtnUpdate;
        private Button BtnDelete;
    }
}