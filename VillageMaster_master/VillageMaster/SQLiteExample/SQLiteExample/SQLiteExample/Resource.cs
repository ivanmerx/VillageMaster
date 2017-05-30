using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SQLite;

namespace SQLiteExample
{
    class Resource
    {
        [PrimaryKey, AutoIncrement]
        public int ID { get; set; }
        public int ID_Question { get; set; }
        public string Name { get; set; }
        //kolik to prida bodu, neni zatim reseno ubirani
        public string Points { get; set; }

        public Resource()
        {

        }
    }
}
