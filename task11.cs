using System;
using System.ComponentModel.DataAnnotations;

public class Parent{
    public int age;
    public string name;
    public decimal salary;

    public Parent(string Name, int Age, decimal Salary){
        age = Age;
        name = Name;
        salary = Salary;
    }
}

public class Child{
    public int age;
    public string name;
    public Parent parent1;
    public Parent parent2;

    public Child(string Name, int Age, Parent Parent1, Parent Parent2){
        age = Age;
        name = Name;
        parent1 = Parent1;
        parent2 = Parent2;
    }

    public string Display(){
        return $"Child: {name}, Age: {age}\nMother: [Name: {parent1.name}, Age: {parent1.age}, Salary: {parent1.salary}]\n Father: [Name: {parent2.name}, Age: {parent2.age}, Salary: {parent2.salary}]\n";
    }
}

class Prog{
    static void Main(){
        Child[] child = new Child[10];
        string[] childNames = { "Liam", "Emma", "Noah", "Olivia", "James", "Sophia", "William", "Ava", "Benjamin", "Mia" };
        string[] motherNames = { "Anna", "Elizabeth", "Sophia", "Catherine", "Jessica", "Emily", "Sarah", "Amanda", "Linda", "Melissa" };
        string[] fatherNames = { "John", "Michael", "Robert", "David", "James", "William", "Richard", "Thomas", "Daniel", "Matthew" };

        int[] childAges = { 7, 9, 11, 6, 8, 12, 10, 14, 13, 15 };
        int[] motherAges = { 30, 32, 28, 34, 29, 35, 31, 33, 36, 27 };
        int[] fatherAges = { 35, 38, 40, 36, 37, 39, 42, 41, 45, 33 };

        decimal[] motherSalaries = { 200000, 250000, 180000, 220000, 190000, 230000, 210000, 260000, 240000, 170000 };
        decimal[] fatherSalaries = { 300000, 400000, 350000, 320000, 330000, 410000, 370000, 390000, 450000, 310000 };
        for (int i = 0; i < 10; i++){
            Parent mother = new Parent(motherNames[i], motherAges[i], motherSalaries[i]);
            Parent father = new Parent(fatherNames[i], fatherAges[i], fatherSalaries[i]);
            child[i] = new Child(childNames[i], childAges[i], mother, father);
            //Console.WriteLine(child[i].Display());
        }

        //1
        Console.WriteLine("Childs, whose parents age sum is under 70: ");
        for(int i = 0; i < 10; ++i){
            if(child[i].parent2.age + child[i].parent1.age < 70){
                Console.WriteLine($"Name: {child[i].name}, Age: {child[i].age}");
            }
        }

        //2
        int max = 0;
        decimal salaryy = 0;
        Console.Write("The oldest child's father's salary: ");
        for(int i = 0; i < 10; ++i){
            if(child[i].age > max){
                max = child[i].age;
                salaryy = child[i].parent2.salary;
            }
        }
        Console.WriteLine(salaryy);


        //3
        decimal max_sal = 0;
        int index = 0;
        for(int i = 0; i < 10; ++i){
            if(child[i].parent1.salary + child[i].parent2.salary > max_sal){
                max_sal = child[i].parent1.salary + child[i].parent2.salary;
                index = i;
            }
        }
        Console.WriteLine("Most rich family child: "); 
        Console.WriteLine(child[index].Display()); 


        //4
        int min = child[0].age;
        int maxx = child[0].age;
        int index1 = 0;
        int index2 = 0;
        for(int i = 0; i < 10; ++i){
            if(child[i].age < min){
                min = child[i].age;
                index1 = i;
            }
            if(child[i].age > maxx){
                maxx = child[i].age;
                index2 = i;
            }
        }
        Child tmp = child[index1];
        child[index1] = child[index2];
        child[index2] = tmp;
        Console.WriteLine("Modyfied array: ");
        for(int i = 0; i < 10; ++i){
            Console.WriteLine(child[i].Display());
        }
    }
}