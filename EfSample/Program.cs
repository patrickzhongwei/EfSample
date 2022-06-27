using EfSample.DataModels;
using EfSample.Enums;
using System;
using System.Collections.Generic;

namespace EfSample
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            using Context myContext = new Context();
            myContext.Students.Add(new Student()
            {
                StudentName = "Joe Smith",
                StudentClasses = new List<Class>()
                {
                    new Class()
                    {
                        ClassLanguage = Language.French,
                        ClassName = "myFirstClass",
                        MaxClassSize = 12
                    },
                    new Class()
                    {
                        ClassLanguage = Language.English,
                        ClassName = "mySecondClass",
                        MaxClassSize = 25
                    }

                }
            });
            myContext.SaveChanges();
        }
    }
}
