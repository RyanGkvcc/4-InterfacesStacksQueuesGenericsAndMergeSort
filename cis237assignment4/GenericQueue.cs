using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cis237assignment4
{
    class GenericQueue<T>
    {
        protected Node<T> Head;
        protected Node<T> Tail;
        protected Int32 location = 0;


        public Int32 Location
        {
            get { return location; }
        }

        public void Enqueue(T contents)
        {
            Node<T> node = new Node<T>();
            node.Data = contents;
            if(Head == null)
            {
                Head = node;
                Tail = node;
                Tail.Next = null;
            }
            else
            {
                Tail.Next = node;
                Tail = node;
                Tail.Next = null;
            }
            location++;
        }

        public T Dequeue()
        {
            T contents = Head.Data;
            Head = Head.Next;
            location--;
            return contents;
        }
    }
}
