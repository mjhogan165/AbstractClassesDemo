﻿using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleUI
{
    public abstract class Vehicle
    {
        public int Year { get; set; } = 1;

        public string Make { get; set; } = "Default Make";

        public string Model { get; set; } = "Default Model";

        public abstract void DriveAbstract();    //"stubbed out method" has no implementation (no scope)
        
        public virtual void DriveVirtual()    // class WITH implementation
        {
            Console.WriteLine($"This {GetType().Name} is virtually in drive");
        }

        

    }



}
