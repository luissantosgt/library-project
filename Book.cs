

namespace LibraryManagmentSystem{

//This code defines the class book and its properties.  
public class Book{
    public string Title {get; set;}
    public string Author {get; set;}
    
    public int Year {get; set;}

// The constructor initialize the properties with the parameters passed in.    
public Book(string name, string author, int date)
{
    Title = name;
    Author = author;
    Year = date;
}
} 
}