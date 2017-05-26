using SQLite;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace SQLiteExample
{
  public  class TodoItemDatabase
    {
        private SQLiteAsyncConnection database;

        public TodoItemDatabase(string dbPath)
        {
            database = new SQLiteAsyncConnection(dbPath);
            database.CreateTableAsync<Question>().Wait();
        }


        public Task<List<Question>> GetItemsAsync()
        {
            return database.Table<Question>().ToListAsync();
        }

        public Task<List<Question>> GetItemsNotDoneAsync()
        {
            return database.QueryAsync<Question>("SELECT * FROM [TodoItem] WHERE [Done] = 0");
        }

        public Task<Question> GetItemAsync(int id)
        {
            return database.Table<Question>().Where(i => i.ID == id).FirstOrDefaultAsync();
        }

        public Task<int> SaveItemAsync(Question item)
        {
            if (item.ID != 0)
            {
                return database.UpdateAsync(item);
            }
            else
            {
                return database.InsertAsync(item);
            }
        }

        public Task<int> DeleteItemAsync(Question item)
        {
            return database.DeleteAsync(item);
        }
    }
}
