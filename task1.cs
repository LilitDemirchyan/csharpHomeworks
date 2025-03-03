//task 1
using System;

//1
// class Myclass{
//     static void Main(){
//         string name = "Lilit";
//         string lang = "C++";
//         int currtime = DateTime.Now.Year;
//         Console.WriteLine("My name is: " + name + " My fav language is: " + lang + ',' + " Current year is: " + currtime);
//     }
// }


//2
// class Classs{
//     static void Main(){
//         int age = 12;
//         double price = 15.00;
//         bool stud = false;
//         char ch = 'a';
//         Console.WriteLine("Age is: " + age + '\n' + "Price of book is: " + price + '\n' + "Studient: " + stud);
//     }
// }


//3
// class My{
//     static void Main(){
//         int[] nums = new int[10];
//         Console.Write("Enter number 1: ");
//         nums[0] = int.Parse(Console.ReadLine());
//         Console.Write("Enter number 2: ");
//         nums[1] = int.Parse(Console.ReadLine());
//         Console.Write("Enter number 3: ");
//         nums[2] = int.Parse(Console.ReadLine());
//         Console.Write("Enter number 4: ");
//         nums[3] = int.Parse(Console.ReadLine());
//         Console.Write("Enter number 5: ");
//         nums[4] = int.Parse(Console.ReadLine());
//         int sum = nums[0] + nums[1] + nums[2] + nums[3] + nums[4];
//         Console.WriteLine("Sum of all elements: " + sum);
//     }
// }



//4
// class MM{
//     static void Main(){
//         Console.Write("Enter your first name: ");
//         string name = Console.ReadLine();
//         Console.Write("Enter the second name: ");
//         string name2 = Console.ReadLine();  
//         name = name.ToUpper();
//         name2 = name2.ToUpper();
//         string full = name + '\0' + name2;
//         int len = full.Length;
//         Console.WriteLine(len);
//     }
// }



//5
// class B{
//    static void Main()
//     {
//         Console.Write("Enter the string: ");
//         string str = Console.ReadLine();
//         string s = new string (str.Reverse().ToArray());
//         if (str.SequenceEqual(s)) {
//             Console.WriteLine("Polindrome");
//         } else {
//             Console.WriteLine("Not polindrome");
//         }
//     }
// }



//6
// class MyClasss{
//     static void Main(){
//         Console.Write("Enter the first num:  \n");
//         int num1 = int.Parse(Console.ReadLine());
//         Console.Write("Enter the second num: \n");
//         int num2 = int.Parse(Console.ReadLine());
//         int sum = num1 + num2;
//         int difference = num1 - num2;
//         int product = num1 * num2;
//         double quotient = num1 / num2;
//         double reminder = num1 % num2;
//         Console.WriteLine($"Sum of 2 nums is: {sum}");
//         Console.WriteLine($"Difference between 2 nums is: {difference}");
//         Console.WriteLine($"Product of 2 nums is: {product}");
//         Console.WriteLine($"Quotient of 2 nums is: {quotient}");
//         Console.WriteLine($"Reminder of 2 nums is: {reminder}");
//         if(num1 > num2){
//             Console.WriteLine("True");
//         }
//         else{
//             Console.WriteLine("False");
//         }
//     }
// }



//7
// class MyClass{
//     static void Main(){
//         int[] arr = {89,5,100,45,75};
//         int max = arr[0];
//         if(arr[1] > max){
//             max = arr[1];
//         }
//         if(arr[2] > max){
//             max = arr[2];
//         }
//         if(arr[3] > max){
//             max = arr[3];
//         }
//         if(arr[4] > max){
//             max = arr[4];
//         }
//         Console.WriteLine($"The largest number of array is: {max}");
//     }
// }



//8
// class Myclass{
//     static void Main(){
//         Console.WriteLine("Enter the number: ");
//         int num = int.Parse(Console.ReadLine());
//         string result = num % 2 == 0 ? "Num is even" : "Num is odd";
//         Console.WriteLine(result);
//     }
// }



//9
// class Myclasss{
//     static void Main(){
//         int[] arr = {1,2,3,4};
//         Console.Write($"[{arr[0]},");
//         Console.Write($"{arr[1]},");
//         Console.Write($"{arr[2]},");
//         Console.Write($"{arr[3]}] \n");
//         Array.Reverse(arr);
//         Console.Write($"[{arr[0]},");
//         Console.Write($"{arr[1]},");
//         Console.Write($"{arr[2]},");
//         Console.Write($"{arr[3]}]");
//     }
// }



//10
// class Myclass{
//     static void Main(){
//         Console.WriteLine("Enter the first number: ");
//         int num1 = int.Parse(Console.ReadLine());
//         Console.WriteLine("Enter the second number: ");
//         int num2 = int.Parse(Console.ReadLine());
//         Console.WriteLine("Enter the operato: ");
//         char op = char.Parse(Console.ReadLine());
//         if(op == '+'){
//             int sum = num1 + num2;
//             Console.WriteLine($"Sum of two nums is: {sum}");
//         }
//         else if(op == '-'){
//             int differ = num1 - num2;
//             Console.WriteLine($"Difference between two nums is: {differ}");
//         }
//         else if(op == '*'){
//             int product = num1 * num2;
//             Console.WriteLine($"Product of two nums is: {product}");
//         }
//         else if(op == '/'){
//             int quotient = num1 / num2;
//             Console.WriteLine($"Quotient of two nums is: {quotient}");
//         }
//         else {
//             Console.WriteLine("Operator is not found");
//             return;
//         }
//     }
// }
