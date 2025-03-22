// using System;

// abstract class Translator{
//     public Info[]? translate_info;

//     public string Translate(string word){
//         for (int i = 0; i < translate_info.Length; i++){
//             if (translate_info[i].english == word){
//                 return translate_info[i].translated;
//             }
//         }
//         return "Not found";
//     }

    
// }

// struct Info{
//     public string english;
//     public string translated;
//     public Info(string english, string translated){
//         this.english = english;
//         this.translated = translated;
//     }
// }


// class Russian : Translator{
//     public Russian(){
//         translate_info = new Info[]{
//             new Info("Apple", "Яблоко"), new Info("Banana", "Банан"),
//             new Info("Orange", "Апельсин"), new Info("Mango", "Манго"),
//             new Info("Pineapple", "Ананас"), new Info("Grape", "Виноград"),
//             new Info("Strawberry", "Клубника"), new Info("Cherry", "Вишня"),
//             new Info("Watermelon", "Арбуз"), new Info("Peach", "Персик")
//         };
//     }
// }


// class Spanish : Translator{
//     public Spanish(){
//         translate_info = new Info[]{
//             new Info("Apple", "Manzana"), new Info("Banana", "Banana"),
//             new Info("Orange", "Naranja"), new Info("Mango", "Mango"),
//             new Info("Pineapple", "Piña"), new Info("Grape", "Uva"),
//             new Info("Strawberry", "Fresa"), new Info("Cherry", "Cereza"),
//             new Info("Watermelon", "Sandía"), new Info("Peach", "Durazno")
//         };
//     }
// }


// class French : Translator{
//     public French(){
//         translate_info = new Info[]{
//             new Info("Apple", "Pomme"), new Info("Banana", "Banane"),
//             new Info("Orange", "Orange"), new Info("Mango", "Mangue"),
//             new Info("Pineapple", "Ananas"), new Info("Grape", "Raisin"),
//             new Info("Strawberry", "Fraise"), new Info("Cherry", "Cerise"),
//             new Info("Watermelon", "Pastèque"), new Info("Peach", "Pêche")
//         };
//     }
// }


// class Prog{
//     static void Main(){
//         string word = "Mango";
//         Translator[] arr = {new Spanish(), new French(), new Russian()};
//         foreach(Translator i in arr){
//             Console.WriteLine(i.Translate(word));
//         }
//     }
// }
