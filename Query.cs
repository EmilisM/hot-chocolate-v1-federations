namespace hot_chocolate_v1_federations;

public class Query
{
    public List<Book> GetBook()
    {
        List<Book> books = [new Book { Id = 1, Name = "First book" }, new Book { Id = 1, Name = "Second book" }];

        return books;
    }
}