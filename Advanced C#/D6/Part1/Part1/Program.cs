

using Part1;
using System.Collections.Generic;
using System.Security.Cryptography;



public static class Program
{
    /*
    public delegate bool EntityHandler<T>(T order);
    public static List<T> WhereITI<T>(this IEnumerable<T> source, EntityHandler<T> handler)
    {
        List<T> result = new List<T>();
        foreach (T entity  in source)
        {
            if(handler(entity))
                result.Add(entity);
        }
        return result;
    }
    */
    public static int Main()
    {

        Order O1 = new Order()
        {
            Id = 1,
            Customer = new Customer()
            {
                Id = 1,
                Name = "Hany"
            },
            Price = 300,
            Items = new List<OrderItem>
            {
                new OrderItem()
                {
                    Id=1,
                    Item= new Item(){Id=1, Name="Pizza"},
                    Quantity=2
                },
                new OrderItem()
                {
                    Id=2,
                    Item= new Item(){Id=2, Name="Pepsi"},
                    Quantity=1
                }
            }

        };
        Order O2 = new Order()
        {
            Id = 2,
            Customer = new Customer()
            {
                Id = 2,
                Name = "Dalia"
            },
            Price = 500,
            Items = new List<OrderItem>
            {
                new OrderItem()
                {
                    Id=1,
                    Item= new Item(){Id=1, Name="Pizza"},
                    Quantity=2
                },
                new OrderItem()
                {
                    Id=2,
                    Item= new Item(){Id=2, Name="Pepsi"},
                    Quantity=1
                },
                new OrderItem()
                {
                    Id=3,
                    Item= new Item(){Id=3, Name="Mixed Grill"},
                    Quantity=1
                }
            }

        };

        List<Order> Orders = new List<Order>() { O1, O2 };

        // Extension Methods
        var result = 
                Orders.Where(o => o.Price > 100).OrderByDescending(i=>i.Id)
                .Select(i=> new  { ID=i.Id, Price=i.Price }).Skip(1).Take
                (2);

        foreach (var o in result)
            Console.WriteLine(o);






        // Query Expression
        //IEnumerable<Order> result  = 
        //                    from Os in Orders
        //                    where Os.Price > 350
        //                    select Os;




        //Order o2  = Orders.FirstOrDefault(i=>i.Customer.Name=="Dalia");
        //Console.WriteLine(o2);


        #region C# Features that Enabled LINQ
        /*

        int[] Arr = new int[] { 900, 39, 900 };
        IEnumerable<int> x = Arr.Where(i => i == 900);
        


       
        /*
        var Query = from ords in Orders
                    where ords.Price > 100
                    select new
                    {
                        Name = ords.Customer.Name,
                        Price = ords.Price
                    };

        //foreach (var o in Query)
        //    Console.WriteLine($"Name: {o.Name}, Price:{o.Price}");

        var enumerator  =   Query.GetEnumerator();
        while (enumerator.MoveNext())
        {
            Console.WriteLine(enumerator.Current.Name);
        }

        Console.WriteLine();
        Console.WriteLine();
        Console.WriteLine();
        Console.WriteLine();
        Console.WriteLine();

        CustomerList eL = new CustomerList();
        eL.Add(1, new Customer() { Id = 1, Name = "Ahmed" });
        eL.Add(2, new Customer() { Id = 2, Name = "Hany" });
        
        foreach(var item in eL)
        {
            Customer obj = (Customer)item;
            Console.WriteLine(obj?.Name);
        }

        Console.WriteLine();
        Console.WriteLine();
        Console.WriteLine();
        */
        #endregion


        CustomerList eL = new CustomerList();
        eL.Add(1, new Customer() { Id = 1, Name = "Ahmed" });
        eL.Add(2, new Customer() { Id = 2, Name = "Hany" });

        foreach (var item in eL)
        {
            Console.WriteLine(item.Name);
        }



        return 0;
    }
}