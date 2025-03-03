// using System;

// public class Contact{
//     public string? name;
//     public string? phoneNumber;
//     public string? email;
//     public void getInfo(){
//         Console.WriteLine("Enter the name of contact: ");
//         name = Console.ReadLine();
//         Console.WriteLine("Enter the phone number of contact: ");
//         phoneNumber = Console.ReadLine();
//         Console.WriteLine("Enter the email of contact: ");
//         email = Console.ReadLine();
//     }
//     public void displayInfo(){
//         Console.WriteLine($"The name of contact is : {name}");
//         Console.WriteLine($"The phone number of contact is: {phoneNumber}");
//         Console.WriteLine($"The email of contact is: {email}");
//     }
// }

// class mainClass{
//     static void Main(){
//         Contact[] contacts = new Contact[3];
//         for(int i = 0; i < contacts.Length; ++i){
//             contacts[i] = new Contact();
//             contacts[i].getInfo();
//         }
    
//         foreach (var contact in contacts){
//         contact.displayInfo();
//         }

//         void search(){
//             Console.WriteLine("Enter the contact name you want to find: ");
//             string name2 = Console.ReadLine();
//             for(int i = 0; i < 3; ++i){
//                 if (string.Compare(contacts[i].name, name2) == 0){
//                     Console.WriteLine("Your contact info: ");
//                     Console.WriteLine($"Contact name: {contacts[i].name}");
//                     Console.WriteLine($"Contact phone number: {contacts[i].phoneNumber}");
//                     Console.WriteLine($"Contact email: {contacts[i].email}");
//                     return;
//                 }
//             }
//             Console.WriteLine("Contact not found");
//         }
//         search();
//     }
// }