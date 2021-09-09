using System;
using System.Collections.Generic;
using System.Linq;

namespace Ecodomus
{
    public class DbOperation
    {
        private Dictionary<string, int> _data { get; set; }

        public DbOperation()
        {
            _data = new Dictionary<string, int>();
        }

        public DbOperation(DbOperation database)
        {
            _data = new Dictionary<string, int>(database._data);
        }

        public void Set(string key, int value)
        {
            _data[key] = value;
        }

        public void Get(string key)
        {
            var valExist = _data.TryGetValue(key, out int val);
            Console.WriteLine(valExist ? val  : "Null");
        }

        public void Delete(string key)
        {
            if(_data.ContainsKey(key))
                _data.Remove(key);
        }

        public void Count(int value)
        {
            Console.WriteLine(_data.Count( x => x.Value == value ));
        }
    }
}
