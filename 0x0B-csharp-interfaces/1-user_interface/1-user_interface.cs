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

/// <summary>
/// Make object intractable
/// </summary>
interface IInteractive
{
    void Interact();
}

/// <summary>
/// give objects a durability property and breakable state
/// </summary>
interface IBreakable
{
    int durability { get; set; }
    void Break();
}

/// <summary>
/// make an object collectible.
/// </summary>
interface ICollectable
{
    bool isCollected { get; set; }

    void Collect();
}

class TestObject : Base, IInteractive, IBreakable, ICollectable
{
    public int durability { get; set; }
    public bool isCollected { get; set; }

    public void Interact()
    {
    }


    public void Break()
    {
    }

    public void Collect()
    {
    }
}
