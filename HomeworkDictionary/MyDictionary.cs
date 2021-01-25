using System;
using System.Collections.Generic;
using System.Text;

namespace Dictionary
{
    class MyDictionary<A, B>
    {
        A[] items1;
        B[] items2;
        public MyDictionary()
        {
            items1 = new A[0];
            items2 = new B[0];
        }
        public void Add(A item1, B item2)
        {
            A[] tempArray1 = items1;
            B[] tempArray2 = items2;
            items1 = new A[items1.Length + 1];
            items2 = new B[items2.Length + 1];
            for (int i = 0; i < tempArray1.Length; i++)
            {
                items1[i] = tempArray1[i];
            }
            items1[items1.Length - 1] = item1;

            for (int j = 0; j < tempArray2.Length; j++)
            {
                items2[j] = tempArray2[j];
            }
            items2[items2.Length - 1] = item2;
        }


        public int Count
        {
            get { return items1.Length; }
        }

        public int Count2
        {
            get { return items2.Length; }
        }
    }
}

