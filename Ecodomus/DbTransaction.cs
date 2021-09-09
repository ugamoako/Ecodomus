using System;
using System.Collections.Generic;

namespace Ecodomus
{
    public class DbTransaction
    {
        private readonly Stack<DbOperation> _databaseTransactions;

        public DbTransaction()
        {
            _databaseTransactions = new Stack<DbOperation>();

        }

        public DbOperation Begin(DbOperation database)
        {
            _databaseTransactions.Push(database);
            return new DbOperation(database);
        }

        public DbOperation Commit(DbOperation database)
        {
            _databaseTransactions.Clear();
            _databaseTransactions.Push(database);
            return new DbOperation(database);
        }

        public DbOperation RollBack(DbOperation database)
        {
            if (_databaseTransactions.Count == 0)
            {
                Console.WriteLine("No transaction");
                return database;
            }
            else
            {
                DbOperation lastTransation = _databaseTransactions.Pop();
                return lastTransation;
            }
        }
    
    }
}
