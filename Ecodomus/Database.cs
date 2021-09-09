using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ecodomus
{
    public class Database
    {

        private DbOperation _database = new();
        private readonly DbTransaction _transaction = new();

        public Database()
        {}

        public void Get(string key)
        {
            _database.Get(key);
        }

        public void Set(string key, int value)
        {
            _database.Set(key, value);
        }

        public void Delete(string key)
        {
            _database.Delete(key);
        }

        public void Count(int val)
        {
            _database.Count(val);
        }

        public void Begin()
        {
            _database = _transaction.Begin(_database);
        }

        public void Commit()
        {
            _database = _transaction.Commit(_database);
        }

        public void RollBack()
        {
            _database = _transaction.RollBack(_database);
        }
    }
}
