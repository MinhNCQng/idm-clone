using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AltoHttp;

namespace idm_clone_2
{
    public class DownloadControllCommand : BaseCommand
    {
        HttpDownloader httpDownloader;
        public void execute(string s)
        {
            switch (s)
            {
                case "Pause":
                    httpDownloader.Pause();
                    break;
                case "Resume":
                    httpDownloader.Resume();
                    break;
                case "Start":
                    httpDownloader.Start();
                    break; 
            }
        }

        public DownloadControllCommand(HttpDownloader httpDownloader)
        {
            this.httpDownloader = httpDownloader;
        }
        
    }
}
