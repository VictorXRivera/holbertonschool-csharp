# Project 0x05. C# - Structs, Enumerations
# Specializations - AR/VR ― C#
# by Carrie Ybay, Software Engineer at Holberton School

## Learning Objectives
* What is a struct
* What is a constructor
* What is a field
* What is a property
* What is an enumeration and when to use them
* What does toString do and how to override it

## Requirements
* Allowed editors: Visual Studio Code
* All files will be compiled on Ubuntu 14.04 LTS using dotnet
* A README.md file, at the root of the folder of the project, is mandatory
* All default C# files named Program.cs should be renamed to the name given in each task
* Each C# task requires its own folder and .csproj file. Push all task folders to your Github and ensure the task names on the folders are correct
* You do not need to push your obj/ or bin/ folders
* In the following examples, the main.cs files are shown as examples. You can use them to test your functions, but you don’t have to push them to your repo (if you do we won’t take them into account). We will use our own main.cs files at compilation. Our main.cs files might be different from the one shown in the examples

## Tasks
### 0. They're good dogs
Define a new enum Rating with the values <b>Good, Great, Excellent</b>.
```C#
using System;

class Program
{
    static void Main(string[] args)
    {
        Rating rating;

        rating = Rating.Great;

        Console.WriteLine("Score: " + rating);
        Console.WriteLine("Score: " + (int)rating);
    }
}
carrie@ubuntu:~/0x05-csharp-structs_enums\0-dog$
```
```C#
carrie@ubuntu:~/0x05-csharp-structs_enums\0-dog$ ls
bin    obj    0-dog.cs    0-dog.csproj    0-main.cs
carrie@ubuntu:~/0x05-csharp-structs_enums\0-dog$ dotnet run
Score: Great
Score: 1
carrie@ubuntu:~/0x05-csharp-structs_enums\0-dog$
```

### 1. Chief Puppy Officer 
Based on 0-dog, define a new struct Dog with the following members:
* name, type: public string
* age, type: public float
* owner, type: public string
* rating, type public Rating
```C#
carrie@ubuntu:~/0x05-csharp-structs_enums\1-dog$ cat 1-main.cs
using System;

class Program
{
    static void Main(string[] args)
    {
        Dog poppy;

        poppy.name = "Poppy";
        poppy.age = 0.7f;
        poppy.owner = "Kris";
        poppy.rating = Rating.Excellent;

        Console.WriteLine("My name is {0} and I am {1}. I am an {2} dog. :)", poppy.name, poppy.age, poppy.rating);
    }
}
carrie@ubuntu:~/0x05-csharp-structs_enums\1-dog$
```
```C#
carrie@ubuntu:~/0x05-csharp-structs_enums\1-dog$ ls
bin    obj    1-dog.cs    1-dog.csproj    1-main.cs
carrie@ubuntu:~/0x05-csharp-structs_enums\1-dog$ dotnet run
My name is Poppy and I am 0.7. I am an Excellent dog. :)
carrie@ubuntu:~/0x05-csharp-structs_enums\1-dog$
```

### 2. A dog is the only thing on earth that loves you more than you love yourself
Based on 1-dog, add a constructor to struct Dog that takes parameters.
```C#
carrie@ubuntu:~/0x05-csharp-structs_enums\2-dog$ cat 2-main.cs
using System;

class Program
{
    static void Main(string[] args)
    {
        Dog poppy;

        poppy = new Dog("Poppy", 0.7f, "Kris", Rating.Excellent);

        Console.WriteLine("My name is {0} and I am {1}. I am an {2} dog. :)", poppy.name, poppy.age, poppy.rating);
    }
}
carrie@ubuntu:~/0x05-csharp-structs_enums\2-dog$
```
```C#
carrie@ubuntu:~/0x05-csharp-structs_enums\2-dog$ ls
bin    obj    2-dog.cs    2-dog.csproj    2-main.cs
carrie@ubuntu:~/0x05-csharp-structs_enums\2-dog$ dotnet run
My name is Poppy and I am 0.7. I am an Excellent dog. :)
carrie@ubuntu:~/0x05-csharp-structs_enums\2-dog$
```

### 3. A dog will teach you unconditional love. If you can have that in your life, things won't be too bad
Based on 2-dog, override the .ToString() method to print the Dog object’s attributes to stdout.
<b>Format:</b>
```C#
Dog Name: <name>
Age: <age>
Owner: <owner>
Rating: <rating>
```
```C#
carrie@ubuntu:~/0x05-csharp-structs_enums\3-dog$ cat 3-main.cs
using System;

class Program
{
    static void Main(string[] args)
    {
        Dog poppy;

        poppy = new Dog("Poppy", 0.7f, "Kris", Rating.Excellent);

        Console.WriteLine(poppy.ToString());
    }
}
carrie@ubuntu:~/0x05-csharp-structs_enums\3-dog$
```
```C#
carrie@ubuntu:~/0x05-csharp-structs_enums\3-dog$ ls
bin    obj    3-dog.cs    3-dog.csproj    3-main.cs
carrie@ubuntu:~/0x05-csharp-structs_enums\3-dog$ dotnet run
Dog Name: Poppy
Age: 0.7
Owner: Kris
Rating: Excellent
carrie@ubuntu:~/0x05-csharp-structs_enums\3-dog$
```
