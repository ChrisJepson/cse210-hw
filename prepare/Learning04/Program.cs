using System;

class Program
{
    static void Main(string[] args){

        Assignment a1 = new Assignment("Christopher Jepson", "Addition");
        Console.WriteLine(a1.GetSummary());

        MathAssignment a2 = new MathAssignment("Blake Ryan", "Division", "8.4", "5-12");
        Console.WriteLine(a2.GetSummary());
        Console.WriteLine(a2.GetHomeworkList());

        WritingAssignment a3 = new WritingAssignment("Ellie Jepson", "Health & Nutrition", "How to maintain your cardiovascular health");
        Console.WriteLine(a3.GetSummary());
        Console.WriteLine(a3.GetWritingInformation());
    }
}