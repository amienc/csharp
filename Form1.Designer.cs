namespace WinForms_MasterDetail
    {
    partial class Form1
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
            components = new System.ComponentModel.Container();
            masterBindingSource = new BindingSource(components);
            detailsBindingSource = new BindingSource(components);
            splitContainer1 = new SplitContainer();
            masterDataGridView = new DataGridView();
            detailsDataGridView = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)masterBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)detailsBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)splitContainer1).BeginInit();
            splitContainer1.Panel1.SuspendLayout();
            splitContainer1.Panel2.SuspendLayout();
            splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)masterDataGridView).BeginInit();
            ((System.ComponentModel.ISupportInitialize)detailsDataGridView).BeginInit();
            SuspendLayout();
            // 
            // splitContainer1
            // 
            splitContainer1.Dock = DockStyle.Fill;
            splitContainer1.Location = new Point(0, 0);
            splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            splitContainer1.Panel1.Controls.Add(masterDataGridView);
            // 
            // splitContainer1.Panel2
            // 
            splitContainer1.Panel2.Controls.Add(detailsDataGridView);
            splitContainer1.Size = new Size(1074, 554);
            splitContainer1.SplitterDistance = 357;
            splitContainer1.TabIndex = 2;
            // 
            // masterDataGridView
            // 
            masterDataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            masterDataGridView.Dock = DockStyle.Fill;
            masterDataGridView.Location = new Point(0, 0);
            masterDataGridView.Name = "masterDataGridView";
            masterDataGridView.RowTemplate.Height = 25;
            masterDataGridView.Size = new Size(357, 554);
            masterDataGridView.TabIndex = 1;
            // 
            // detailsDataGridView
            // 
            detailsDataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            detailsDataGridView.Dock = DockStyle.Fill;
            detailsDataGridView.Location = new Point(0, 0);
            detailsDataGridView.Name = "detailsDataGridView";
            detailsDataGridView.RowTemplate.Height = 25;
            detailsDataGridView.Size = new Size(713, 554);
            detailsDataGridView.TabIndex = 2;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1074, 554);
            Controls.Add(splitContainer1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)masterBindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)detailsBindingSource).EndInit();
            splitContainer1.Panel1.ResumeLayout(false);
            splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)splitContainer1).EndInit();
            splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)masterDataGridView).EndInit();
            ((System.ComponentModel.ISupportInitialize)detailsDataGridView).EndInit();
            ResumeLayout(false);
            }

        #endregion
        private BindingSource masterBindingSource;
        private BindingSource detailsBindingSource;
        private SplitContainer splitContainer1;
        private DataGridView masterDataGridView;
        private DataGridView detailsDataGridView;
        }
    }