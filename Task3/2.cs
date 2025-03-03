// using System;

// public class Student{
//     public string? name;
//     public int age;
//     public string? grades;

//     public void displayDetails(){
//         Console.WriteLine($"Student name is {name}");
//         Console.WriteLine($"Student age is {age}");
//         Console.WriteLine($"Student grades: {grades}");
//         Console.WriteLine('\n');
//     }
// }

// class Mainclass{
//     static void Main(){
//         Student[] students = new Student[5];
//         string[] studentNames = {"Mike", "John", "Sara", "Sadie", "Nick"};
//         int[] studentAges = {15, 13, 16, 17, 18};
//         string[] studentGrades = {"6,7,9,8", "8,9,8", "8,7,9,9", "9,9,9,8", "9,8,9,9,7"};
//         for(int i = 0; i < students.Length; ++i){
//             students[i] = new Student();
//             students[i].name = studentNames[i];
//             students[i].age = studentAges[i];
//             students[i].grades = studentGrades[i];
//         }
//         foreach(var stud in students){
//             stud.displayDetails();
//         }
//     }
// }