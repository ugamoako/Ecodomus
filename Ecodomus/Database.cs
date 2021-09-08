using System;
using System.Collections.Generic;
using System.Linq;

namespace Ecodomus
{
    public class Database
    {
        private Dictionary<string, int> _data { get; set; }

        public Database()
        {
            _data = new Dictionary<string, int>();
        }

        public Database(Database database)
        {
            _data = new Dictionary<string, int>(database._data);
        }

        public void Set(string key, int value)
        {
            _data[key] = value;
        }

        public void Get(string key)
        {
            Console.WriteLine(_data.ContainsKey(key) ?  _data[key] : "Null");
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

        public bool Equals(Database database)
        {
            if (_data.Keys.Count == database._data.Keys.Count)
            {
                foreach (string variable in _data.Keys)
                {
                    if (database._data.ContainsKey(variable)
                            && database._data[variable] == _data[variable])
                        continue;
                    else
                        return false;
                }
            }
            else
                return false;
            return true;
        }

        public override int GetHashCode()
        {
            unchecked
            {
                int hash = 15;
                hash = hash * 18 + _data.GetHashCode();
                return hash;
            }
        }
    }
}
