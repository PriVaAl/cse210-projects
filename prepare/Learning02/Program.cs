using System;

class Program
{
    static void Main(string[] args)
    {
       Job job1 = new Job();
       job1._jobTitle = "Software Engineer";
       job1._company = "Microsoft";
       job1._enterYear = 2000;
       job1._endYear = 2024;
       

       Job job2 = new Job();
       job2._jobTitle = "Product Manager";
       job2._company = "Apple";
       job2._enterYear = 2002;
       job2._endYear = 2024;
       
       job1.DisplayDetails();
       job2.DisplayDetails();

    }
}
