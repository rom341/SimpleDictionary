namespace SimpleDictionary
{
    partial class fMain
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.dgvDictionaryTable = new System.Windows.Forms.DataGridView();
            this.tblpUpperTools = new System.Windows.Forms.TableLayoutPanel();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnAddColumn = new System.Windows.Forms.Button();
            this.tbColumnName = new System.Windows.Forms.TextBox();
            this.tblpDownTools = new System.Windows.Forms.TableLayoutPanel();
            this.btnSelectFile = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.label1 = new System.Windows.Forms.Label();
            this.tblpAddColumn = new System.Windows.Forms.TableLayoutPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDictionaryTable)).BeginInit();
            this.tblpUpperTools.SuspendLayout();
            this.tblpDownTools.SuspendLayout();
            this.tblpAddColumn.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.AutoScroll = true;
            this.splitContainer1.Panel1.Controls.Add(this.dgvDictionaryTable);
            this.splitContainer1.Panel1.Controls.Add(this.tblpUpperTools);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.tblpDownTools);
            this.splitContainer1.Size = new System.Drawing.Size(800, 450);
            this.splitContainer1.SplitterDistance = 407;
            this.splitContainer1.TabIndex = 0;
            // 
            // dgvDictionaryTable
            // 
            this.dgvDictionaryTable.AllowUserToOrderColumns = true;
            this.dgvDictionaryTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDictionaryTable.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvDictionaryTable.Location = new System.Drawing.Point(0, 55);
            this.dgvDictionaryTable.Name = "dgvDictionaryTable";
            this.dgvDictionaryTable.RowHeadersWidth = 51;
            this.dgvDictionaryTable.RowTemplate.Height = 24;
            this.dgvDictionaryTable.Size = new System.Drawing.Size(800, 352);
            this.dgvDictionaryTable.TabIndex = 1;
            // 
            // tblpUpperTools
            // 
            this.tblpUpperTools.ColumnCount = 3;
            this.tblpUpperTools.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tblpUpperTools.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tblpUpperTools.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tblpUpperTools.Controls.Add(this.btnSave, 2, 0);
            this.tblpUpperTools.Controls.Add(this.tblpAddColumn, 0, 0);
            this.tblpUpperTools.Dock = System.Windows.Forms.DockStyle.Top;
            this.tblpUpperTools.Location = new System.Drawing.Point(0, 0);
            this.tblpUpperTools.Name = "tblpUpperTools";
            this.tblpUpperTools.RowCount = 1;
            this.tblpUpperTools.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tblpUpperTools.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tblpUpperTools.Size = new System.Drawing.Size(800, 55);
            this.tblpUpperTools.TabIndex = 5;
            // 
            // btnSave
            // 
            this.btnSave.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnSave.Location = new System.Drawing.Point(535, 3);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(262, 49);
            this.btnSave.TabIndex = 4;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnAddColumn
            // 
            this.btnAddColumn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnAddColumn.Location = new System.Drawing.Point(3, 3);
            this.btnAddColumn.Name = "btnAddColumn";
            this.btnAddColumn.Size = new System.Drawing.Size(124, 43);
            this.btnAddColumn.TabIndex = 2;
            this.btnAddColumn.Text = "Add column";
            this.btnAddColumn.UseVisualStyleBackColor = true;
            this.btnAddColumn.Click += new System.EventHandler(this.btnAddColumn_Click);
            // 
            // tbColumnName
            // 
            this.tbColumnName.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.tbColumnName.Location = new System.Drawing.Point(0, 21);
            this.tbColumnName.Name = "tbColumnName";
            this.tbColumnName.Size = new System.Drawing.Size(123, 22);
            this.tbColumnName.TabIndex = 3;
            // 
            // tblpDownTools
            // 
            this.tblpDownTools.ColumnCount = 3;
            this.tblpDownTools.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 40F));
            this.tblpDownTools.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tblpDownTools.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 40F));
            this.tblpDownTools.Controls.Add(this.btnSelectFile, 1, 0);
            this.tblpDownTools.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tblpDownTools.Location = new System.Drawing.Point(0, 0);
            this.tblpDownTools.Name = "tblpDownTools";
            this.tblpDownTools.RowCount = 1;
            this.tblpDownTools.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tblpDownTools.Size = new System.Drawing.Size(800, 39);
            this.tblpDownTools.TabIndex = 1;
            // 
            // btnSelectFile
            // 
            this.btnSelectFile.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnSelectFile.Location = new System.Drawing.Point(323, 3);
            this.btnSelectFile.Name = "btnSelectFile";
            this.btnSelectFile.Size = new System.Drawing.Size(154, 33);
            this.btnSelectFile.TabIndex = 0;
            this.btnSelectFile.Text = "Select file";
            this.btnSelectFile.UseVisualStyleBackColor = true;
            this.btnSelectFile.Click += new System.EventHandler(this.btnSelectFile_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            this.openFileDialog1.RestoreDirectory = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 16);
            this.label1.TabIndex = 4;
            this.label1.Text = "Column name";
            // 
            // tblpAddColumn
            // 
            this.tblpAddColumn.ColumnCount = 2;
            this.tblpAddColumn.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tblpAddColumn.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tblpAddColumn.Controls.Add(this.btnAddColumn, 0, 0);
            this.tblpAddColumn.Controls.Add(this.panel1, 1, 0);
            this.tblpAddColumn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tblpAddColumn.Location = new System.Drawing.Point(3, 3);
            this.tblpAddColumn.Name = "tblpAddColumn";
            this.tblpAddColumn.RowCount = 1;
            this.tblpAddColumn.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tblpAddColumn.Size = new System.Drawing.Size(260, 49);
            this.tblpAddColumn.TabIndex = 5;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.tbColumnName);
            this.panel1.Location = new System.Drawing.Point(133, 3);
            this.panel1.MinimumSize = new System.Drawing.Size(0, 40);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(123, 43);
            this.panel1.TabIndex = 6;
            // 
            // fMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.splitContainer1);
            this.Name = "fMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Simple dictionary";
            this.Load += new System.EventHandler(this.fMain_Load);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDictionaryTable)).EndInit();
            this.tblpUpperTools.ResumeLayout(false);
            this.tblpDownTools.ResumeLayout(false);
            this.tblpAddColumn.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Button btnSelectFile;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.DataGridView dgvDictionaryTable;
        private System.Windows.Forms.Button btnAddColumn;
        private System.Windows.Forms.TextBox tbColumnName;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.TableLayoutPanel tblpUpperTools;
        private System.Windows.Forms.TableLayoutPanel tblpDownTools;
        private System.Windows.Forms.TableLayoutPanel tblpAddColumn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
    }
}

