using System;

public class Library{
    public string? title;
    public string? author;
    bool isAvailable = true;

    // public void BorrowBook(){
    //     Console.WriteLine("Enter the title of book you want to borrow: ");
    //     string title2 = Console.ReadLine();
    //     for(int i = 0; i < 3; ++i){
    //         if(String.Compare(title2, title) == 0){
    //             Console.WriteLine($"You booked this book: {title}");
    //             isAvailable = false;
    //         }
    //         else{
    //             Console.WriteLine("Book not found");
    //         }
    //     }
    // }

    public void BorrowBook(){
        isAvailable = false;  
    }

    public void ReturnBook(){
        Console.WriteLine("Enter the book name you want to return: ");
        string title3 = Console.ReadLine();
        for(int i = 0; i < 3; ++i){
            if(String.Compare(title3, title) == 0){
                Console.WriteLine("Your book has been returned");
                isAvailable = true;
            }
            else{
                Console.WriteLine("Book not found");
            }
        }
    }

    public void DisplayInfo(){
        Console.WriteLine($"Book title: {title}");
        Console.WriteLine($"Book aouthor: {author}");
        Console.WriteLine($"Available? {isAvailable}");
    }
}


class Mainclas{
    static void Main(){
        Library[] library = new Library[3];
        string[] booknames = {"Jane Eyre", "The Headless Horsman", "The night in Lissabon"};
        string[] authors = {"Charlotte Bronte", "Mayne Reid", "Erich Maria Remark"};
        for(int i = 0; i < 3; ++i){
            library[i] = new Library();
            library[i].title = booknames[i];
            library[i].author = authors[i];
        }
        foreach(var i in library){
            i.DisplayInfo();
        }
        void Chois(){
            Console.WriteLine("Do you want to borrow a book or return");
            string chois = Console.ReadLine();
            if(String.Compare(chois, "borrow") == 0){
                Console.WriteLine("Enter the title of book you want to borrow: ");
                string title2 = Console.ReadLine();
            for(int i = 0; i < library.Length; ++i){
                if(String.Compare(title2, library[i].title) == 0){
                    Console.WriteLine($"You booked this book: {library[i].title}");
                    library[i].BorrowBook();
                    foreach(var j in library){
                    j.DisplayInfo();}
                    return;
                }
            }
            Console.WriteLine("Book not found");
            }

        }
        Chois();
    }
}