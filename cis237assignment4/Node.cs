using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cis237assignment4
{
    class Node<T>
    {
        //The public property for Data (Generic Type)
        public T Data
        {
            get;
            set;
        }
            
        //The public property for Next (Generic Type)
        public Node<T> Next
        {
            get;
            set;
        }
    }
}
