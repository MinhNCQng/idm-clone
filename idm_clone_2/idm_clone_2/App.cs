using System;
using System.Collections.Generic;
using System.Text;

namespace idm_clone_2
{
    static class App
    {
        static Database db;
        public static Database DB
        {
            get {
                if (db == null) db = new Database();
                return db;
                }
        }

        static FileManagerDAO fileManager;

        public static FileManagerDAO FileManager
        {
            get
            {
                if (fileManager == null) fileManager = new FileManagerDAO();
                return fileManager;
            }
        }
    }
}
