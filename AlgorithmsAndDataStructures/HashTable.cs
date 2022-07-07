using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgorithmsAndDataStructures
{
    public class HashTable<TKey, TValue>
    {
        TValue[] table = new TValue[4];
        private uint Hash(TKey key)
        {

        };

        public TValue this[TKey key]
        {
            get => table[Index(key)];
            set => table[Index(key)] = value;
        }

        private uint Index(TKey key)
        {
            return Hash(key) % table.Length;
        }
    }
}
