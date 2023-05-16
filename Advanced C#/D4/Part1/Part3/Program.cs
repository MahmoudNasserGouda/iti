

namespace Part3
{

    public class Program
    {
        public static void Fun2(Button button)
        {
            button.ID = 20;
        }
        public static void Display(Button obj)
        {
            Console.WriteLine("Button Was Clicked");
        }
        public static void Main()
        {

            Button b = new Button();
            b.ID = 1;
            b.Name = "btnlogin";
            b.Text = "Login";
            b.OnClick = Display;
            b.OnClick += Fun2;
            b.Clicked();
            Console.WriteLine(b.ID);
            Console.ReadKey();
        }
    }
}