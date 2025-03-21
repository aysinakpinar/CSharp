﻿namespace CSharp.HelloName;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine(Hello("Aysin"));
        Console.WriteLine(changeOfPlan("going to the cinema"));
        Console.WriteLine(apology("Caner"));
        Console.WriteLine(politeNotice("walk the dog"));
        Program myProgram = new Program();
        myProgram.helpNeeded("start the project");
    }
    static string Hello(){
        return "Hello!";
    }

    static string Hello(string name){
        return $"Hello, {name}!";
    }

    static string changeOfPlan(){
        return "Plans have been changed to going for a walk";
    }

    static string changeOfPlan(string newPlan){
        return $"Plans have been changed to {newPlan}";
    }

    static string apology(){
        return "Apologies to Aysin";
    }

    static string apology(string name){
        return $"Apologies to {name}";
    }

    static string politeNotice(){
        return "Please don't forget to RSVP";
    }

    static string politeNotice(string newRequest){
        return $"please don't forget to {newRequest}";
    }

    void helpNeeded(){
        Console.WriteLine("Help is needed to complete the project");
    }

    void helpNeeded(string duty){
        Console.WriteLine($"Help is needed to {duty}");
    }
}
