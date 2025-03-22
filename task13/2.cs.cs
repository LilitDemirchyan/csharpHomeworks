using System;

abstract class Shape{
    public abstract int Surface();
    public abstract void Draw();
    public void Print(){
        Console.WriteLine($"{this.GetType().Name}, S = {Surface()}");
        Draw();
    }
}

class Rectangle : Shape{
    int size1 = 0;
    int size2 = 0;
    public override void Draw(){
        for(int i = 0; i < size1; ++i){
            for(int j = 0; j < size2; ++j){
                Console.Write("* ");
            }
            Console.WriteLine();
        }
    }

    public override int Surface(){
        int surf = size1 * size2;
        return surf;
    }
    public Rectangle(int size1, int size2){
        this.size1 = size1;
        this.size2 = size2;
    }
}

class Square : Shape{
    int size = 0;

    public Square(int size){
        this.size = size;
    }
    public override void Draw(){
        for(int i = 0; i < size; ++i){
            for(int j = 0; j < size; ++j){
                Console.Write("* ");
            }
            Console.WriteLine();
        }
    }

    public override int Surface(){
        int surf = size * size;
        return surf;
    }
}

class Prog{
    static void Main(){
        Shape[] shapes = new Shape[2];
        shapes[0] = new Rectangle(4,10);
        shapes[1] = new Square(4);
        foreach(Shape h in shapes){
            h.Print();
        }
    }
}