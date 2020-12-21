using System;
using System.Collections.Generic;

    /// <summary> Object class </summary>
    class Obj
    {
        /// <summary> Method checking if the object is an int </summary>
        public static bool IsOfTypeInt(object obj)
        {
            if (obj.GetType() == typeof(int))
                return true;
            return false;
        }
    }
