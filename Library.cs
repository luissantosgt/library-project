using System;
using System.Collections.Generic;

namespace LibraryManagmentSystem

//defines the class Library
{
public class Library {

// property is a list of type book //list of books 
public List<Book> allBooks; 

// constructor that initialize the list

public Library()
{
    this.allBooks = new List<Book>();
}

//methods add, remove, and search

public void AddBook(Book book)
{
    allBooks.Add(book);
}

public void RemoveBook(Book book)
{
    allBooks.Remove(book);
}

public void SearchBook(string book)
{
    var findName = allBooks.Find(x => x.TitleName == book);
    if(findName != null){
          Console.WriteLine(findName.TitleName);
    }
}

public List<Book> SearchList(string title){
    foreach(var item in allBooks){
        if(title == item.TitleName){
            allBooks.Add(item);
    }

    }

  return allBooks;
}

}

}