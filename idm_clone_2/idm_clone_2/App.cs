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
    }
}
