
// public class Circle {
//     public double radius; 

//     public Circle(double radius) {
//         this.radius = radius; 
//     }

//     public void CalculateDiameter() {
//         double diameter = radius * 2 * Math.PI;
//         Console.WriteLine($"Circle with radius {this.radius} has diameter of {diameter}");
//     }

//}

// public class Calculator {
//     int a;
//     int b;

//     public Calculator(int a, int b) {
//         this.a = a;
//         this.b = b; 
//     }

//     private void Add() {
//         Console.WriteLine(a + b); 
//     }

//     private void Subtract() {
//         Console.WriteLine(a - b); 
//     }

//     private void Multiply() {
//         Console.WriteLine(a * b); 
//     }

//     private void Divide() {
//         Console.WriteLine(a / b); 
//     }

//     public void Perform(string operation) {
//         switch (operation.ToUpper()) {
//             case "A":
//                 Add();
//                 break;
//             case "S":
//                 Subtract();
//                 break;
//             case "M":
//                 Multiply();
//                 break;
//             case "D":
//                 Divide();
//                 break;
//             default: 
//                 Console.WriteLine("Invalid operaiton.");
//                 break; 
//         }
//     } 
// }

public class Student
{
    public string FirstName { get; private set; }
    public string LastName { get; private set; }
    public DateTime BirthDate { get; private set; }
    private char[] Grades { get; set; }
    public int TotalPoints { get; private set; }

    public Student(string firstName, string lastName, DateTime birthDate)
    {
        FirstName = firstName;
        LastName = lastName;
        BirthDate = birthDate;
        Grades = new char[5];
        TotalPoints = 0;
    }

    public bool IsAdult()
    {
        return (DateTime.Now.Year - BirthDate.Year) > 18 ||
               (DateTime.Now.Year - BirthDate.Year == 18 && DateTime.Now.DayOfYear >= BirthDate.DayOfYear);
    }

    public void SetGrade(int subjectIndex, char grade)
    {
        if (subjectIndex >= 0 && subjectIndex < Grades.Length)
        {
            Grades[subjectIndex] = grade;
            CalculateTotalPoints();
        }
    }

    private void CalculateTotalPoints()
    {
        TotalPoints = 0;
        foreach (var grade in Grades)
        {
            TotalPoints += GradeToPoints(grade);
        }
    }

    private int GradeToPoints(char grade)
    {
        return grade switch
        {
            'A' => 250,
            'B' => 200,
            'C' => 150,
            'D' => 100,
            'E' => 50,
            'F' => 0,
            _ => 0
        };
    }

    public double AveragePoints()
    {
        int gradeCount = 0;
        foreach (var grade in Grades)
        {
            if (grade != '\0') gradeCount++;
        }
        return gradeCount > 0 ? (double)TotalPoints / gradeCount : 0;
    }

    public override string ToString()
    {
        return $"{FirstName} {LastName}, Total Points: {TotalPoints}, Average Points: {AveragePoints():F2}";
    }
}

// public class Program
// {
//     public static void Main()
//     {
//         Random random = new Random();
//         Student[] students =
//         {
//             new Student("Ganz", "Dicksman", new DateTime(2005, 3, 15)),
//             new Student("Bob", "Builder", new DateTime(1999, 7, 22)),
//             new Student("Charlie", "Brown", new DateTime(2003, 11, 9)),
//             new Student("Daisy", "Johnson", new DateTime(1995, 5, 4)),
//             new Student("Evan", "Jackson", new DateTime(2002, 8, 29)),
//             new Student("Fiona", "Svetkov", new DateTime(1998, 1, 12)),
//             new Student("George", "Morgan", new DateTime(2004, 6, 18)),
//             new Student("Gordon", "Freeman", new DateTime(2000, 2, 27)),
//             new Student("Ivan", "Grozniy", new DateTime(1997, 10, 14)),
//             new Student("Billy", "Harrington", new DateTime(2006, 12, 5))
//         };

//         char[] grades = new[] { 'A', 'B', 'C', 'D', 'E', 'F' };
//         foreach (var student in students)
//         {
//             for (int i = 0; i < 5; i++)
//             {
//                 student.SetGrade(i, grades[random.Next(grades.Length)]);
//             }
//         }

//         // Find the best and worst students
//         Student bestStudent = students[0], worstStudent = students[0];
//         foreach (var student in students)
//         {
//             if (student.TotalPoints > bestStudent.TotalPoints)
//                 bestStudent = student;

//             if (student.TotalPoints < worstStudent.TotalPoints)
//                 worstStudent = student;
//         }

//         // Find adult students
//         int adultCount = 0;
//         Console.WriteLine("\nAdult Students:");
//         foreach (var student in students)
//         {
//             if (student.IsAdult())
//             {
//                 adultCount++;
//                 Console.WriteLine(student.FirstName + " " + student.LastName);
//             }
//         }

//         // Display results
//         Console.WriteLine("\nBest Student:");
//         Console.WriteLine(bestStudent);

//         Console.WriteLine("\nWorst Student:");
//         Console.WriteLine(worstStudent);

//         Console.WriteLine($"\nNumber of Adults: {adultCount}");
//     }
// }



internal class Program
{

    private static void Main(string[] args)
    {
        //Circle myCircle = new Circle(25);
        //Calculator calculator = new Calculator(25, 25);

        Random random = new Random();
        Student[] students =
        {
            new Student("Ganz", "Dicksman", new DateTime(2005, 3, 15)),
            new Student("Bob", "Builder", new DateTime(1999, 7, 22)),
            new Student("Charlie", "Brown", new DateTime(2003, 11, 9)),
            new Student("Daisy", "Johnson", new DateTime(1995, 5, 4)),
            new Student("Evan", "Jackson", new DateTime(2002, 8, 29)),
            new Student("Fiona", "Svetkov", new DateTime(1998, 1, 12)),
            new Student("George", "Morgan", new DateTime(2004, 6, 18)),
            new Student("Gordon", "Freeman", new DateTime(2000, 2, 27)),
            new Student("Ivan", "Grozniy", new DateTime(1997, 10, 14)),
            new Student("Billy", "Harrington", new DateTime(2006, 12, 5))
        };

        char[] grades = new[] { 'A', 'B', 'C', 'D', 'E', 'F' };
        foreach (var student in students)
        {
            for (int i = 0; i < 5; i++)
            {
                student.SetGrade(i, grades[random.Next(grades.Length)]);
            }
        }

        // Find the best and worst students
        Student bestStudent = students[0], worstStudent = students[0];
        foreach (var student in students)
        {
            if (student.TotalPoints > bestStudent.TotalPoints)
                bestStudent = student;

            if (student.TotalPoints < worstStudent.TotalPoints)
                worstStudent = student;
        }

        // Find adult students
        int adultCount = 0;
        Console.WriteLine("\nAdult Students:");
        foreach (var student in students)
        {
            if (student.IsAdult())
            {
                adultCount++;
                Console.WriteLine(student.FirstName + " " + student.LastName);
            }
        }

        // Display results
        Console.WriteLine("\nBest Student:");
        Console.WriteLine(bestStudent);

        Console.WriteLine("\nWorst Student:");
        Console.WriteLine(worstStudent);

        Console.WriteLine($"\nNumber of Adults: {adultCount}");
    }
}