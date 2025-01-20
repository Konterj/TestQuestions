using TestingCrafting;

class StartProgram
{
    static void Main(string[] args)
    {
        Console.BackgroundColor = ConsoleColor.Black;
        Console.ForegroundColor = ConsoleColor.Green;

        string Press;
        OnLoaders Loaders = new();
        Loaders.OnAnimatedLoader();
        Thread.Sleep(200);
        Console.WriteLine("Almost of ready");
        Questions _Question = new();
        bool IsRepeat = true;
        Console.Beep(2500, 1000);
        Console.WriteLine("                               \r\n,--------.              ,--.   \r\n'--.  .--',---.  ,---.,-'  '-. \r\n   |  |  | .-. :(  .-''-.  .-' \r\n   |  |  \\   --..-'  `) |  |   \r\n   `--'   `----'`----'  `--'   \r\n                               ");
        Console.WriteLine("\nVer 0.0.2");
        Console.WriteLine("By Den" +
            "\nQuestions 62\n" +
            "RUS: Вопросов 62\n");
        Console.WriteLine("========================================");
        Console.WriteLine("|                                        |");
        Console.WriteLine("|       Добро пожаловать в программу!    |");
        Console.WriteLine("|                                        |");
        Console.WriteLine("========================================\n");

        Console.WriteLine(
            "Данная программа предназначена для:\n" +
            "- Запоминания и усвоения материала;\n" +
            "- Помощи в изучении ключевых тем.\n"
        );

        Console.WriteLine(
            "Важно:\n" +
            "----------------------------------------\n" +
            "Если вы ответили частично правильно и\n" +
            "ваши слова передают смысл ответа, это\n" +
            "считается правильным шагом на пути к\n" +
            "освоению материала.\n"
        );

        Console.WriteLine("========================================");
        Console.WriteLine("|      Удачи в вашем обучении!          |");
        Console.WriteLine("========================================");
        Console.WriteLine("\n");


        Console.Beep(3000, 500);
        while (IsRepeat) 
        {
            Console.Beep(1800, 250);
            Console.WriteLine("Write to Y/N for continue?");
            Console.WriteLine("Напишите Y/N чтобы начать");

            Press = Console.ReadLine();
            if (Press == "Y")
            {
                Console.Clear();
                Console.Beep(1500, 250);
                _Question.OnChekedQuestion();
                IsRepeat = false;
            }
            else if (Press == "N")
            {
                Console.Clear();
                Console.Beep(1000, 250);
                return;
            }
            else
            {
                Console.Clear();
                Console.Beep(1300, 250);
                IsRepeat = true;
            }
        }
    }
}