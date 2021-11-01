using System;
using System.Collections.Generic;
using System.Text;

using _053501_Grishilov_Lab01.Interfaces;

namespace _053501_Grishilov_Lab01.Collections
{
    class MyCustomCollection<T>:ICustomCollection<T>
    {
        private class Node
        {
            public T Data{ get; set; }
            public Node Prev { get; set; }
            public Node Next { get; set; }
            public Node(T data)
            {
                Data = data;
            }        
        }

        private Node First;
        private Node Last;
        private Node Cursor;
        private int Amount = 0;

        public T this[int index]
        {
            get
            {
                Node temp = First;
                int i = 0;
                while (true)
                {
                    if (i == index)
                    {
                        return temp.Data;
                        break;
                    }
                    temp = temp.Next;
                    i++;
                }

            }
            set
            {
                Node temp = First;
                int i = 0;
                while (true)
                {
                    if (i == index)
                    {
                        temp.Data = value;
                        break;
                    }
                    temp = temp.Next;
                    i++;
                }
            }
            
        }
        public void Reset()
        {
            Cursor = First;
        }
        public void Next()
        {
            Cursor = Cursor.Next;
        }
        public T Current()
        {
            return Cursor.Data;
        }
        public int Count
        {
            get
            {
                return Amount;
            }
        }
        public void Add(T item)
        {
            Node NewItem = new Node(item);
            if (First == null)
            {
                Last = First = NewItem;          
            }
            else
            {
                Node temp = Last;
                Last.Next = NewItem;              
                Last = Last.Next;
                Last.Prev = temp;

            }
            Amount++;
        }
         
        
        public void Remove(T item)
        {
            Node temp = First;
            while (temp != null)
            {
                if (temp.Data.Equals(item))
                {
                    break;
                }
                temp = temp.Next;
            }
            if (temp.Next != null)
            {
                temp.Next.Prev = temp.Prev;
            }
            else
            {
                Last = temp.Prev;
            }
            if (temp.Prev != null)
            {
                temp.Prev.Next = temp.Next;
            }
            else
            {
                First = temp.Next;
            }
            Amount--;
        }
        public T RemoveCurrent()
        {
            T data = Cursor.Data;
            
            if (Cursor.Next != null)
            {
                Cursor.Next.Prev = Cursor.Prev;
            }
            else
            {
                Last = Cursor.Prev;
            }

            if (Cursor.Prev != null)
            {
                Cursor.Prev.Next = Cursor.Next;
            }
            else
            {
                First = Cursor.Next;
            }
            Cursor = First;
            Amount--;
            return data;
        }

    }
}
