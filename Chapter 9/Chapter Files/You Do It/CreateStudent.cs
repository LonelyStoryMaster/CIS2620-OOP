using System;
using static System.Console;

class CreateStudents {
    static void Main() {
        Student first = new Student();
        Student second = new Student();

        first.IdNumber = 123;
        first.LastName = "Anderson";
        first.GradePointAverage = 3.5;

        second.IdNumber = 789;
        second.LastName = "Daniels";
        second.GradePointAverage = 4.1;

        WriteLine(first + "\n" + second);
    }
}

class Student {
    public const double HIGHEST_GPA = 4.0;
    public const double LOWEST_GPA = 0.0;
    private int idNumber;
    private string lastName;
    private double gradePointAverage;

    public int IdNumber { get { return this.idNumber;} set { this.idNumber = value;} }
    public string LastName { get { return this.lastName;} set { this.lastName = value;} }
    public double GradePointAverage {
        get { return this.gradePointAverage; }
        set { this.gradePointAverage = (value >= LOWEST_GPA && value <= HIGHEST_GPA) ? value : LOWEST_GPA; }
    }

    public override string ToString() {
        return String.Format("{0, 5} {1, -10}{2, 6}", this.IdNumber, this.LastName, this.GradePointAverage.ToString("F1"));
    }
}