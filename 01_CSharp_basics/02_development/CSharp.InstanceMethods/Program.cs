using System;

namespace CSharp.InstanceMethods;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine(myStaticMethod());
        // create an instance of Program and assign it to a variable
        Program myProgram = new Program();
        myProgram.myMethod("new instance text");
        
    }

    static string myStaticMethod(){
        return "a static method";
    }

    void myMethod(){
        Console.WriteLine("an instance method");
    }

    void myMethod(string message){
        Console.WriteLine(message);
    }
}
