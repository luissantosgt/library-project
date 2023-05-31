using System;
using System.Collections.Generic;

namespace LibraryManagmentSystem
{
public class Library {

//list of books 

private List<Book> books;
public Library(){
    this.books = new List<Book>();

}
//methods add, remove, and search

//method add
public void AddBook(Book book)
{
    books.Add(book);


}

//method search
public void SearchBook(string title)
{
    var searchBook  = books.Find(x => x.titleName == title);
    if(searchBook != null)
    {
        Console.WriteLine(searchBook.titleName);
    }
} 
      
}






}