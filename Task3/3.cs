// using System;

// public class BanckAccount{
//     public int accNum;
//     public string? name;
//     public int balance;
//     public void displayInfo(){
//         Console.WriteLine($"Account number is: {accNum}");
//         Console.WriteLine($"AccHolder name is: {name}");
//         Console.WriteLine($"Balance: {balance}");
//     }

//     public void Withdraw(){
//             Console.WriteLine("Enter the amount of money you want to get: ");
//             int sum = int.Parse(Console.ReadLine());
//             for(;sum > balance;){
//                 Console.WriteLine("You havn't enough money, try another amount of money");
//                 sum = int.Parse(Console.ReadLine());
//             }
//             Console.WriteLine("Your withdrow was successed");
//             balance -= sum;
//     }

//     public void Deposit(){
//         Console.WriteLine("Enter the amount of money you want to add");
//         int sum = int.Parse(Console.ReadLine());
//         for(;sum < 0;){
//             Console.WriteLine("Enter new amount of money");
//             sum = int.Parse(Console.ReadLine());
//         }
//         Console.WriteLine("Your deposit was successed");
//         balance += sum;
//     }
// }

// class Mainnclass{
//     static void Main(){
//         BanckAccount user = new BanckAccount();
//         void userInput(){
//             Console.WriteLine("Enter your name ");
//             user.name = Console.ReadLine();
//             user.accNum = 1;
//             user.balance = 457000;
//             user.displayInfo();
//             Console.WriteLine("What kind of operation you want to do");
//             Console.WriteLine("Withdraw or Deposit");
//             string op = Console.ReadLine();
//             if(String.Compare(op, "Withdraw") == 0){
//                 user.Withdraw();
//             }
//             else if(String.Compare(op, "Deposit") == 0){
//                 user.Deposit();
//             }
//             else{
//                 Console.WriteLine("Command not found");
//             }
//         }
//         userInput();
//         user.displayInfo();
//     }
// }  