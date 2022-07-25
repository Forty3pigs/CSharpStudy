namespace Geekbrains
{
    public class TextAndMessage
    {
        private int[] _logoPosition = new int[2] { 24, 0 };
        private int[] _thxPosition = new int[2] { 0, 0 };
        private int[] _taskPosition = new int[2] { 20, 1 };
        private int[] _introPosition = new int[2] { 40, 10 };

        public void Print(string listForPrint)
        {
            Console.Clear();
            Console.SetCursorPosition(0, 0);
            if (listForPrint == "logo") ListsPrint(_logo, _logoPosition);
            if (listForPrint == "thx") ListsPrint(_thx, _thxPosition);
            if (listForPrint == "for") ListsPrint(_for, _thxPosition);
            if (listForPrint == "all") ListsPrint(_all, _thxPosition);

            Thread.Sleep(1500);
        }

        public void Intro()
        {
            ListsPrint(_tasks, _taskPosition);
            ListsPrint(_intro, _introPosition);
        }
        public int GetTaskListCount()
        {
            return (this._tasks.Count - 1) / 2;
        }

        public void TaskText(int N)
        {
            // Console.WriteLine();
            // Console.WriteLine();
            Console.SetCursorPosition(_taskPosition[0], 2);
            Console.WriteLine(_tasks[2 * N - 1]);
            Console.SetCursorPosition(_taskPosition[0], 3);
            Console.WriteLine(_tasks[2 * N]);
            //Console.SetCursorPosition(_introPosition[0], 4);
        }

        private void ListsPrint(List<string> list, int[] position)
        {
            for (int i = 0; i < list.Count; i++)
            {
                Console.SetCursorPosition(position[0], position[1] + i);
                Console.WriteLine(list[i]);
                Thread.Sleep(30);
            }

        }


        // public void ErrorEmptyInput() { Console.WriteLine(_errorMsgNull); }
        // public void ErrorArraySize() { Console.WriteLine(_errorMsgSize); }
        // public void GeneratedArray() { Console.WriteLine(_generatedArray); }
        // public void ResultedArray() { Console.WriteLine(_resultedArray); }
        public void TextWait()
        {
            Console.WriteLine(_wait);
            Console.ReadKey();
        }

        public void InputM()
        {
            //Console.SetCursorPosition(_introPosition[0], 5);
            Console.Write(_inputM);
            //Console.SetCursorPosition(_introPosition[0] + _inputM.Length
            //                       , 3);
        }

        public void InputN()
        {
            //Console.SetCursorPosition(_introPosition[0], 6);
            Console.Write(_inputN);
            //Console.SetCursorPosition(_introPosition[0] + _inputN.Length
            //                      , 6);
        }

        public void InputInvitation(string parameters)
        {
            Console.WriteLine(_caution);
            Console.Write($"\nEnter the {parameters} separated by a space or semicolon: ");
        }
        private List<string> _intro = new List<string>
        {
            " 1  for start Task 64",
            " 2  for start Task 66",
            " 3  for start Task 68",
            //"",
            "   Q    u    i    t  "
        };
        private List<string> _tasks = new List<string>
        {
            "",                                                                             // 0
            "Задача 64: Задайте значения M и N. Напишите программу, которая ",              // 1
            "           выведет все натуральные числа в промежутке от M до N. ",            // 2

            "Задача 66: Задайте значения M и N. Напишите программу, которая ",              // 3
            "           найдёт сумму натуральных элементов в промежутке от M до N.",        // 4

            "Задача 68: Напишите программу вычисления функции Аккермана ",                  // 5
            "           с помощью рекурсии. Даны два неотрицательных числа m и n."          // 6
        };

        private string _wait = "\nДля продолжения нажмите любую клавишу";
        private string _caution = "\nCaution: \nAll non numeric simbols will be equal to 0 \n" +
                                  "All negative numbers will be positive";
        private string _inputM = "Введите М: ";
        private string _inputN = "Введите N: ";

        // private string _errorMsgNull = "Error. Array size is null or empty";
        // private string _errorMsgSize = "Error. Array size problem";
        // private string _generatedArray = "Generated array:";
        // private string _resultedArray = "Resulted array:";

        private List<string> _logo = new List<string>
        {
            "",
            "                  @###*:----::####                    \n",
            "          .--+##--------------------+#@----.          \n",
            "        .-*#:--------------------------+#@%=%##-      \n",
            "       -#@-------------------------*%%===%%%+%%%#.    \n",
            "     -%@---------+===######@==----#%=@%-----*@%=%=    \n",
            "    -#-------:@%==%%%======%%%%#-#%%%--------%%%%#    \n",
            "   -#--------#%#=-----------#%+#-:=%%%-------#*%%--   \n",
            "  .#--------------#%===-----:%+#--*%%=@%%%%%==%@#*-.  \n",
            "  #----#%#---:##+==@#-------#%%#---#=%=%%%###=---#--  \n",
            " .#---#%+%:#==#%-----------#==@-----:@%=#---------#-  \n",
            " #----#%=%%#-----------:#%=%=+=%%%=%#-=%*=--------#-. \n",
            " #----*+%%----##*+--#%%%*%=###---#+%+%#=%%--------#-. \n",
            " #---:@=%#-#%=+%=--+%%##:---------#+=%-@%+#-------#-. \n",
            " #--@%%=%+=%@+-------------------@%+#--#=%@-------#-  \n",
            " .#--:%%=%=*--------%%==%######%*=%#---+%%+#------#-  \n",
            "  #--:**@%+=---------#@%=====%@##%-------##------#-   \n",
            "   #----#=%+#-----------------------------------#*.   \n",
            "    #----#=%%@---------------------------------@=. +# \n",
            "    #----#%@------------------------------@#%@%%*:%   \n",
            "      =@--------------------------+##%%=+%%+*#-       \n",
            "        #@---------------*##%%%%%+--------*#-         \n",
            "          %#-----*#%%%%=----------------#@-           \n",
            "        -#%%%=@#---------------------*##              \n",
            "                  @###..-----..####                   \n"

        };
        private List<string> _thx = new List<string>
        {
            "",
"          { ! !!!!!!!*!! !                                              ",
" !!+!!!!!!!$!!!!!!!!!!!!!! !    ?.!                                     ",
"!!!!!!!!!!!!!!!!!!!!!!!!!!!)   \\ !!!!                                   ",
"! !!!!@!##$!!!!!!               !!!!!/                                  ",
"           !!!!!!                !!!!!                                  ",
"           !{!!!!               ?!!/!/                                  ",
"           !!!!!!               !!!/!/                           #!@-   ",
"           !!!!!!               ?!!!!/!?            >>         !!!--!!  ",
"           !$!!!!               !!!!!!!!!!!\\       *!!!^!    $!!!}!!-+  ",
"            !!!]!^             ,!!!!!!!!!!!!|      >!!!!!] !!!!!!!!     ",
"            !!!!!              !!!!!!!!!!!!!!!      !*!!!!%!!{!!!       ",
"           {!!!!!               !!!!!/  !\\!!)!       !!!!!!!!!!}        ",
"           {!!!%[              !!!!!/   !!!!!!        !!^!!!$!          ",
"            {!!!!              !!!!!!   !\\!!!!!     *!!!!!!!!!          ",
"           {$!!!!             !!!!!!/    ,!!!!|    *!!!!!!!!!!!         ",
"            !!!!!^            !,!!!!    .!!!!!|   !!!!!!! !!!!!!        ",
"            !!!!!             !\\!!!!     ,!!!!| !!!!!>[   %]!!!!!#      ",
"              %                ,!!       !!!!! )<!(!!*      $!!!!       ",
"                                                (((!*                   ",
            ""
        };
        private List<string> _for = new List<string>
        {
            "",
"        !!!!!!!![!!*                                                    ",
"     !!}!#!!!!!!!!!!!*                                                  ",
"    ! - !!!}!!!!!!!!!!!!<                                               ",
"   !!!!!!!       !!!!!!                                                 ",
"  +!!!!!          !!!!!!                                                ",
"  !!!!!!          !!!!<!                                                ",
"   !!!!!           *!!!                                       !#!!      ",
"  +!!!!!#                        ?! !/?        !!!!!!     !%!!{!!!!!    ",
"   +!!@!!                      !!!!!!!!!!,!\\   )!!!!!!! !!!!{!!!!!!!!  ",
"    !!!!!!                  |!!\\!!!/!/!.!!!\\!   (!!!!!!!!!!!!{ ##!!!- ",
"     !!!!!!   ] ^!^!!* (    |!!!!!!     ?.!!!|!    (!!!!!!!!!{          ",
"     !!!!!!!!!!!!!!!!!<    |!!!!.       .!! !!|     >!!!!!!             ",
"      !!!!!!$]!!!!!!!!    )!!!!!         ,!!!!     !!!!!!!              ",
"     -!!!!!!!!!!^          !!!!!?       !!!\\!|     >!!!!!]             ",
"    @!!!!!!{!!]            !!\\!!.!   /!!!,!!!|      !!!!!              ",
"     !!!!!!!!!!!            )!!!!!!!!!!!!!!!       *!!!!!]              ",
"          !!!!!![             !!!!!/! !.!!\\        *!!!!!!             ",
"          $!!!!!!^                .//               !!!!!]              ",
"            !!!!!                                                       ",
"             !!]!^                                                      ",

            ""
        };
        private List<string> _all = new List<string>
        {
            "",
"                                   /!!!.!         !!!>!                 ",
"                                   !!!!!!        !!!!!![                ",
"                                   !!!!!!        !!!!!![                ",
"                                   !!!!!!        (!!!!!                 ",
"                                   /!!!!!         !!!!![                ",
"                                   !!!!!!        !!!!!!                 ",
"            {!!!!!!!!!!!           !!!!!?        !!!!!!                 ",
"           !!!!!!!!!!!!!!)         !!!!!!        (!!!!!                 ",
"           !$!!!!!!!!!<!!)         !!!!!!        !!!!!!                 ",
"            !%%      *!!!!)        !!!!!!        (!!!!!                 ",
"            !!!! !!  !<!!!         !!!!!!        !!!!!!                 ",
"          !!!!!!!!!!!!!!!!         !!!!!!        !!!!!!                 ",
"        !!$!!!!!!!!>!!!!!|         !!!!!!        !!!!!!                 ",
"       }!!!!!%    ^!!!!!!)        !!!!!!!       (!!!!!!                 ",
"       !!!!!$     !!!!!!!          !!!!!?        !!!!!!                 ",
"       #!!!!!    [!!!!!!!!!!!      !!!!!?        (!!!!!                 ",
"        #!!!!!!!!!!!!!!!!!!!!!    ?!!!!!!        !!!!!!                 ",
"         !!!!!!!!!!*!!!!!!!!!     ?!!!!!!        !!!!!!                 ",
"           {!!!!!!!* !(!!!)        !!!!!?        !!!!!!                 ",
""
        };
    }
}