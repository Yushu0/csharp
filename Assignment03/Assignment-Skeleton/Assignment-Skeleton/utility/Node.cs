using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_Skeleton.utility
{
    public class Node
    {
        private static object _node = null;
        public static object _Node
        {
            get { return _node; }
            set { _node = value; }
        }

        public static object GetNode(LinkedListADT sLL, int index)
        {
            return sLL.Retrieve(index);
        }

        public static void SetNode(LinkedListADT sLL, object obj, int index)
        {
            sLL.Insert(obj, index);
        }
    }
}
