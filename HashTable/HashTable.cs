using System;
using System.Collections.Generic;
using HashTable;

namespace HashTable
{
    public class HashTable<T>
    {
        private LinkedList<T>[] table;
        private int capacity;

        public HashTable(int capacity = 10)
        {
            this.capacity = capacity;
            table = new LinkedList<T>[capacity];
            for (int i = 0; i < capacity; i++)
            {
                table[i] = new LinkedList<T>();
            }
        }

        private int Hash(T value)
        {
            return Math.Abs(value.GetHashCode()) % capacity;
        }

        public void Insert(T value)
        {
            int index = Hash(value);
            if (!table[index].Contains(value))
            {
                table[index].AddLast(value);
                Console.WriteLine($"{value} inserido na posição {index}");
            }
            else
            {
                Console.WriteLine($"{value} já existe na posição {index}");
            }
        }

        public bool Search(T value)
        {
            int index = Hash(value);
            return table[index].Contains(value);
        }

        public bool Remove(T value)
        {
            int index = Hash(value);
            return table[index].Remove(value);
        }

        public void Display()
        {
            for (int i = 0; i < capacity; i++)
            {
                Console.Write($"[{i}]: ");
                var current = table[i].First;
                while (current != null)
                {
                    Console.Write(current.Value);
                    current = current.Next;
                    if (current != null)
                    {
                        Console.Write(" -> ");
                    }
                }
                Console.WriteLine(); // Nova linha para cada bucket
            }
        }
    }
}