
using System.Collections;
using System.Collections.Generic;
public static class Program
{
    public static int Main()
    {
        /*
                Dynamic Size , Dynamic Type
                ArrayList ->   List 
                Queue -> Queue 
                Stack -> Stack 
                HashTable  -> Dictionary 
         */
        ArrayList list = new ArrayList();
        list.Add(10);
        list.Add("Ahmed");
        list.Add(new object());
        list.Add(new Random());

        string name = (string)list[1];
        Console.WriteLine(name);
        Console.WriteLine();

        Console.WriteLine();


        List<string> MyList = new List<string>();
        MyList.Add("Ahmed");

        Queue<int> Q = new Queue<int>();
        Dictionary<int, string> dic = new Dictionary<int, string>();
        dic.Add(10, "Ahmed");


        Dictionary<object, object> obj
            = new Dictionary<object, object>();
        obj.Add("", 10);

    


        return 0;
    }
}