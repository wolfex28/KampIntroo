﻿using System;

namespace GenericsIntro
{
    class Program
    {
        static void Main(string[] args)
        {
            MyList<string> isimler = new MyList<string>();
            isimler.Add("engin");

            Console.WriteLine(isimler.Length);
            isimler.Add("okan");
            Console.WriteLine(isimler.Length);
        }
    }
}
