

using Part2;
using System.Collections;
using System.Diagnostics.CodeAnalysis;

public static class Program
{
    public delegate bool EmployeeHandler(Employee obj);
    public static ArrayList Search(Employee[] employees, EmployeeHandler filter)
    {
        ArrayList result = new ArrayList();
        foreach (Employee e in employees)
        {
            if (filter(e) == true)
            {
                result.Add(e);
            }
        }
        return result;
    }
    public static int Main()
    {


        DatabaseStorage db = new DatabaseStorage();
        ArrayList result = Search(db.Employees, i => i.Id > 0);


        Hashtable ht = new Hashtable();
        Console.WriteLine(ht.Count);


        foreach (Employee e in result)
            ht.Add(e, e);


        Employee ee = new Employee() { Id = 20, Name = "Ahmed" };
        Employee ee2 = new Employee() { Id = 20, Name = "Ahmed" };

        if(ee.Equals( ee2))
            Console.WriteLine("EQ");
        else
            Console.WriteLine("Not EQ");

       
        Console.WriteLine(ee.GetHashCode());
        Console.WriteLine(ee2.GetHashCode());
        ht.Add(new Employee() { Id = 20, Name = "Ahmed" }, ee);
        ht.Add(new Employee() { Id = 20, Name = "Ahmed" }, ee2);









        
        
        /*

        Console.WriteLine(ht.Count);

        ht.Remove(4);
        Console.WriteLine(ht.Count);
        foreach (DictionaryEntry entry in ht)
        {
            Console.WriteLine($"Key : {entry.Key}, Value: {((Employee)entry.Value).ToString()}");
        }
        Console.WriteLine();
        Console.WriteLine();
        Employee emp = (Employee)ht[1];
        Console.WriteLine(emp);


        Console.WriteLine();



        Employee E12 = new Employee() { Id = 1, Name = "Ahmed" };
        Employee E13 = new Employee() { Id = 1, Name = "Ahmed" };


        Console.WriteLine(E12.GetHashCode());
        Console.WriteLine(E13.GetHashCode());

        */

        #region Stack
        /*
        Stack s = new Stack(); 
        foreach (Employee e in result)
            s.Push(e);
        Employee E = (Employee) s.Pop();
        E = (Employee)s.Pop();
        Console.WriteLine( E);
        */


        #endregion
        #region Queue
        /*
        Queue empsQueue = new Queue();
        foreach (Employee e in result)
            empsQueue.Enqueue(e);
        //while (empsQueue.Count > 0)
        //    Console.WriteLine(((Employee)empsQueue.Dequeue()).ToString());
        foreach (Employee item in empsQueue)
        {
            Console.WriteLine(item.ToString());
        }
        Console.WriteLine(empsQueue.Count);

        /*
       Console.WriteLine(empsQueue.Count);
       Employee E = (Employee)  empsQueue.Dequeue();
       E = (Employee) empsQueue.Dequeue();
       Console.WriteLine(E.ToString());
       Console.WriteLine(empsQueue.Count);
        */
        #endregion
        #region ArrayList
        /*
        result.Capacity = result.Count;
        Console.WriteLine(result.Capacity);
        Console.WriteLine(result.Count);
        result.Add(new Employee() { Id = 8, Name = "Gamal" });
        result.AddRange(new Employee[] { new Employee(), new Employee() });
        result.RemoveAt(2);
        result.Add(10);
        result.Add("ITI");
        Console.WriteLine(result.Capacity);
        Console.WriteLine(result.Count);
        Console.WriteLine(result.Capacity);
        Console.WriteLine(result.Count);
        foreach (var e in result)
        {
            Console.WriteLine(e?.ToString());
        }
        Console.WriteLine();
        Console.WriteLine();
        Console.WriteLine();
        Employee EHany = (Employee)result[6];
        Console.WriteLine(EHany);
        Console.WriteLine();
        Console.WriteLine();
        Console.WriteLine();
        result.Clear();
        Console.WriteLine(result.Count);
        Console.WriteLine(result.Capacity);
        result.TrimToSize();
        result.Capacity = result.Count;
        Console.WriteLine(result.Count);
        Console.WriteLine(result.Capacity);
        result.Clear();
        result.Capacity = result.Count;
        result.Add(new Employee());
        */
        #endregion

        Console.ReadKey();





        return 0;
    }
}