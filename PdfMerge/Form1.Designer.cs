namespace PdfMerge
{
    partial class Form1
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.ofdChapters = new System.Windows.Forms.OpenFileDialog();
            this.exportDialog = new System.Windows.Forms.SaveFileDialog();
            this.cmdRemove = new System.Windows.Forms.Button();
            this.positionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fileNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pathDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bsFiles = new System.Windows.Forms.BindingSource(this.components);
            this.cmdMerge = new System.Windows.Forms.Button();
            this.cmdDown = new System.Windows.Forms.Button();
            this.cmdUp = new System.Windows.Forms.Button();
            this.cmdAdd = new System.Windows.Forms.Button();
            this.cmdClose = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsFiles)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView
            // 
            this.dataGridView.AllowUserToAddRows = false;
            this.dataGridView.AllowUserToDeleteRows = false;
            this.dataGridView.AutoGenerateColumns = false;
            this.dataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.positionDataGridViewTextBoxColumn,
            this.fileNameDataGridViewTextBoxColumn,
            this.pathDataGridViewTextBoxColumn});
            this.dataGridView.DataSource = this.bsFiles;
            this.dataGridView.Location = new System.Drawing.Point(12, 73);
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.ReadOnly = true;
            this.dataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView.Size = new System.Drawing.Size(647, 227);
            this.dataGridView.TabIndex = 4;
            this.dataGridView.SelectionChanged += new System.EventHandler(this.dataGridView_SelectionChanged);
            // 
            // ofdChapters
            // 
            this.ofdChapters.FileName = "openFileDialog1";
            // 
            // cmdRemove
            // 
            this.cmdRemove.BackgroundImage = global::PdfMerge.Properties.Resources.minus;
            this.cmdRemove.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.cmdRemove.FlatAppearance.BorderSize = 0;
            this.cmdRemove.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmdRemove.Location = new System.Drawing.Point(73, 12);
            this.cmdRemove.Name = "cmdRemove";
            this.cmdRemove.Size = new System.Drawing.Size(54, 54);
            this.cmdRemove.TabIndex = 5;
            this.cmdRemove.UseVisualStyleBackColor = true;
            this.cmdRemove.Click += new System.EventHandler(this.cmdRemove_Click);
            // 
            // positionDataGridViewTextBoxColumn
            // 
            this.positionDataGridViewTextBoxColumn.DataPropertyName = "Position";
            this.positionDataGridViewTextBoxColumn.FillWeight = 53.29949F;
            this.positionDataGridViewTextBoxColumn.HeaderText = "Position";
            this.positionDataGridViewTextBoxColumn.Name = "positionDataGridViewTextBoxColumn";
            this.positionDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // fileNameDataGridViewTextBoxColumn
            // 
            this.fileNameDataGridViewTextBoxColumn.DataPropertyName = "FileName";
            this.fileNameDataGridViewTextBoxColumn.FillWeight = 123.3503F;
            this.fileNameDataGridViewTextBoxColumn.HeaderText = "FileName";
            this.fileNameDataGridViewTextBoxColumn.Name = "fileNameDataGridViewTextBoxColumn";
            this.fileNameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // pathDataGridViewTextBoxColumn
            // 
            this.pathDataGridViewTextBoxColumn.DataPropertyName = "Path";
            this.pathDataGridViewTextBoxColumn.FillWeight = 123.3503F;
            this.pathDataGridViewTextBoxColumn.HeaderText = "Path";
            this.pathDataGridViewTextBoxColumn.Name = "pathDataGridViewTextBoxColumn";
            this.pathDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // bsFiles
            // 
            this.bsFiles.DataSource = typeof(PdfMerge.Models.Chapter);
            // 
            // cmdMerge
            // 
            this.cmdMerge.BackgroundImage = global::PdfMerge.Properties.Resources.save;
            this.cmdMerge.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.cmdMerge.FlatAppearance.BorderSize = 0;
            this.cmdMerge.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmdMerge.Location = new System.Drawing.Point(253, 12);
            this.cmdMerge.Name = "cmdMerge";
            this.cmdMerge.Size = new System.Drawing.Size(54, 54);
            this.cmdMerge.TabIndex = 3;
            this.cmdMerge.UseVisualStyleBackColor = true;
            this.cmdMerge.Click += new System.EventHandler(this.cmdMerge_Click);
            // 
            // cmdDown
            // 
            this.cmdDown.BackgroundImage = global::PdfMerge.Properties.Resources.down;
            this.cmdDown.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.cmdDown.FlatAppearance.BorderSize = 0;
            this.cmdDown.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmdDown.Location = new System.Drawing.Point(193, 12);
            this.cmdDown.Name = "cmdDown";
            this.cmdDown.Size = new System.Drawing.Size(54, 54);
            this.cmdDown.TabIndex = 2;
            this.cmdDown.UseVisualStyleBackColor = true;
            // 
            // cmdUp
            // 
            this.cmdUp.BackgroundImage = global::PdfMerge.Properties.Resources.up;
            this.cmdUp.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.cmdUp.FlatAppearance.BorderSize = 0;
            this.cmdUp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmdUp.Location = new System.Drawing.Point(133, 12);
            this.cmdUp.Name = "cmdUp";
            this.cmdUp.Size = new System.Drawing.Size(54, 54);
            this.cmdUp.TabIndex = 1;
            this.cmdUp.UseVisualStyleBackColor = true;
            // 
            // cmdAdd
            // 
            this.cmdAdd.BackgroundImage = global::PdfMerge.Properties.Resources.plus;
            this.cmdAdd.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.cmdAdd.FlatAppearance.BorderSize = 0;
            this.cmdAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmdAdd.Location = new System.Drawing.Point(13, 12);
            this.cmdAdd.Name = "cmdAdd";
            this.cmdAdd.Size = new System.Drawing.Size(54, 54);
            this.cmdAdd.TabIndex = 0;
            this.cmdAdd.UseVisualStyleBackColor = true;
            this.cmdAdd.Click += new System.EventHandler(this.cmdAdd_Click);
            // 
            // cmdClose
            // 
            this.cmdClose.BackgroundImage = global::PdfMerge.Properties.Resources.close;
            this.cmdClose.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.cmdClose.FlatAppearance.BorderSize = 0;
            this.cmdClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmdClose.Location = new System.Drawing.Point(313, 12);
            this.cmdClose.Name = "cmdClose";
            this.cmdClose.Size = new System.Drawing.Size(54, 54);
            this.cmdClose.TabIndex = 6;
            this.cmdClose.UseVisualStyleBackColor = true;
            this.cmdClose.Click += new System.EventHandler(this.cmdClose_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(671, 312);
            this.Controls.Add(this.cmdClose);
            this.Controls.Add(this.cmdRemove);
            this.Controls.Add(this.dataGridView);
            this.Controls.Add(this.cmdMerge);
            this.Controls.Add(this.cmdDown);
            this.Controls.Add(this.cmdUp);
            this.Controls.Add(this.cmdAdd);
            this.Name = "Form1";
            this.Text = "PDFMerge";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsFiles)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button cmdAdd;
        private System.Windows.Forms.Button cmdUp;
        private System.Windows.Forms.Button cmdDown;
        private System.Windows.Forms.Button cmdMerge;
        private System.Windows.Forms.DataGridView dataGridView;
        private System.Windows.Forms.BindingSource bsFiles;
        private System.Windows.Forms.OpenFileDialog ofdChapters;
        private System.Windows.Forms.SaveFileDialog exportDialog;
        private System.Windows.Forms.DataGridViewTextBoxColumn positionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fileNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pathDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button cmdRemove;
        private System.Windows.Forms.Button cmdClose;
    }
}

