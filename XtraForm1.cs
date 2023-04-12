using DevExpress.ClipboardSource.SpreadsheetML;
using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace WinPruebas
{
    public partial class XtraForm1 : DevExpress.XtraEditors.XtraForm
    {
        private string fe_start;
        public XtraForm1()
        {
            InitializeComponent();
        }

        private void XtraForm1_Load(object sender, EventArgs e)
        {

        }

        private void bttstart_Click(object sender, EventArgs e)
        {
            fe_start = "run";
            memoEdit1.Text = "start\r\n";
            // Reset the text in the result label.
            //resultLabel.Text = String.Empty;

            // Disable the UpDown control until
            // the asynchronous operation is done.
            //this.numericUpDown1.Enabled = false;

            // Disable the Start button until
            // the asynchronous operation is done.
            //this.startAsyncButton.Enabled = false;

            // Enable the Cancel button while
            // the asynchronous operation runs.
            //this.cancelAsyncButton.Enabled = true;

            // Get the value from the UpDown control.
            //numberToCompute = (int)numericUpDown1.Value;

            // Reset the variable for percentage tracking.
            //highestPercentageReached = 0;

            // Start the asynchronous operation.
            if (backgroundWorker1.IsBusy != true)
                backgroundWorker1.RunWorkerAsync();
            //backgroundWorker1.RunWorkerAsync(numberToCompute);

        }

        private void bttstop_Click(object sender, EventArgs e)
        {
            fe_start = "stop";
            // Cancel the asynchronous operation.
            if (backgroundWorker1.WorkerSupportsCancellation == true)
                this.backgroundWorker1.CancelAsync();

            // Disable the Cancel button.
            //cancelAsyncButton.Enabled = false;
        }

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {
            ////e.Result = ejecutarFE();
            int fila = 0;
            //while (fe_start == "run")
            //{
            //    System.Threading.Thread.Sleep(5000);
            //    fila++;

            //    //richTextBox1.Text = fe_start + " " + fila.ToString();
            //    //memoEdit1.Text = fe_start + " " + fila.ToString();
            //    Console.WriteLine("Fila = " + fila);
            //    e.Result = fe_start + " " + fila.ToString();
            //}
            string texto = "Proceso = ";

            BackgroundWorker worker = sender as BackgroundWorker;

            while (fe_start == "run")
            {
                fila++;
                if (worker.CancellationPending == true)
                {
                    e.Cancel = true;
                    break;
                }
                else
                {
                    texto = VerificarConexionURL("https://cel.sri.gob.ec/comprobantes-electronicos-ws/RecepcionComprobantesOfflin?wsdl");
                    // Perform a time consuming operation and report progress.
                    //System.Threading.Thread.Sleep(500);
                    worker.ReportProgress(fila, texto);
                }
            }
        }

        private void backgroundWorker1_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            // First, handle the case where an exception was thrown.
            if (e.Error != null)
            {
                memoEdit1.Text += e.Error.Message;
            }
            else if (e.Cancelled)
            {
                // Next, handle the case where the user canceled
                // the operation.
                // Note that due to a race condition in
                // the DoWork event handler, the Cancelled
                // flag may not have been set, even though
                // CancelAsync was called.
                memoEdit1.Text += "Canceled";
            }
            else
            {
                // Finally, handle the case where the operation
                // succeeded.
                memoEdit1.Text += "Finalizado"; //e.Result.ToString();
            }
            memoEdit1.SelectionStart = memoEdit1.Text.Length;
            memoEdit1.MaskBox.MaskBoxScrollToCaret();

            //// Enable the UpDown control.
            //this.numericUpDown1.Enabled = true;

            //// Enable the Start button.
            //startAsyncButton.Enabled = true;

            //// Disable the Cancel button.
            //cancelAsyncButton.Enabled = false;
        }

        private void backgroundWorker1_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            string valor = (string)e.UserState;
            richTextBox1.Text += valor + (e.ProgressPercentage.ToString() + "%") + "\r\n";
            memoEdit1.Text += valor + (e.ProgressPercentage.ToString() + "%") + "\r\n";

            memoEdit1.SelectionStart = memoEdit1.Text.Length;
            memoEdit1.MaskBox.MaskBoxScrollToCaret();
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            int fila = 0;
            for(int i=0; i<10; i++)
            {
                System.Threading.Thread.Sleep(5000);
                fila++;

                Console.WriteLine("Fila = " + i);
            }
        }

        public string VerificarConexionURL(string mURL)
        {
            string resp = "";
            System.Net.WebRequest Peticion = default(System.Net.WebRequest);
            System.Net.HttpWebResponse Respuesta;// = default(System.Net.WebResponse);
            try
            {
                Peticion = System.Net.WebRequest.Create(mURL);
                Respuesta = (HttpWebResponse)Peticion.GetResponse();
                resp = "true";
            }
            catch (System.Net.WebException ex)
            {
                if (ex.Status == System.Net.WebExceptionStatus.NameResolutionFailure)
                {
                    //return false;
                    resp = ex.Status.ToString();
                }
                resp = ex.Message;
            }
            return resp;
        }
    }
}