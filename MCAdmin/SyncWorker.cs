using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MCAdmin
{
    class SyncWorker
    {
        public static async void syncWorker_DoWork(object sender, DoWorkEventArgs e)
        {
            try
            {
                frmSync sync = new frmSync();
                HttpClient client = new HttpClient();
                frmMain refer = new frmMain();
                while (true)
                {
                    refer.Invoke((Action)delegate {
                        sync.Show();
                    });
                    client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
                    
                    var content = new StringContent("test", Encoding.UTF8, "application/json");
                    await client.PostAsync("http://localhost:14580", content);
                    refer.Invoke((Action)delegate {
                        sync.Hide();
                    });
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("MCAdmin could not sync to server.", "MCAdmin", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
