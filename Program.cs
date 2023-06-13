// See https://aka.ms/new-console-template for more information
using System;
using LibraryManagmentSystem;


var book = new Book("music","denis", 2015);
var bookTwo = new Book("art", "luis", 2016);
var bookThree = new Book("more music", "ale", 2017);

var library = new Library();
library.AddBook(book);
library.AddBook(bookTwo);
library.AddBook(bookThree);


foreach(var item in library.allBooks)
{
    Console.WriteLine(item.TitleName);
}

// library.SearchBook("more music");
