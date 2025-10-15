namespace fileRead;

public class FileReader
{
    public List<Book> ListBooks()
    {
        var books = new List<Book>();
        var file = File.ReadLines("book.csv");
        foreach (var row in file.Skip(1))
        {
  
            var data = row.Split(";");
            var book = new Book
            {
                Id = int.Parse( data[0]),
                KolcsonzoId = int.Parse(data[1]),
                StartDate = DateTime.Parse(data[2]),
                EndDate = DateTime.Parse(data[3]),
            };
            books.Add(book);
        }
        return books;
    }
}
