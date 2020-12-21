using System;

/// <summary Object class </summary>
class Obj
{
    /// <summary> Method that checks if object is an array type </summary>
    public static bool IsInstanceOfArray(object obj)
    {
        if (obj.GetType().IsArray)
            return true;
        return false;
    }
}