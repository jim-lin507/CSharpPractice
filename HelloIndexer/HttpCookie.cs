using System;
using System.Collections.Generic;

namespace HelloIndexer
{
    class HelloCookie
    {
        private readonly Dictionary<string, string> _dictionary;
        public HelloCookie()
        {
            _dictionary = new Dictionary<string, string>();
        }
        public string this[string key]
        {
            get { return _dictionary[key]; }
            set { _dictionary[key] = value; }
        }
    }
}