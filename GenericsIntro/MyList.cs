using System;
using System.Collections.Generic;
using System.Text;

namespace GenericsIntro
{
    class MyList<T>
    //T = TYPE 
    // İTEM = ELEMAN
    { 
    T[] items;

        //constructor
        public MyList()
        {
            items = new T[3];
        }

        //length = elindeki sayıyı 5 arttır
        //tempArray = geçici olarak tutucu
        public void Add(T item)
        {
            T[] tempArray = items;
            items = new T[items.Length+5];
            for (int i = 0; i < tempArray.Length; i++)
            {
                items[i] = tempArray[i];
            }

            // -1 çünkü 0'dan başlıyoruz
            items[items.Length - 1] = item;
        }
    }
}
