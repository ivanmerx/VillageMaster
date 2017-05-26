using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SQLite;

namespace SQLiteExample
{
  public  class Question
    {
        [PrimaryKey, AutoIncrement]
        public int ID { get; set; }
        public string Type { get; set; }
        public string Text { get; set; }

        public Question()
        {
        }
    }
}
