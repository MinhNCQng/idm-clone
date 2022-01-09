using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AltoHttp;
namespace idm_clone_2
{
    public class DownloadControllCommandAdvanced:BaseCommand
    {
        DownloadControllCommand _downloadController;

        Button btnStart;
        Button btnResume;
        Button btnPause;
        public DownloadControllCommandAdvanced(HttpDownloader httpDownloader, Button btnStart, Button btnResume, Button btnPause)
        {

            this._downloadController = new DownloadControllCommand(httpDownloader);
            this.btnStart = btnStart;
            this.btnResume = btnResume;
            this.btnPause = btnPause;
        }



        public void execute(string s)
        {
            _downloadController.execute(s);
            setEnableButton(s);

        }
        public void setEnableButton(string s)
        {
            switch (s)
            {
                case "Start":
                    btnStart.Enabled = false;
                    btnPause.Enabled = true;
                    btnResume.Enabled = false;
                    break;
                case "Pause":
                    btnStart.Enabled = false;
                    btnPause.Enabled = false;
                    btnResume.Enabled = true;
                    break;
                case "Resume":
                    btnStart.Enabled = false;
                    btnPause.Enabled = true;
                    btnResume.Enabled = false;
                    break;
                
            }
        }
    }
}
