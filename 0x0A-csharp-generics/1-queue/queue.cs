using System;

///<summary> Queue </summary>///
public class Queue<T>
{
    ///<summary>Method that returns type</summary>
    public Type CheckType()
    {
        return(typeof(T));
    }

    ///<summary>Node class</summary>///
    public class Node
    {
        private T value;
        public Node next = null;
        
        ///<summary>Constructor</summary>///
        public Node(T t)
        {
            value = t;
        }
    }
    
    public Node head;
    public Node tail;
    public int count;

    ///<summary>Enqueue method</summary>///
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
		return count;
	}

}