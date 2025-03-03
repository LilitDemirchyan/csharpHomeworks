// using System;
// public class BankAccount{
//     public int accNumber;
//     public decimal balance;
//     public BankAccount(int balance){
//         this.balance = balance;
//     }
//      public BankAccount(){
//     }
//     public override string ToString(){
//         return ($"AccountNumber: {accNumber}, Balance: {balance}");
//     }
//     public override bool Equals(object? obj)
//     {
//         if(obj is BankAccount other){
//             return this.accNumber == other.accNumber;
//         }
//         return false;
//     }
//     public override int GetHashCode()
//     {
//         return accNumber.GetHashCode() ^ balance.GetHashCode();
//     }
//     public static BankAccount operator +(BankAccount thirst, BankAccount second){
//         return new BankAccount(thirst.accNumber + second.accNumber);
//     }
// }
// class Mainn{
//     static void Main(){
//         BankAccount bankAccount = new BankAccount(7);
//         BankAccount bankk = new BankAccount(9);
//         Console.WriteLine(bankAccount.Equals(bankk));
//         Console.WriteLine(bankAccount.GetHashCode());
//         Console.WriteLine(bankAccount.ToString());
//         BankAccount helo = new BankAccount();
//         helo = bankAccount + bankk;
//         Console.WriteLine(helo.balance);
//     }
// }
