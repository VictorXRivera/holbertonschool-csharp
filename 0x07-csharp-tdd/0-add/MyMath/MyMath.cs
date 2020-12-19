using System.Linq;
using System.Reflection;
using System.Runtime.CompilerServices;
using System;
using System.Collections.Generic;
using static System.Console;

[assembly: InternalsVisibleToAttribute("MyMath.Tests")];
namespace MyMath
{
    /// <summary>
    /// Class with methods handling addition
    /// </summary>
    class Operations
    {
        /// <summary>
        /// Integer addition method
        /// </summary>
        public static int Add(int a, int b)
        {
            return a + b;
        }
    }
}