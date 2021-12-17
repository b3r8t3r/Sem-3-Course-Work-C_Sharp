using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Threading.Tasks;


namespace Sem_3_Course_Work_C_Sharp
{
    public class Chapter
    {
        //[JsonPropertyName("ChapterID")]
        public int ChapterId { get; set; }

        // internal string ChapterTitle { get; set; }

        //[JsonPropertyName("ChapterText")]
        public string ChapterText { get; set; }

        //[JsonPropertyName("ChapterVariants")]
        public string[] ChapterVariants { get; set; }

        



    }
    public class Book
    {
        //[JsonPropertyName("BookAuthor")]
        public string BookAuthor { get; set; }

        //[JsonPropertyName("BookTitle")]
        public string BookTitle { get; set; }

        public Chapter[] Chapters { get; set; }

        
    }

    //class SerializeBook : Book
    //{
    //    static async Task Serialze(string[] args)
    //    {
    //        // сохранение данных
    //        using (FileStream fs = new FileStream("user.json", FileMode.OpenOrCreate))
    //        {
    //            Chapter chapter0 = new Chapter() {ChapterId = 0, ChapterText = "Charapter 0 text"};
    //            Chapter chapter1 = new Chapter() {ChapterId = 1, ChapterText = "Charapter 1 text"};
    //            Chapter chapter2 = new Chapter() {ChapterId = 2, ChapterText = "Charapter 2 text"};
    //            Chapter chapter3 = new Chapter() {ChapterId = 3, ChapterText = "Charapter 3 text"};
    //            Chapter chapter4 = new Chapter() {ChapterId = 4, ChapterText = "Charapter 4 text"};
    //            Chapter chapter5 = new Chapter() {ChapterId = 5, ChapterText = "Charapter 5 text"};
    //            Chapter chapter6 = new Chapter() {ChapterId = 6, ChapterText = "Charapter 6 text"};
    //            Chapter chapter7 = new Chapter() {ChapterId = 7, ChapterText = "Charapter 7 text"};
    //            Chapter chapter8 = new Chapter() {ChapterId = 8, ChapterText = "Charapter 8 text"};
    //            Chapter chapter9 = new Chapter() {ChapterId = 9, ChapterText = "Charapter 9 text"};
    //            Chapter[] chap = new Chapter[] {chapter0, chapter1, chapter2, chapter3, chapter4};
    //            Book book = new Book() { BookAuthor = "Tom Harrison", BookTitle = "35 Graphs", Chapters = chap };
    //            await JsonSerializer.SerializeAsync<Book>(fs, book);
    //            //Console.WriteLine("Data has been saved to file");

    //        }

    //        // чтение данных
    //        using (FileStream fs = new FileStream("user.json", FileMode.OpenOrCreate))
    //        {
    //            Book restoredPerson = await JsonSerializer.DeserializeAsync<Book>(fs);
    //            //Console.WriteLine($"Name: {restoredPerson.Name}  Age: {restoredPerson.Age}");
                
    //        }
    //    }
    //}
}
