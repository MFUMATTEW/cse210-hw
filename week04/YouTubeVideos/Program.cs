using System;

class Program
{
    static void Main(string[] args)
    {
        Video video1 = new Video();
        Video video2 = new Video();
        Video video3 = new Video();
        Video video4 = new Video();

        video1._author = "John";
        video2._author = "Marie";
        video3._author = "Nephi";
        video4._author = "Ruth";

        video1._title = "Am i really beloved?";
        video2._title = "Giving birth an amazing experience";
        video3._title = "Bulding a ship from nothing";
        video4._title = "How can you make your husband happy?";

        video1._length = 3;
        video2._length = 25;
        video3._length = 13;
        video4._length = 45;

        Comment comment1 = new Comment();
        Comment comment2 = new Comment();
        Comment comment3 = new Comment();
        Comment comment4 = new Comment();
        Comment comment5 = new Comment();
        Comment comment6 = new Comment();
        Comment comment7 = new Comment();
        Comment comment8 = new Comment();

        comment1._commentAuthor = "James";
        comment2._commentAuthor = "Esther";
        comment3._commentAuthor = "Laman";
        comment4._commentAuthor = "Boaz";
        comment5._commentAuthor = "Bejamin";
        comment6._commentAuthor = "Lehi";
        comment7._commentAuthor = "Joseph";
        comment8._commentAuthor ="Luc";

        comment1._commentText = "You are really special!";
        comment2._commentText = "What a wonderful story!";
        comment3._commentText = "You will never make it";
        comment4._commentText = "What a wonderful attention";
        comment5._commentText = "That was amazing!";
        comment6._commentText = "Great Job!";
        comment7._commentText = "Were you not afraid?";
        comment8._commentText = "I want to be like you";

        video1.AddComment(comment1);
        video1.AddComment(comment8);
        video2.AddComment(comment2);
        video2.AddComment(comment7);
        video3.AddComment(comment3);
        video3.AddComment(comment6);
        video4.AddComment(comment4);
        video4.AddComment(comment5);

        video1.DisplayAll();
        Console.WriteLine("");
        video2.DisplayAll();
        Console.WriteLine("");
        video3.DisplayAll();
        Console.WriteLine("");
        video4.DisplayAll();
    }
}