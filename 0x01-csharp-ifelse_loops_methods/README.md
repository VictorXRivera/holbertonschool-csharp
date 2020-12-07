# Project folder for 0x01. C# - if/else, loops, functions
## Specializations - AR/VR ― C#
## by Carrie Ybay, Software Engineer at Holberton School

### Learning Objectives:
* How to use if, else if, else statements
* How to use while and for loops
* How to use break and continue statements
* How to use numeric format strings
* How to declare methods within a class
* How to call public methods from another class
* What is passing by reference and passing by value

### Requirements:
* Allowed editors: Visual Studio Code
* All files will be compiled on Ubuntu 14.04 LTS using dotnet
* A README.md file, at the root of the folder of the project, is mandatory
* All default C# files named Program.cs should be renamed to the name given in each task
* You do not need to know about namespaces and classes yet. Namespaces should be omitted in this project
* Each C# task requires its own folder and .csproj file. Push all task folders to your Github and ensure the task names on the folders are correct
* You do not need to push your obj/ or bin/ folders
* In the following examples, the main.cs files are shown as examples. You can use them to test your functions, but you don’t have to push them to your repo (if you do we won’t take them into account). We will use our own main.cs files at compilation. Our main.cs files might be different from the one shown in the examples

### Tasks
#### Mandatory:
##### 0. Positive anything is better than negative nothing
* This program will assign a random signed number to a variable and will print whether the number stored in the variable number is positive or negative.
* Example output:
```C#
carrie@ubuntu:~/0x01/0-positive_or_negative$ ls
0-positive_or_negative.cs  0-positive_or_negative.csproj  bin  obj
carrie@ubuntu:~/0x01/0-positive_or_negative$ dotnet run
3 is positive
carrie@ubuntu:~/0x01/0-positive_or_negative$ dotnet run
6 is positive
carrie@ubuntu:~/0x01/0-positive_or_negative$ dotnet run
-1 is negative
carrie@ubuntu:~/0x01/0-positive_or_negative$ dotnet run
-6 is negative
carrie@ubuntu:~/0x01/0-positive_or_negative$ dotnet run
-7 is negative
carrie@ubuntu:~/0x01/0-positive_or_negative$ dotnet run
0 is zero
```
##### 1. The last digit
*  This program will assign a random signed number to a variable and print whether the last digit is positive, negative, or is zero.
* Example output:
```C#
carrie@ubuntu:~/0x01/1-last_digit$ ls
1-last_digit.cs  1-last_digit.csproj  bin  obj
carrie@ubuntu:~/0x01/1-last_digit$ dotnet run
The last digit of 8903 is 3 and is less than 6 and not 0
carrie@ubuntu:~/0x01/1-last_digit$ dotnet run
The last digit of -6117 is -7 and is less than 6 and not 0
carrie@ubuntu:~/0x01/1-last_digit$ dotnet run
The last digit of 2790 is 0 and is 0
carrie@ubuntu:~/0x01/1-last_digit$ dotnet run
The last digit of 7363 is 3 and is less than 6 and not 0
carrie@ubuntu:~/0x01/1-last_digit$ dotnet run
The last digit of 7590 is 0 and is 0
carrie@ubuntu:~/0x01/1-last_digit$ dotnet run
The last digit of -3435 is -5 and is less than 6 and not 0
carrie@ubuntu:~/0x01/1-last_digit$ dotnet run
The last digit of 6661 is 1 and is less than 6 and not 0
carrie@ubuntu:~/0x01/1-last_digit$ dotnet run
The last digit of -365 is -5 and is less than 6 and not 0
carrie@ubuntu:~/0x01/1-last_digit$ dotnet run
The last digit of 619 is 9 and is greater than 5
```
##### 2. I sometimes suffer from insomnia. And when I can't fall asleep, I play what I call the alphabet game
* This program will print the entire alphabet in lower case. However, I could not use loops and could only use Console.Write once.
* Example output:
```C#
carrie@ubuntu:0x01/2-print_alphabet$ ls
2-print_alphabet.cs  2-print_alphabet.csproj  bin  obj
carrie@ubuntu:0x01/2-print_alphabet$ dotnet run
abcdefghijklmnopqrstuvwxyzcarrie@ubuntu:0x01/2-print_alphabet$
```
