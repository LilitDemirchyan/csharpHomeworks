using System;
using System.Net;
class Prog{
    unsafe public static void Main(){
        int* ptr = stackalloc int[10];
        for(int i = 0; i <= 10; ++i){
            ptr[i] = int.Parse(Console.ReadLine());
            Console.WriteLine(ptr[i]);
        }
        int max = 0;
        int index = 0;
        for(int i = 0; i <= 10; ++i){
            if(ptr[i] > max){
                max = ptr[i];
                index = i;
            }
        }
        Console.WriteLine($"Max element index is: {index}, \n max element is: {max}");
    }
}