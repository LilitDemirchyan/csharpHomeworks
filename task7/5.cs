// using System;

// class Grid3d{
//     private int[,,] mat;
//     private int x, y, z;
//     public Grid3d(){
//         x = 3;
//         y = 3;
//         z = 3;
//         mat = new int[x,y,z];
//     }


//     public int this[int x2, int y2, int z2]{
//         get{
//             if(x2 < 0 || x2 >= 3 || y2 < 0 || y2 >= 3 || z2 < 0 || z2 >= 3){
//             throw new IndexOutOfRangeException("Index out of bounds");
//             }
//             return mat[x2,y2,z2];
//         }
//         set{
//             if(x2 < 0 || x2 >= 3 || y2 < 0 || y2 >= 3 || z2 < 0 || z2 >= 3){
//                 throw new IndexOutOfRangeException("Index out if bounds");
//             }
//             mat[x2,y2,z2] = value;
//         }
//     }
// }

// class Program{
//     static void Main(){
//         Grid3d grid = new Grid3d();
//         grid[1,2,0] = 50;
//         Console.WriteLine(grid[1,2,0]);
//     }
// }