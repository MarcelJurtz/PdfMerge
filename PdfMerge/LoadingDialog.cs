using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PdfMerge
{
    public partial class LoadingDialog : Form
    {
        public Action Worker;
        private object v;

        public LoadingDialog(Action worker)
        {
            InitializeComponent();

            if (worker == null)
                throw new ArgumentException();

            Worker = worker;

        }

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);

            Task.Factory.StartNew(Worker).ContinueWith(t => { this.Close(); }, TaskScheduler.FromCurrentSynchronizationContext());
        }
    }
}
