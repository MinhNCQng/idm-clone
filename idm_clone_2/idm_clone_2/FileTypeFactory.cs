using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace idm_clone_2
{
    class FileTypeFactory
    {
        FilePathTemplate filePath;
        public void findFileType(string fileExtension)
        {
            string[] imageExt = { ".gif", ".jpg", ".jpeg", ".jpe", ".bmp", ".png" };
            string[] videoExt = { ".mp4", ".mov", ".wmv", ".avi", ".flv", ".mkv" };
            string[] audioExt = { ".m4a", ".mp3", ".flac", ".wav", ".wma", ".aac" };
            string[] documentExt = { ".pdf", ".docx", ".xlsx", ".pptx", ".txt" };
            string[] compressedExt = { ".zip", ".rar", ".gzip", ".tar", ".7z" };


            filePath = new DefaultPath();

            foreach (string ele in imageExt)
            {
                if (fileExtension == ele)
                {
                    filePath = new ImagePath();
                }
            }
            foreach (string ele in videoExt)
            {
                if (fileExtension == ele)
                {
                    filePath = new VideoPath();
                }
            }
            foreach (string ele in audioExt)
            {
                if (fileExtension == ele)
                {
                    filePath = new AudioPath();
                }
            }
            foreach (string ele in documentExt)
            {
                if (fileExtension == ele)
                {
                    filePath = new DocumentPath();
                }
            }
            foreach (string ele in compressedExt)
            {
                if (fileExtension == ele)
                {
                    filePath = new CompressedPath();
                }
            }

            
        }

        public String getFilePath()
        {
            return filePath.getPath() ;
        }
    }
}
