using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyCalcLib
{
    class MyArr
    {
        int[] Arr;
        public int Length;

        public MyArr (int Size)
        {
            Arr = new int[Size];
            Length = Size;
        }

        public int this[int index]
        {
            set
            {
                Arr[index] = value;
            }
            get
            {
                return Arr[index];
            }
        }
    }

}
