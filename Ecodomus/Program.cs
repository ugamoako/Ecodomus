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
            /*var db = new Database();
             db.Begin();
             db.Set("a", 50);
             db.Get("a");
             db.Begin();
             db.Set("a", 60);
             db.Get("a");
             db.RollBack();
             db.Get("a");
             db.RollBack();
             db.Get("a");*/

            /*Example III*/
            /*var db = new Database();
            db.Begin();
            db.Set("a", 40);
            db.Begin();
            db.Set("a", 50);
            db.Commit();
            db.Get("a");
            db.RollBack();*/

            /*Example IV*/
            /*var db = new Database();
            db.Set("a", 50);
            db.Begin();
            db.Get("a");
            db.Set("a", 70);
            db.Begin();
            db.Set("b", 90);
            db.Get("b");
            db.Delete("a");
            db.Get("a");
            db.RollBack();
            db.Get("a");
            db.Commit();
            db.Get("a");
            db.Get("b");*/

            /*Example V*/
            /*var db = new Database();
            db.Set("a", 20);
            db.Begin();
            db.Count(20);
            db.Begin();
            db.Delete("a");
            db.Count(20);
            db.RollBack();
            db.Set("b", 20);
            db.Count(20);
            db.Commit();
            db.Count(20);*/
            
            /*var db = new Database();
            db.Begin();
            db.Set("a", 50);
            db.Begin();
            db.Set("a", 50);
            db.RollBack();
            db.RollBack();
            db.RollBack();*/

            /*var db = new Database();
            db.RollBack();*/
        }
    }
}
