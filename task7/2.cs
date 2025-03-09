// using System;

// class Product{
//     public decimal price;
//     public int stock;

//     public decimal Price{
//         get => price;

//         set{
//             if(value < 0){
//                 price = 0;
//             }
//             else{
//                 price = value;
//             }
//         }
//     }

//     public int Stock{
//         get => stock;

//         set{
//             if(value < 0){
//                 stock = 10;
//             }
//             else{
//                 stock = value;
//             }
//         }
//     }

//     public Product(decimal pricee, int stockk){
//         Price = pricee;
//         Stock = stockk;
//     }
// }


// class Mainclass{
//     static void Main(){
//     Product product = new Product(5,6);
//     Console.WriteLine($"{product.Price},  {product.Stock}");

//     Product product2 = new Product(-5,-6);
//     Console.WriteLine($"{product2.Price},  {product2.Stock}");
//     Console.WriteLine($"{product2.price},  {product2.stock}");
//     }
// }