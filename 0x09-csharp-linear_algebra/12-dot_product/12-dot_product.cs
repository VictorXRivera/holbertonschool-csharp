﻿using System;

///<summary>VectorMath class</summary>
class VectorMath
{
    ///<summary>2D/3D Dot Product method</summary>
    public static double DotProduct(double[] vector1, double[] vector2)
    {
        if (vector1.Length != vector2.Length)
            return -1;
        if (vector1.Length == 2)
            return ((vector1[0] * vector2[0]) + (vector1[1] * vector2[1]));
        else if (vector1.Length == 3)
            return ((vector1[0] * vector2[0]) + (vector1[1] * vector2[1]) + (vector1[2] * vector2[2]));        
        else
            return -1;
    }
}