using System;
using System.Net;
using System.Numerics;

class Vector3d{
    public double X, Y, Z;

    public Vector3d(){}

    public override string ToString(){
        return X + "," + Y + "," + Z;
    }

    public Vector3d(double x, double y, double z){
        X = x;
        Y = y;
        Z = z;
    }

    public static Vector3d operator +(Vector3d first, Vector3d second){
        return new Vector3d(first.X + second.X, first.Y + second.Y, first.Z + second.Z);
    }

    public static Vector3d operator -(Vector3d first, Vector3d second){
        return new Vector3d(first.X - second.X, first.Y - second.Y, first.Z - second.Z);
    }

    public static Vector3d operator *(Vector3d first, double scalar){
        return new Vector3d(first.X * scalar, first.Y * scalar, first.Z * scalar);
    }

    public static Vector3d operator /(Vector3d first, double scalar){
        if (scalar == 0)
            throw new DivideByZeroException("Scalar is zero");
        return new Vector3d(first.X / scalar, first.Y / scalar, first.Z / scalar);
    }

    public static bool operator ==(Vector3d first, Vector3d second){
        return first.X == second.X && first.Y == second.Y && first.Z == second.Z;
    }

    public static bool operator !=(Vector3d first, Vector3d second){
        return !(first == second);
    }

    public override bool Equals(object? obj){
        if(obj is Vector3d obj2){
            return(X == obj2.X && Y == obj2.Y && Z == obj2.Z);
        }
        return false;
    }

    public override int GetHashCode()
    {
        return HashCode.Combine(X, Y, Z);
    }

    public static bool operator true(Vector3d ob){
        return (ob.X != 0 || ob.Y != 0 || ob.Z != 0);
    }

    public static bool operator false(Vector3d ob){
        return (ob.X == 0 && ob.Y == 0 && ob.Z == 0);
    }

    public static double Magnitude(Vector3d ob1){
        return Math.Sqrt(ob1.X * ob1.X + ob1.Y * ob1.Y + ob1.Z * ob1.Z);
    }

    public static bool operator >(Vector3d ob1, Vector3d ob2){
        return Magnitude(ob1) > Magnitude(ob2);
    }

    public static bool operator <(Vector3d ob1, Vector3d ob2){
        return Magnitude(ob1) < Magnitude(ob2);
    }

    public static bool operator >=(Vector3d ob1, Vector3d ob2){
        return Magnitude(ob1) >= Magnitude(ob2);
    }

    public static bool operator <=(Vector3d ob1, Vector3d ob2){
        return Magnitude(ob1) <= Magnitude(ob2);
    }
}


class Mainclass{
    static void Main(){
        Vector3d vec1 = new Vector3d(3, 4, 5);
        Vector3d vec2 = new Vector3d(1, 2, 3);

        Console.WriteLine("Vector 1: " + vec1);
        Console.WriteLine("Vector 2: " + vec2);

        Console.WriteLine("Addition: " + (vec1 + vec2));
        Console.WriteLine("Subtraction: " + (vec1 - vec2));
        Console.WriteLine("Multiplication by scalar (2): " + (vec1 * 2));
        Console.WriteLine("Division by scalar (2): " + (vec1 / 2));

        Console.WriteLine("vec1 == vec2: " + (vec1 == vec2));
        Console.WriteLine("vec1 != vec2: " + (vec1 != vec2));

        Console.WriteLine("vec1 > vec2: " + (vec1 > vec2));
        Console.WriteLine("vec1 < vec2: " + (vec1 < vec2));
        Console.WriteLine("vec1 >= vec2: " + (vec1 >= vec2));
        Console.WriteLine("vec1 <= vec2: " + (vec1 <= vec2));
        

    }
}
