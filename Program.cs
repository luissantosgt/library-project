// See https://aka.ms/new-console-template for more information
using LibraryManagmentSystem;


var book = new Book("music");
var bookTwo = new Book("art");
var bookThree = new Book("more music");

var library = new Library();
library.AddBook(book);
library.AddBook(bookTwo);
library.AddBook(bookThree);


foreach(var item in library.allBbooks)
{
    Console.WriteLine(item.titleName);
}

// library.SearchBook("more music");
