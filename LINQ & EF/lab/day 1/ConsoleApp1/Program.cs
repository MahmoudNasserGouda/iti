namespace LINQtoObject
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var Q1 = SampleData.Books.Select(x => new { x.Title, x.Isbn });
            foreach (var x in Q1)
                Console.WriteLine(x);


            var Q2 = SampleData.Books.Where(x => x.Price > 25).Take(3);
            foreach (var x in Q2)
                Console.WriteLine(x);


            var Q3_1 = from c in SampleData.Books
                       join d in SampleData.Publishers
                       on c.Publisher equals d
                       select new { c.Title, c.Publisher.Name };
            foreach (var x in Q3_1)
                Console.WriteLine(x);

            var Q3_2 = from c in SampleData.Books
                       from d in SampleData.Publishers
                       where c.Publisher == d
                       select new { c.Title, c.Publisher.Name };
            foreach (var x in Q3_2)
                Console.WriteLine(x);


            var Q4 = SampleData.Books.Where(x => x.Price > 20).Count();
            Console.WriteLine(Q4);


            var Q5 = from c in SampleData.Books
                     from d in SampleData.Subjects
                     where c.Subject == d
                     orderby c.Subject.Name ascending, c.Price descending
                     select new { c.Title, c.Price, c.Subject.Name };
            foreach (var x in Q5)
                Console.WriteLine(x);


            var Q6_1 = from d in SampleData.Subjects
                       select new
                       {
                           d.Name,
                           Books = (from e in SampleData.Books
                                    where e.Subject.Name == d.Name
                                    select e.Title).ToList()
                       };
            foreach (var x in Q6_1)
            {
                Console.Write("{" + x.Name + ":");
                foreach (var y in x.Books)
                {
                    Console.Write(y + ",");
                }
                Console.Write("}\n");
            }

            var Q6_2 = from s in SampleData.Subjects
                       join b in SampleData.Books on s equals b.Subject into booksBySubject
                       select new
                       {
                           SubjectName = s.Name,
                           BookTitles = booksBySubject.Select(b => b.Title).ToList()
                       };
            foreach (var x in Q6_2)
            {
                Console.Write("{" + x.SubjectName + ":");
                foreach (var y in x.BookTitles)
                {
                    Console.Write(y + ",");
                }
                Console.Write("}\n");
            }


            var Q7 = from Book b in SampleData.GetBooks()
                     select new { b.Title, b.Price };
            foreach (var x in Q7)
                Console.WriteLine(x);


            var Q8 = from b in SampleData.Books
                     group b by new { b.Publisher, b.Subject } into g
                     select new
                     {
                         PublisherName = g.Key.Publisher,
                         SubjectName = g.Key.Subject,
                         BookTitles = g.Select(b => b.Title).ToList()
                     };

            foreach (var result in Q8)
            {
                Console.WriteLine($"Publisher: {result.PublisherName}");
                Console.WriteLine($"Subject: {result.SubjectName}");
                foreach (var bookTitle in result.BookTitles)
                {
                    Console.WriteLine($"- {bookTitle}");
                }
            }
        }
    }
}