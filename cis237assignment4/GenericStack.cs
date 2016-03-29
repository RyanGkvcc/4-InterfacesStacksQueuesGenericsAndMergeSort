using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cis237assignment4
{
    class GenericStack<T>
    {
        //Some protected variables for the class
        protected Node<T> Head = null;
        protected Int32 location = 0;

        //The public property for Location
        public Int32 Location
        {
            get { return location; }
        }

        //Public method to add contents to the generic stack
        public void Push(T contents)
        {
            Node <T> node = new Node<T>();
            node.Data = contents;
            node.Next = Head;
            Head = node;
            location++;
        }

        //Public method to remove contents from the generic stack
        public T Pop()
        {
            T contents = Head.Data;
            Head = Head.Next;
            location--;
            return contents;
        }
    }
}
