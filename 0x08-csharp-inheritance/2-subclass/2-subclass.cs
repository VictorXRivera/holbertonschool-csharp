using System;

/// <summary> Object class </summary>
class Obj
{
    /// <summary> Method to check if object is only a subclass </summary>
    public static bool IsOnlyASubclass(Type derivedType, Type baseType)
    {
        if (derivedType.IsSubclassOf(baseType))
            return true;
        return false;
    }
}