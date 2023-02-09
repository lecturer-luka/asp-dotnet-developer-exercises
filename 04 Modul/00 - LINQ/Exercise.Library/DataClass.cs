namespace Exercise.Library;

// Only available inside Class Library project
internal class DataClass
{
    
    // Class contains demo data for practice

    List<Product> productDemoList = new List<Product>
        {
            new Product { Id = 1, Title = "Chocolate for cooking" },
            new Product { Id = 2, Title = "Lino Lada - Gold" },
            new Product { Id = 3, Title = "Baking paper" },
            new Product { Id = 4, Title = "Flour - wheat" },
            new Product { Id = 5, Title = "Sugar - standard" }
        };

    List<Invoice> invoiceDemoList = new List<Invoice>
        {
            new Invoice { Id = 100, ProductId = 3,  Quantity = 800, Price = 11.07M },
            new Invoice { Id = 101, ProductId = 2,  Quantity = 650, Price = 15.45M },
            new Invoice { Id = 102, ProductId = 3,  Quantity = 900, Price = 131.66M },
            new Invoice { Id = 103, ProductId = 4,  Quantity = 700, Price = 111.33M },
            new Invoice { Id = 104, ProductId = 3,  Quantity = 900, Price = 41.13M },
            new Invoice { Id = 105, ProductId = 4,  Quantity = 650, Price = 78.33M },
            new Invoice { Id = 106, ProductId = 1,  Quantity = 458, Price = 8.31M }
        };

    List<Participant> participantDemoList = new List<Participant>() {
                new Participant() { Id = 1, FullName = "Ivo Programerić", CourseId = 1 },
                new Participant() { Id = 2, FullName = "Ana Dizajnerić", CourseId = 1 },
                new Participant() { Id = 3, FullName = "Marko Sistemovski", CourseId = 3 },
                new Participant() { Id = 4, FullName = "Ana Programerić" , CourseId = 2 },
                new Participant() { Id = 5, FullName = "Ana Marija Matić" , CourseId = 2 },
                new Participant() { Id = 6, FullName = "Marko Stojanovski", CourseId = 1 },
                new Participant() { Id = 7, FullName = "Marija Grbić" } // there is no CourseID on purpose
            };

    List<Course> courseDemoList = new List<Course>() {
                new Course() { Id = 1, Title = "Learn Music Production From Scratch"},
                new Course() { Id = 2, Title = "How To Become A Gardening Pro In 30 Days"},
                new Course() { Id = 3, Title = "Microsoft Excel Ninja Course"}
            };


    IList<string> firstStringDemoList = new List<string>() {
                "One",
                "Two",
                "Three",
                "Four"
            };

    IList<string> secondStringDemoList = new List<string>() {
                "One",
                "Two",
                "Five",
                "Six"
            };
}


internal class Product
{
    public int Id { get; set; }
    public string Title { get; set; }
}

internal class Invoice
{
    public int Id { get; set; }
    public int ProductId { get; set; }
    public int Quantity { get; set; }
    public decimal Price { get; set; }
}

internal class Participant
{
    public int Id { get; set; }
    public string FullName { get; set; }
    public int CourseId { get; set; }
}


internal class Course
{
    public int Id { get; set; }
    public string Title { get; set; }
}