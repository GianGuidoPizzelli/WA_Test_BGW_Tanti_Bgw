using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WA_Test_BGW_Tanti_Bgw
{
    public partial class Form1 : Form
    {
        BackgroundWorker bgw1,bgw2;
        public Form1()
        {
            InitializeComponent();
        }

        private void btAvvio2_Click(object sender, EventArgs e)
        {
            bgw1 = new BackgroundWorker();
            bgw1.WorkerReportsProgress = true;
            bgw1.WorkerSupportsCancellation = true;
            bgw1.DoWork += Bgw_DoWork;
            bgw1.ProgressChanged += Bgw_ProgressChanged;
            bgw1.RunWorkerCompleted += Bgw_RunWorkerCompleted;

            bgw2 = new BackgroundWorker();
            bgw2.WorkerReportsProgress = true;
            bgw2.WorkerSupportsCancellation = true;
            bgw2.DoWork += Bgw_DoWork;
            bgw2.ProgressChanged += Bgw_ProgressChanged;
            bgw2.RunWorkerCompleted += Bgw_RunWorkerCompleted;

            bgw1.RunWorkerAsync(tbAvvio2);
            bgw2.RunWorkerAsync(tbAvvio2);
        }

        //var (completed, resultList) = (bool, TextBox)e.Result;
        //var tupla = (ValueTuple<bool, TextBox>)e.Result;
        private void Bgw_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            var (completato, tb) = (ValueTuple<bool, TextBox>)e.Result;
            tb.Text = completato ? "Concluso" + Environment.NewLine + tb.Text : 
                "Cancellato" + Environment.NewLine + tb.Text;
        }

        private void Bgw_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            TextBox tb = e.UserState as TextBox;
            tb.Text = e.ProgressPercentage+Environment.NewLine + tb.Text;
        }

        private void Bgw_DoWork(object sender, DoWorkEventArgs e)
        {
            BackgroundWorker bgw = sender as BackgroundWorker;
            TextBox tb = e.Argument as TextBox;
            for (int i = 0; i < 10; i++)
            {
                Thread.Sleep(100);
                bgw.ReportProgress(i,tb);
                if (bgw.CancellationPending)
                {
                    e.Result = (false, tb);
                    return;
                }
            }

            e.Result = (true, tb);
        }
        // Deve essere accessibile globalmente
        List<BackgroundWorker> bgw_list = new List<BackgroundWorker>();
        private void btAvvio100_Click(object sender, EventArgs e)
        {

            for (int i = 0; i < 100; i++)
            {
                BackgroundWorker bgw1 = new BackgroundWorker();
                bgw1.WorkerReportsProgress = true;
                bgw1.WorkerSupportsCancellation = true;
                bgw1.DoWork += Bgw_DoWork;
                bgw1.ProgressChanged += Bgw_ProgressChanged;
                bgw1.RunWorkerCompleted += Bgw_RunWorkerCompleted;
                bgw_list.Add(bgw1);
            }

            foreach (var bgw in bgw_list)
            {
                bgw.RunWorkerAsync(tbAvvia100);
            }
        }

        //private void btStop100_Click(object sender, EventArgs e)
        //{
        //    foreach (var bgw in bgw_list)
        //    {
        //        bgw.CancelAsync();
        //    }
        //}

        private void btStop2_Click(object sender, EventArgs e)
        {
            bgw1.CancelAsync();
            bgw2.CancelAsync();
        }
    }
}
