<<<<<<< HEAD


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
=======
namespace LibraryManagmentSystem {

public class Book
{
    public string titleName {get; set;}
    public string description {get; set;}


    public Book(string title, string desc){
        this.titleName = title;
        this.description = desc;

    }


}
>>>>>>> dfc4ed05b869194be8b28c01f198a4bb7925c426


}