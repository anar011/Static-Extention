﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Static_Struct_Extention_Enum.Models
{
    internal  class Car
    {
        public static int Speed { get; set; } = 500;

        static Car()
        {
            Console.WriteLine("Static constructor");
        }

        public Car(int n)
        {
            Console.WriteLine("Constructor");
        }

        
    }
}
 