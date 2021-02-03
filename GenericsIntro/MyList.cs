using System;
using System.Collections.Generic;
using System.Text;

namespace GenericsIntro
{
    //t-type
    class MyList<T>
    {
        T[] items;//array bir referans olduğu için eğer alt tarafta(Add kısmı) çalıştırmak istersem
        //onu constructor yardımıyla(ctor) newlemem gerek!
        //constructor
        public MyList()
        {
            items = new T[0];
        }
        public void Add(T item)
        {
            //dizinin eleman saysıını bir artırdım-bu şekilde elemanlarım kaybolur
            //items = new T[items.Length+1];
            T[] tempArray = items;//elemanları kaybetmemek için geçici array tutucu
            items = new T[items.Length + 1];
            for (int i = 0; i < tempArray.Length; i++)
            {
                items[i] = tempArray[i];
            }

            items[items.Length - 1] = item;//bu kısımda son arraya eklemek istediğimiz arrayi ekledik(T item)

        }
    }
}
