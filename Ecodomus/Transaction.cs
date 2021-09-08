using System;
using System.Collections.Generic;

namespace Ecodomus
{
    public class Transaction
    {
        private readonly Stack<Database> _databaseTransactions;

        public Transaction()
        {
            _databaseTransactions = new Stack<Database>();

        }

        public Database Begin(Database database)
        {
            _databaseTransactions.Push(database);
            return new Database(database);
        }

        public Database Commit(Database database)
        {
            _databaseTransactions.Clear();
            _databaseTransactions.Push(database);
            return new Database(database);
        }

        public Database RollBack(Database database)
        {
            if (_databaseTransactions.Count == 0)
            {
                Console.WriteLine("No transaction");
                return database;
            }
            else
            {
                Database lastTransation = _databaseTransactions.Pop();
                if (lastTransation.Equals(database))
                {
                    Console.WriteLine("No transaction");
                    _databaseTransactions.Push(database);
                }
                return lastTransation;
            }
        }
    }
}
