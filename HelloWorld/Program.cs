using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloWorld
{
    internal class Program
    {/// <summary>
    /// Точка входа! Код, который выполняется в первую очередь :)
    /// </summary>
    /// <param name="args"></param>
        static void Main(string[] args)
        {
            /// Задание 1.
            /// Комментарий к Заданию 1. Очень важно писать текст именно в двойных кавычках 
            /// и не забывать точку после Console, иначе будут ошибки CS1011, CS1012
            Console.WriteLine("Hello World !!!");
            Console.ReadKey();
            /// Задание 2.
            /// Комментарий к Заданию 2. Я не сразу поняла, что оба задания должны быть в одном файле
            //Чтобы выводились слова после нажатия Enter, нужно включить в каждую следующую строку - 
            //слово из предыдущей. Обязательно нужно поставить пробел, чтобы слова не слипались.
            // И не забыть Console.ReadKey после каждой строки.
            Console.Write(" Hello ");
            Console.ReadKey();
            Console.Write(" Hello World ");
            Console.ReadKey();
            Console.Write(" Hello World !!! ");
            Console.ReadKey();

        }
    }
}
