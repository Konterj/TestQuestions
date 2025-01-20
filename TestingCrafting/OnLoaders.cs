using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestingCrafting
{
    public class OnLoaders
    {
        public void OnAnimatedLoader()
        {
            List<string> Loader = new List<string>() { "Load","Load.", "Load..", "Load..." };
            Console.Beep(2500, 200);

            for (int repeat = 0; repeat < 3; repeat++) // Количество повторений
            {
                foreach (string frame in Loader)
                {
                    Console.Write("\r" + frame); // Перезаписываем строку
                    Thread.Sleep(200);          // Задержка между кадрами
                    Console.Beep(2500, 200);    // Звук
                }

                // Очищаем строку после завершения цикла анимации
                Console.Write("\r" + new string(' ', Console.WindowWidth) + "\r");
            }
        }



    }
}
