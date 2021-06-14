using System;
using System.Collections;
using System.Collections.Generic;

namespace D04_BoxingUnboxing
{



    class Program
    {
        static void Main(string[] args)
        {
            var list = new ArrayList();
            list.Add(1);
            list.Add("Pankaj");
            list.Add(DateTime.Now);

            var number = (int)list[1];

            var anotherList = new List<int>();
            anotherList.Add(1);

            var names = new List<string>();
            names.Add("Pankaj");

        }
    }
}
