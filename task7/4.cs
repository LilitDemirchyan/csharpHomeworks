// using System;

// class Student{
//     private string[] subjects;
//     private int[] grades;
//     private int subCon;

//     public Student(int size){
//         subjects = new string[size];
//         grades = new int[size];
//         subCon = 0;
//     }

//     public int this[string subject]{
//         get{
//             for(int i = 0; i < subCon; ++i){
//                 if(subjects[i] == subject){
//                     return grades[i];
//                 }
//             }
//             return -1;
//         }
//         set{
//             for(int i = 0; i < subCon; ++i){
//                 if(subjects[i] == subject){
//                     grades[i] = value;
//                 }
//             }
//             if(subCon < subject.Length){
//                 subjects[subCon] = subject;
//                 grades[subCon] = value;
//                 ++subCon;
//             }
//         }
//     }
// }


// class Peogram{
//     static void Main(){
//         Student student = new Student(4);
//         student["English"] = 9;
//         student["Math"] = 10;

//         Console.WriteLine(student["English"]);
//         Console.WriteLine(student["Math"]);
//     }
// }
