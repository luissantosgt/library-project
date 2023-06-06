

namespace LibraryManagmentSystem{

public class Book{
    public string TitleName {get; set;}
    public string Author {get; set;}
    
    public int Year {get; set;}

    
public Book(string name, string author, int date)
{
    this.TitleName = name;
    this.Author = author;
    this.Year = date;

}

} 


}