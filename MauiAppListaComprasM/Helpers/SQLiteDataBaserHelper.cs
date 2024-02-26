using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MauiAppListaComprasM.Models;
using SQLite;

namespace MauiAppListaComprasM.Helpers
{
    public class SQLiteDataBaserHelper
    {
        readonly SQLiteAsyncConnection _conn;
    
        public SQLiteAsyncConnection(string path)
        {
            _conn = new SQLiteAsyncConnection(path);
            _conn.CreateTableAsync<Produto>().Wait();
        }
    
        public Task<int> insert(Produto p)
        {
            return _conn.InsertAsync(p);
        }
    
    
    
    
    }


}
