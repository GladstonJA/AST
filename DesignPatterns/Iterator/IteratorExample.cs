using System;
using System.Collections;
using System.Collections.Generic;

namespace Iterator
{
    public class IteratorExample
    {
        public void TesteIterator()
        {
            var lista = new List<string>() { "ITEM 1", "ITEM 2", "ITEM 3" };
            var array = new string[] { "ITEM 4", "ITEM 5" };
            var dicionario = new Dictionary<int, string>();
            dicionario.Add(6, "ITEM 6");
            dicionario.Add(7, "ITEM 7");
            
            Iterate(lista.GetEnumerator());
            Iterate(array.GetEnumerator());
            Iterate(dicionario.Keys.GetEnumerator());
            Iterate(dicionario.Values.GetEnumerator());
        }

        private void Iterate(IEnumerator iterator)
        {
            while(iterator.MoveNext())
            {
                // Do something
            }
        }
    }
}
