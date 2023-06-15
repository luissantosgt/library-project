// See https://aka.ms/new-console-template for more information
using System;
using LibraryManagmentSystem;


var book = new Book("music","denis", 2015);
var bookTwo = new Book("art", "luis", 2016);
var bookThree = new Book("more music", "ale", 2017);
var bookFour = new Book("art", "luis", 2018);

var library = new Library();
library.AddBook(book);
library.AddBook(bookTwo);
library.AddBook(bookThree);
library.AddBook(bookFour);


/* foreach(var item in library.allBooks)
{
    Console.WriteLine(item.Title);
}

// library.SearchBook("more music"); */

//The search uses the StringBuilder class to format a string that contains one line for each book. 
var report = new System.Text.StringBuilder();
string title = "art";
report.AppendLine("Title\tAuthor\tYear");
List<Book> search = library.SearchList(title);
foreach(Book item in search)
{
    report.AppendLine($"{item.Title}\t{item.Author}\t{item.Year}");
}
string listFound = report.ToString();
Console.WriteLine(listFound);
