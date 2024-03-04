using HotChocolate.ApolloFederation.Resolvers;
using HotChocolate.ApolloFederation.Types;

namespace hot_chocolate_v1_federations;

[ExtendServiceType]
public class Book
{
    [Key, External] public int Id { get; set; }
    public string Name { get; set; }

    [ReferenceResolver]
    public static Book? ResolveById(int id)
    {
        List<Book> books = [new Book { Id = 1, Name = "First book" }, new Book { Id = 1, Name = "Second book" }];

        return books.FirstOrDefault(x => x.Id == id);
    }
}