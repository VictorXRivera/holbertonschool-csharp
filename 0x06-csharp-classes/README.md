# 0x06. C# - Classes and Namespaces
# Specializations - AR/VR ― C#
# by Carrie Ybay, Software Engineer at Holberton School

## Learning Objectives
* How to document C# code with XML comments
* What is object-oriented programming?
* What is a namespace
* What is a class
* What are objects and instances
* What is the difference between a class and an object or instance
* What is a field
* What is a constructor
* What is a property
* How to use get and set
* When to use a constructor and when to use a property
* What is this and when to use it
* What is a method
* What are access modifiers
* What is a static class
* What is a static member
* What is encapsulation
* What is polymorphism
* What is abstraction
* What does toString do and how to override it
* What is the difference between a class and a struct
* When to use a class and when to use a struct
* What is garbage collection in C#

## Requirements
* Allowed editors: Visual Studio Code
* All files will be compiled on Ubuntu 14.04 LTS using dotnet
* A README.md file, at the root of the folder of the project, is mandatory
* All default C# files named Program.cs should be renamed to the name given in each task
* Each C# task requires its own folder and .csproj file. Push all task folders to your Github and ensure the task names on the folders are correct
* You do not need to push your obj/ or bin/ folders
* In the following examples, the main.cs files are shown as examples. You can use them to test your functions, but you don’t have to push them to your repo (if you do we won’t take them into account). We will use our own main.cs files at compilation. Our main.cs files might be different from the one shown in the examples
* All your public classes and their members should have XML documentation tags
* All your private classes and members should be documented but without XML documentation tags

```
From this project forward, documenting your code is required!

Use XML documentation comments

XML Documentation Best Practices

All public types / classes and their members should be documented with <summary> tags

Private members should be documented but without XML comments

To enable XML documentation in your project, you must add this line to the PropertyGroup in your .csproj file:
<DocumentationFile>bin\$(Configuration)\$(TargetFramework)\$(AssemblyName).xml</DocumentationFile>

Compiling your project with /doc will create an XML file in the directory specified above. With the .xml in the same directory as the compiled assembly, VSCode will automatically read the XML file and use it to provide tooltips with your documentation. Keep this in mind as you write your comments; they should give the programmer clear, concise information about your methods’ purpose and usage.
```

## Tasks
<b>0. Braaainsss</b>
Create a new namespace Enemies. Create an empty public class Zombie within Enemies that defines a zombie.
```C#
carrie@ubuntu:~/0x06-csharp-classes/0-enemy$ cat 0-main.cs 
using Enemies;
using System;

class Program
{
    static void Main(string[] args)
    {
        Enemies.Zombie newObject = new Enemies.Zombie();

        Console.WriteLine("newObject is of type {0}", newObject.GetType());
        Console.WriteLine("String representation: {0}", newObject.ToString());
    }
}
carrie@ubuntu:~/0x06-csharp-classes/0-enemy$
```
```C#
carrie@ubuntu:~/0x06-csharp-classes/0-enemy$ ls
0-enemy.cs  0-enemy.csproj  0-main.cs  bin  obj
carrie@ubuntu:~/0x06-csharp-classes/0-enemy$ dotnet run
newObject is of type Enemies.Zombie
String representation: Enemies.Zombie
carrie@ubuntu:~/0x06-csharp-classes/0-enemy$
```

<b>1. Healthy competition</b>
Based on 0-enemy, write a public class Zombie that defines a zombie by:
* public field health
* health should be an int and have no value
* public constructor: public Zombie()
* sets the value of health to 0
```C#
carrie@ubuntu:~/0x06-csharp-classes/1-enemy$ cat 1-main.cs 
using Enemies;
using System;

class Program
{
    static void Main(string[] args)
    {
        Enemies.Zombie newObject = new Enemies.Zombie();

        Console.WriteLine("newObject is of type {0} and has a total of {1} health", newObject.GetType(), newObject.health);
    }
}
carrie@ubuntu:~/0x06-csharp-classes/1-enemy$
```
```C#
carrie@ubuntu:~/0x06-csharp-classes/1-enemy$ ls
1-enemy.cs  1-enemy.csproj  1-main.cs  bin  obj
carrie@ubuntu:~/0x06-csharp-classes/1-enemy$ dotnet run
newObject is of type Enemies.Zombie and has a total of 0 health
carrie@ubuntu:~/0x06-csharp-classes/1-enemy$
```

<b>2. Health validation</b>
Based on 1-enemy, write a public class Zombie that defines a zombie by:
* public field health
* health should be an int and have no value
* public constructor: public Zombie()
* sets the value of health to 0
* a new public constructor: public Zombie(int value)
* value must be greater than or equal to 0
* if value is less than 0, throw an ArgumentException with the message Health must be greater than or equal to 0
```C#
carrie@ubuntu:~/0x06-csharp-classes/2-enemy$ cat 2-main.cs 
using Enemies;
using System;

class Program
{
    static void Main(string[] args)
    {
        Enemies.Zombie newObject1;
        Enemies.Zombie newObject2;

        try
        {
            newObject1 = new Enemies.Zombie(10);
            Console.WriteLine("newObject1 is of type {0} and has a total of {1} health", newObject1.GetType(), newObject1.health);
        }
        catch (Exception e)
        {
            Console.WriteLine(e.Message);
        }

        try
        {
            newObject2 = new Enemies.Zombie(-10);
            Console.WriteLine("newObject2 is of type {0} and has a total of {1} health", newObject2.GetType(), newObject2.health);

        }
        catch (Exception e)
        {
            Console.WriteLine(e.Message);
        }
    }
}
carrie@ubuntu:~/0x06-csharp-classes/2-enemy$
```
```C#
carrie@ubuntu:~/0x06-csharp-classes/2-enemy$ ls
2-enemy.cs  2-enemy.csproj  2-main.cs  bin  obj
carrie@ubuntu:~/0x06-csharp-classes/2-enemy$ dotnet run
newObject1 is of type Enemies.Zombie and has a total of 10 health
Health must be greater than or equal to 0
carrie@ubuntu:~/0x06-csharp-classes/2-enemy$
```

<b>3. Zombie health</b>
Based on 2-enemy, write a public class Zombie that defines a zombie by:
* private field health
* health should be an int and have no value
* public constructor: public Zombie()
* sets the value of health to 0
* public constructor: public Zombie(int value)
* value must be greater than or equal to 0
* public method public int GetHealth() that returns the value of health of the Zombie object
```C#
carrie@ubuntu:~/0x06-csharp-classes/3-enemy$ cat 3-main.cs 
using Enemies;
using System;

class Program
{
    static void Main(string[] args)
    {
        Enemies.Zombie newObject1;
        Enemies.Zombie newObject2;

        try
        {
            newObject1 = new Enemies.Zombie(10);
            Console.WriteLine("newObject1 is of type {0} and has a total of {1} health", newObject1.GetType(), newObject1.GetHealth());
        }
        catch (Exception e)
        {
            Console.WriteLine(e.Message);
        }

        try
        {
            newObject2 = new Enemies.Zombie(98);
            Console.WriteLine("newObject2 is of type {0} and has a total of {1} health", newObject2.GetType(), newObject2.GetHealth());

        }
        catch (Exception e)
        {
            Console.WriteLine(e.Message);
        }
    }
}
carrie@ubuntu:~/0x06-csharp-classes/3-enemy$
```
```C#
carrie@ubuntu:~/0x06-csharp-classes/3-enemy$ ls
3-enemy.cs  3-enemy.csproj  3-main.cs  bin  obj
carrie@ubuntu:~/0x06-csharp-classes/3-enemy$ dotnet run
newObject1 is of type Enemies.Zombie and has a total of 10 health
newObject2 is of type Enemies.Zombie and has a total of 98 health
carrie@ubuntu:~/0x06-csharp-classes/3-enemy$
```

<b>4. Hello, my name is</b>
Based on 3-enemy, write a public class Zombie that defines a zombie by:
* private field health
* health should be an int and have no value
* public constructor: public Zombie()
* sets the value of health to 0
* public constructor: public Zombie(int value)
* value must be greater than or equal to 0
* private field name
* name should be a string and have a default value of (No name)
* public property Name
* get: retrieve name
* set: set name
* public method public int GetHealth() that returns the value of health of the Zombie object

```C#
carrie@ubuntu:~/0x06-csharp-classes/4-enemy$ cat 4-main.cs 
using Enemies;
using System;

class Program
{
    static void Main(string[] args)
    {
        Enemies.Zombie newObject1;
        Enemies.Zombie newObject2;

        try
        {
            newObject1 = new Enemies.Zombie(10);
            newObject1.Name = "Ed";
            Console.WriteLine("{0} is of type {1} and has a total of {2} health", newObject1.Name, newObject1.GetType(), newObject1.GetHealth());
        }
        catch (Exception e)
        {
            Console.WriteLine(e.Message);
        }

        try
        {
            newObject2 = new Enemies.Zombie(98);
            Console.WriteLine("{0} is of type {1} and has a total of {2} health", newObject2.Name, newObject2.GetType(), newObject2.GetHealth());

        }
        catch (Exception e)
        {
            Console.WriteLine(e.Message);
        }
    }
}
carrie@ubuntu:~/0x06-csharp-classes/4-enemy$
```
```C#
carrie@ubuntu:~/0x06-csharp-classes/4-enemy$ ls
4-enemy.cs  4-enemy.csproj  4-main.cs  bin  obj
carrie@ubuntu:~/0x06-csharp-classes/4-enemy$ dotnet run
Ed is of type Enemies.Zombie and has a total of 10 health
(No name) is of type Enemies.Zombie and has a total of 98 health
carrie@ubuntu:~/0x06-csharp-classes/4-enemy$
```

<b>5. Printing a zombie</b>
Based on 4-enemy, write a public class Zombie that defines a zombie by:
* private field health
* health should be an int and have no value
* public constructor: public Zombie()
* sets the value of health to 0
* public constructor: public Zombie(int value)
* value must be greater than or equal to 0
* private field name
* name should be a string and have a default value of (No name)
* public property Name
* get: retrieve name
* set: set name
* public method public int GetHealth() that returns the value of health of the Zombie object
* public .toString() override that prints the Zombie object’s attributes to stdout
* Format: Zombie name: <name> / Total Health: <health> (see example below)
```C#
carrie@ubuntu:~/0x06-csharp-classes/5-enemy$ cat 5-main.cs 
using Enemies;
using System;

class Program
{
    static void Main(string[] args)
    {
        Enemies.Zombie newObject1;
        Enemies.Zombie newObject2;

        try
        {
            newObject1 = new Enemies.Zombie(10);
            newObject1.Name = "Ed";
            Console.WriteLine(newObject1.ToString());
        }
        catch (Exception e)
        {
            Console.WriteLine(e.Message);
        }

        try
        {
            newObject2 = new Enemies.Zombie(98);
            Console.WriteLine(newObject2.ToString());
        }
        catch (Exception e)
        {
            Console.WriteLine(e.Message);
        }
    }
}
carrie@ubuntu:~/0x06-csharp-classes/5-enemy$
```
```C#
carrie@ubuntu:~/0x06-csharp-classes/5-enemy$ ls
5-enemy.cs  5-enemy.csproj  5-main.cs  bin  obj
carrie@ubuntu:~/0x06-csharp-classes/5-enemy$ dotnet run
Zombie Name: Ed / Total Health: 10
Zombie Name: (No name) / Total Health: 98
carrie@ubuntu:~/0x06-csharp-classes/5-enemy$
```
