// See https://aka.ms/new-console-template for more information
using System;
using LibraryManagmentSystem;


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



