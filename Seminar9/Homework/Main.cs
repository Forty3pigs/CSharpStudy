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
            Console.SetWindowSize(120, 60);
            //print.Logo();
            //Console.Clear();
            //Console.ReadKey();
            tam.Intro();
            choise = drow.Navigation(tam.GetTaskListCount());
            Console.WriteLine("Main choise = " + choise);
            if (choise != null)
            {
                int ch = Convert.ToInt32(choise);
                Console.WriteLine("Main ch =" + ch);
                task.Solution(tam, ch);
                Console.ReadKey();
            }
            //else Main();
            //Console.Clear();
            //Console.WriteLine("n.Length");
            // string n = "                  @###*:----::####                    ";
            // Console.WriteLine(n.Length);
        }
    }

}