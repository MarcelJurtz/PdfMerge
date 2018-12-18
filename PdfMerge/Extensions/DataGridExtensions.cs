using System.Windows.Forms;

namespace PdfMerge.Extensions
{
    public static class DataGridExtensions
    {
        public static T SelectedOrDefault<T>(this DataGridView gridView) where T : class
        {
            if (gridView.SelectedRows.Count == 0)
                return null;

            T item = gridView.SelectedRows[0].DataBoundItem as T;

            return null;
        }
    }
}
