using System;

namespace Ecodomus
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Example I*/
            /*var db = new Database();
            db.Set("a", 50);
            db.Get("a");
            db.Delete("a");
            db.Get("a");*/


            /*Example II*/
           /* var db = new Database();
            var transaction = new Transaction();
            db = transaction.Begin(db);
            db.Set("a", 50);
            db.Get("a");
            db = transaction.Begin(db);
            db.Set("a", 60);
            db.Get("a");
            db = transaction.RollBack(db);
            db.Get("a");
            db = transaction.RollBack(db);
            db.Get("a");*/

            /*Example III*/
             /*var db = new Database();
             var transaction = new Transaction();
             db = transaction.Begin(db);
             db.Set("a", 40);
             db = transaction.Begin(db);
             db.Set("a", 50);
             db = transaction.Commit(db);
             db.Get("a");
             transaction.RollBack(db);*/

            /*Example IV*/
            /*var db = new Database();
            var transaction = new Transaction();

            db.Set("a", 50);
            db = transaction.Begin(db);
            db.Get("a");
            db.Set("a", 70);
            db = transaction.Begin(db);
            db.Set("b", 90);
            db.Delete("a");
            db.Get("a");
            db = transaction.RollBack(db);
            db.Get("a");
            db = transaction.Commit(db);
            db.Get("a");
            db.Get("b");*/

        }
    }
}
