using PdfMerge.Extensions;
using PdfMerge.Models;
using PdfMerge.ViewModels;
using System;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace PdfMerge
{
    public partial class Form1 : Form
    {
        private readonly ViewModel ViewModel;
        private string exportFilePath;

        #region Constants

        private const string PDF_FILTER = "Pdf Files|*.pdf";

        private const string EXPORT_DIALOG_CAPTION = "Completed";
        private const string EXPORT_DIALOG_CONTENT = "Open target directory in explorer?";

        private const string EXPORT_ERROR_CAPTION = "Error";
        private const string EXPORT_ERROR_CONTENT = "File already exists";

        #endregion Constants


        public Form1()
        {
            InitializeComponent();

            ViewModel = new ViewModel();

            // Setup Dialogs
            ofdChapters.Filter = PDF_FILTER;
            ofdChapters.Multiselect = true;

            exportDialog.Filter = PDF_FILTER;

            cmdUp.Click += (sender, e) =>
            {
                ViewModel.SwapPositions(dataGridView.SelectedOrDefault<Chapter>(), -1);
                dataGridView.Refresh();
            };

            cmdDown.Click += (sender, e) =>
            {
                ViewModel.SwapPositions(dataGridView.SelectedOrDefault<Chapter>(), 1);
                dataGridView.Refresh();
            };
        }

        private void cmdAdd_Click(object sender, EventArgs e)
        {
            if (ofdChapters.ShowDialog() == DialogResult.OK)
            {
                ViewModel.AddChaptersByFileName(ofdChapters.FileNames);
                bsFiles.DataSource = ViewModel.Chapters;
            }
        }

        private void cmdMerge_Click(object sender, EventArgs e)
        {
            if (exportDialog.ShowDialog() == DialogResult.OK)
            {
                exportFilePath = exportDialog.FileName;
                if (!File.Exists(exportDialog.FileName))
                {
                    this.Enabled = false;

                    using (var progressForm = new LoadingDialog(Export))
                    {
                        progressForm.ShowDialog();
                    }

                    this.Enabled = true;
                }
                else
                    MessageBox.Show(EXPORT_ERROR_CONTENT, EXPORT_ERROR_CAPTION, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            //if (MessageBox.Show(EXPORT_DIALOG_CONTENT, EXPORT_DIALOG_CAPTION, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            //    Process.Start(Path.GetDirectoryName(exportDialog.FileName));
        }

        private void Export()
        {
            ViewModel.Export(exportFilePath);
        }

        private void cmdRemove_Click(object sender, EventArgs e)
        {
            Chapter chapter = dataGridView.SelectedOrDefault<Chapter>();

            if (chapter != null)
            {
                ViewModel.Chapters.Remove(chapter);
                dataGridView.Refresh();
            }
        }

        private void dataGridView_SelectionChanged(object sender, EventArgs e)
        {
            if (ViewModel.Chapters == null)
                return;

            if (dataGridView.SelectedRows.Count == 0)
            {
                cmdUp.Enabled = false;
                cmdUp.Enabled = false;
                return;
            }

            var chapter = dataGridView.SelectedOrDefault<Chapter>();

            cmdRemove.Enabled = chapter != null;
            cmdUp.Enabled = chapter?.Position != 1;
            cmdDown.Enabled = chapter?.Position != ViewModel.Chapters.Max(c => c.Position);
        }

        private void cmdClose_Click(object sender, EventArgs e)
        {
            ViewModel.Reset();
            bsFiles.DataSource = ViewModel.Chapters;
        }
    }
}
