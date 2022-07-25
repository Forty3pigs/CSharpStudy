namespace Geekbrains
{
    static public class Homework
    {
        static public void Main()
        {
            //Console.Clear();
            int? choise;
            TextAndMessage tam = new TextAndMessage();
            Drow drow = new Drow();
            Tasks task = new Tasks();
            Console.SetWindowSize(100, 60);
            //print.Logo();
            Console.Clear();
            //Console.ReadKey();
            tam.Print("logo");
            tam.TextWait();
            Console.Clear();
            tam.Intro();
            choise = drow.Navigation(tam.GetTaskListCount());
            Console.WriteLine("Main choise = " + choise);
            if (choise != null)
            {
                int ch = Convert.ToInt32(choise);
                Console.WriteLine("Main ch =" + ch);
                task.Solution(tam, ch + 1);
                tam.TextWait();
            }
            Console.Clear();
            tam.Print("thx");
            tam.Print("for");
            tam.Print("all");
            //tam.TextWait();
            //else Main();
            //Console.Clear();
            //Console.WriteLine("n.Length");
            // string n = "                  @###*:----::####                    ";
            // Console.WriteLine(n.Length);
        }
    }

}