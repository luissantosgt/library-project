using System;
using System.Collections.Generic;

namespace LibraryManagmentSystem

//defines the class Library
{
public class Library {

// private property is a list of type book //list of books 
private List<Book> allBooks; 

// constructor that initialize the list

public Library()
{
    this.allBooks = new List<Book>();
}

//method add: adds a book to the list 

public void AddBook(Book book)
{
    allBooks.Add(book);
}
//method remove: removes a book to the list 
public void RemoveBook(Book book)
{
    allBooks.Remove(book);
}
//method search one book

public void SearchBook(string book)
{
    var findName = allBooks.Find(x => x.Title == book);
    if(findName != null){
          Console.WriteLine(findName.Title);
    }
}
/*method to search book by title, initialize a new list of type book called results, 
then iterates each element in the list and the condition validate if the 
received parameter title matchs and Title, returns a list of matching books   */


public List<Book> SearchList(string title){
    List<Book> results = new List<Book>();
    foreach(Book book in allBooks){
        if(book.Title.Contains(title)){
            results.Add(book);
    }

    }

  return results;
}

}

}