using System;
using System.Runtime.InteropServices;

class Course{
    public string class_name;
    public decimal fee;
    Module[] module;

    public Course(string name, decimal money, Module[] m){
        class_name = name;
        fee = money;
        module = m;
    }
}

class Module{
    public string module_name;
    int duration;

    public Module(string name, int dur){
        module_name = name;
        duration = dur;
    }
}

class Group{
    public string group_name;
    public int quantity;
    public Course course;

    public Group(string name, int num, Course c){
        group_name = name;
        quantity = num;
        course = c;
    }
}

class Web : Course{
    public string type;
    public Web(string name, decimal money, string typee, Module[] m) : base(name, money, m){
        type = typee;
    }
}

class Game : Course{
    public string engine;
    public Game(string name, decimal money, string type, Module[] m) : base(name, money, m){
        engine = type;
    }
}

class AI : Course{
    public AI(string name, decimal money, Module[] m) : base(name, money, m){}
}

class Prog{
    static void Main(){
        Course[] courses = new Course[]
        {
            new Web("Frontend Development", 50000, "frontend", new Module[] 
            { 
                new Module("HTML & CSS", 2), new Module("JavaScript", 3) 
            }),
            new Web("Fullstack Development", 60000, "fullstack", new Module[] 
            { 
                new Module("Node.js", 4), new Module("React", 5) 
            }),
            new AI("Machine Learning", 80000, new Module[] 
            { 
                new Module("Python for AI", 6), new Module("Deep Learning", 8) 
            }),
            new Game("Game Development", 72000, "Unity", new Module[] 
            { 
                new Module("C# for Unity", 5), new Module("Physics in Games", 4) 
            }),
            new Game("Game Dev Advanced", 42000, "Unreal", new Module[] 
            { 
                new Module("Blueprints", 6), new Module("C++ for Unreal", 7) 
            })
        };

        Group[] groups = new Group[]
        {
            new Group("Frontend Group 1", 15, courses[0]),   
            new Group("Fullstack Group 1", 12, courses[1]),  
            new Group("AI Group 1", 10, courses[2]),         
            new Group("Game Dev Group 1", 20, courses[3]),  
            new Group("Game Dev Group 2", 18, courses[4])    
        };


        //1
        int webcount = 0;
        for(int i = 0; i < groups.Length; ++i){
            if(groups[i].course is Web){
                webcount += groups[i].quantity;
            }
        }
        Console.WriteLine($"Web group's student count: {webcount}");


        //2
        int gamefee = 0;
        for(int i = 0; i < groups.Length; ++i){
            if(groups[i].course is Game){
                Game newgroup = (Game)groups[i].course;
                if(newgroup.engine == "Unreal"){
                    gamefee += (int)newgroup.fee * groups[i].quantity;
                }
            }
        }
        Console.WriteLine($"Game Dev course monthly income is: {gamefee}");
        

        //3
        Group mostpop = groups[0];
        for(int i = 0; i < groups.Length; ++i){
            if(groups[i].quantity > mostpop.quantity){
                mostpop = groups[i];
            }
        }
        Console.WriteLine($"Most popular group: {mostpop.group_name}");
    }
}