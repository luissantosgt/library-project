// See https://aka.ms/new-console-template for more information
using System;
using LibraryManagmentSystem;


<<<<<<< HEAD
var book = new Book("music");
var bookTwo = new Book("art");
var bookThree = new Book("more music");

var library = new Library();
library.AddBook(book);
library.AddBook(bookTwo);
library.AddBook(bookThree);


foreach(var item in library.allBooks)
{
    Console.WriteLine(item.TitleName);
}

// library.SearchBook("more music");
=======
class Program
{
    static void Main(string[] args)
    {
        Book firstBook = new Book("music", "production overview");


        Library mybook = new Library();
        mybook.AddBook(firstBook);
        mybook.SearchBook("music");



    }

}



>>>>>>> dfc4ed05b869194be8b28c01f198a4bb7925c426
