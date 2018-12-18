using System;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PdfMerge.Forms
{
    public partial class ExportProgressDialog : Form
    {
        public Action Worker;

        public ExportProgressDialog(Action worker)
        {
            InitializeComponent();
            Worker = worker ?? throw new ArgumentException();
        }

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            Task.Factory.StartNew(Worker).ContinueWith(t => { this.Close(); }, TaskScheduler.FromCurrentSynchronizationContext());
        }
    }
}
