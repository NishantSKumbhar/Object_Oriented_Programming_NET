﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using Console_OOP.Exercise;
using Console_OOP.Sample_Mobile;
using Console_OOP.Mosh_EX_1;
//using Console_OOP.Composition;
using Console_OOP.Mosh_EX_2;
using Console_OOP.Inheritance;
using Console_OOP.Mosh_EX_3_Stack;
using Console_OOP.OverRiding;
using Console_OOP.Mosh_EX_4_Abstract;
using Console_OOP.Interface;


namespace Console_OOP
{
    internal class Program
    {
        static void Main(string[] args)
        {

           
            Console.WriteLine("------------------------------------------");
            var encoder = new VideoEncoder();
            encoder.Encode(new Video());
        }
    }
}
