using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cis237assignment4
{
    class GenericQueue<T>
    {
        //Some protected variables for the class
        protected Node<T> Head;
        protected Node<T> Tail;
        protected Int32 location = 0;


        //The public property for Location
        public Int32 Location
        {
            get { return location; }
        }

        //Public method to add contents to the generic queue
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

        //Public method to remove contents from the generic queue
        public T Dequeue()
        {
            T contents = Head.Data;
            Head = Head.Next;
            location--;
            return contents;
        }
    }
}
