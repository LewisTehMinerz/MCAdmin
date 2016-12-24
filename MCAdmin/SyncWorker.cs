using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MCAdmin
{
    class SyncWorker
    {
        public static void syncWorker_DoWork()
        {
            frmSync sync = new frmSync();
            HttpClient client = new HttpClient();
            Action show = new Action(() => sync.Show());
            Action hide = new Action(() => sync.Hide());
            try
            {
                while (true)
                {
                    if (sync.InvokeRequired)
                    {
                        sync.Invoke(show);
                    } else
                    {
                        sync.Show();
                    }
                    client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
                    Application.DoEvents();
                    var content = new StringContent("test", Encoding.UTF8, "application/json");
                    bool clientFinished = false;
                    client.PostAsync("http://localhost:14580", content).ContinueWith(t => clientFinished = true);
                    while (!clientFinished)
                    {
                        sync.Invalidate();
                        sync.Update();
                    }
                    if (sync.InvokeRequired)
                    {
                        sync.Invoke(hide);
                    }
                    else
                    {
                        sync.Hide();
                    }
                }

            }
            catch (ThreadAbortException e)
            {
                sync = null;
                client = null;
                show = null;
                hide = null;
                GC.Collect();
            }
            catch (Exception ex)
            {
                MessageBox.Show("MCAdmin could not sync to server.", "MCAdmin", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Console.WriteLine(ex.Message);
            }
            Thread.Sleep(120000);
        }
    }
}
