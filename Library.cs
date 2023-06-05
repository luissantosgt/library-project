using System;
using System.Collections.Generic;

namespace LibraryManagmentSystem

//defines the class Library
{
public class Library {

<<<<<<< HEAD
// property is a list of type book //list of books 
public List<Book> allBooks = new List<Book>();
=======
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
>>>>>>> dfc4ed05b869194be8b28c01f198a4bb7925c426

// constructor that initialize the list

public Library()
{
    
}

<<<<<<< HEAD
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
=======
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





>>>>>>> dfc4ed05b869194be8b28c01f198a4bb7925c426

}