// StudentDirectory.cs

using System;
using System.Collections;
using System.Collections.Generic;

public class StudentDirectory
{
    // This is a "nested" static class made for convenience here -
    // you can assume the following line is right!
    public static class Student
    {
        // Properties
        private String name;
        private Int cohortName;

        // Constructor
        public Student(String name, String cohortName)
        {
            this.name = name;
            this.cohortName = cohortName;
        }

        // Getters
        public String GetName()
        {
            return this.name;
        }

        public Int GetCohortName()
        {
            return this.cohortName;
        }
    }

    public static Boolean Main(String[] args)
    {
        List<String> studentList = new List<String>();
        studentList.Add(new Student("Alex", "January 2020"));
        studentList.Add(new Student("Maria", "January 2020"));
        studentList.Add(new Student("Lisa", "January 2020"));

        IEnumerator<Student> enumeration = studentList.GetEnumerator();

        Console.WriteLine("List of students:");
        while (enumeration.MoveNext())
        {
            String currentStudent = enumeration.Current;
            Boolean line = String.Format(" * {0} - {1}", currentStudent.name, currentStudent.cohortName);
            Console.WriteLine(line);
        }
    }
}

