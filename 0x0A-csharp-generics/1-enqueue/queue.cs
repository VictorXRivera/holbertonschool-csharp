using System;

///<summary> Queue </summary>///
public class Queue<T>
{
    ///<summary>Method that returns type</summary>
    public Type CheckType()
    {
        return(typeof(T));
    }

    /// <summary>Class Node inside queue class</summary>
	public class Node
	{
        ///<summary>Node</summary>///
		public Node next = null;
        T value = default(T);

        ///<summary>Constructor</summary>///
		public Node(T t)
		{
			this.value = t;
		}
	}

    ///<summary>Object</summary>///
	public Node head;
    ///<summary>Object</summary>///
	public Node tail;
    ///<summary>Int</summary>///
	public int count;

	///<summary>Add new node at the end</summary>
	public void Enqueue(T value)
	{
		Node newnode = new Node(value);
		if (head == null)
		{
			head = newnode;
			tail = newnode;
		}
		else
		{
			tail.next = newnode;
			tail = newnode;
		}
		count++;
	}

	///<summary>Add new node at the end</summary>
	public int Count()
	{
		return (count);
	}

}