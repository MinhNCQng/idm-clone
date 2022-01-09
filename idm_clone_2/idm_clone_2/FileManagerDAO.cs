using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace idm_clone_2
{
    public class FileManagerDAO : BaseDAO<File>
    {
        public void add(File t)
        {
            Database.FilesRow row = App.DB.Files.NewFilesRow();
            row.Url = t.Url;
            row.FileName = t.FileName;
            row.FileSize = (string.Format("{0:0.##} KB", t.FileSize / 1024));
            row.DateTime = t.dateTime;
            App.DB.Files.AddFilesRow(row);
            App.DB.AcceptChanges();
            App.DB.WriteXml(string.Format("{0}/data.dat", Application.StartupPath));
            t.Id = row.Id;
            
        }

        public void delete(int index)
        {
            App.DB.Files.Rows[index].Delete();
            App.DB.AcceptChanges();
            App.DB.WriteXml(string.Format("{0}/data.dat", Application.StartupPath));
        }
    }
}
