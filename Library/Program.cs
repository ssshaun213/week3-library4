using Library;

Book book = new Book();

// This is info for the book class
book.Title = "C# for beginners";
book.Author = "Bill Gates";
book.ISBN = 12345678;
book.DisplayInfo();

// add a new book
Book book1 = new Book();

book1.Title = "C# for advanced";
book1.Author = "Steve Jobs";
book1.ISBN = 87654321;
book1.DisplayInfo();