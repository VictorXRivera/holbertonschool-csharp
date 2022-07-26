using System;

///<summary>Abstract class</summary>///
public abstract class Base
{
    ///<summary>Public object</summary>///
    public string name {get; set;}
    ///<summary>ToString override</summary>///
    public override string ToString()
    {
        return string.Format("{0} is a {1}", name, this.GetType().Name);
    }
}