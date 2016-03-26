using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cis237assignment4
{
    class GenericStack<T>
    {
        protected Node<T> Head = null;
        protected Int32 location = 0;

        public Int32 Location
        {
            get { return location; }
        }

        public void Push(T contents)
        {
            Node <T> node = new Node<T>();
            node.Data = contents;
            node.Next = Head;
            Head = node;
            location++;
        }

        public T Pop()
        {
            T contents = Head.Data;
            Head = Head.Next;
            location--;
            return contents;
        }
    }
}
