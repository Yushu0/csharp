using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_Skeleton.utility
{
    public class SLL : LinkedListADT
    {
        private object[] ObjList = new object[0];

        public void Append(object data)
        {
            var tempList = ObjList;

            ObjList = new object[tempList.Length + 1];
            for (int i = 0; i < tempList.Length; i++)
            {
                ObjList[i] = tempList[i];
            }
            ObjList[tempList.Length] = data;
        }

        public void Clear()
        {
            ObjList = new object[0];
        }

        public bool Contains(object data)
        {
            bool result = false;
            foreach (var item in ObjList)
            {
                if (item == data)
                {
                    result = true;
                    break;
                }
            }
            return result;
        }

        public void Delete(int index)
        {
            if (index >= ObjList.Length) return;

            var tempList = new object[ObjList.Length - 1];
            int y = 0;
            for (int i = 0; i < ObjList.Length; i++)
            {
                if (i != index)
                {
                    tempList[y] = ObjList[i];
                    y++;
                }
            }
            ObjList = tempList;
        }

        public int IndexOf(object data)
        {
            int retData = -1;

            for (int i = 0; i < ObjList.Length; i++)
            {
                if (ObjList[i] == data)
                {
                    retData = i;
                    break;
                }
            }
            return retData;
        }

        public void Insert(object data, int index)
        {
            var tempList = new object[ObjList.Length + 1];

            for (int i = 0; i < ObjList.Length; i++)
            {
                if (i < index)
                {
                    tempList[i] = ObjList[i];
                }
                else if (i == index)
                {
                    tempList[index] = data;
                    tempList[i + 1] = ObjList[i];
                }
                else
                {
                    tempList[i + 1] = ObjList[i];
                }
            }
            ObjList = tempList;
        }

        public bool IsEmpty()
        {
            return ObjList.Length == 0;
        }

        public void Prepend(object data)
        {
            var tempList = new object[ObjList.Length + 1];
            tempList[0] = data;
            for (int i = 0; i < ObjList.Length; i++)
            {
                tempList[i + 1] = ObjList[i];
            }
            ObjList = tempList;
        }

        public void Replace(object data, int index)
        {
            var tempList = new object[ObjList.Length];
            for (int i = 0; i < ObjList.Length; i++)
            {
                if (i == index)
                {
                    tempList[index] = data;
                }
                else
                {
                    tempList[i] = ObjList[i];
                }
            }
            ObjList = tempList;

        }

        public object Retrieve(int index)
        {
            if (index < ObjList.Length)
            {
                return ObjList[index];
            }
            return null;
        }

        public int Size()
        {
            return ObjList.Length;
        }
    }
}
