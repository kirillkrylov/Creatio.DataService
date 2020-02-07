using System;
using System.Collections.Generic;
using System.Text;

namespace ModelBuilder
{
    public static class ConsoleWriter
    {


        public static void WriteMessage(MessageType type, string message) {


            switch (type)
            {
                case MessageType.OK:
                    OkMessage(message);
                    break;
                case MessageType.Error:
                    ErrorMessage(message);
                    break;
                case MessageType.Warning:
                    break;
                case MessageType.Info:
                    InfoMessage(message);
                    break;
                case MessageType.Detail:
                    DetailMessage(message);
                    break;
                case MessageType.Try:
                    TryMessage(message);
                    break;



                default:
                    break;
            }
        }

        private static void OkMessage(string message) {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.Write(Properties.Resources.okTag);
            Console.ResetColor();
            Console.Write($"\t\t{message}");
            Console.WriteLine();
        }
        private static void ErrorMessage(string message) 
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.Write(Properties.Resources.errorTag);
            Console.ResetColor();
            Console.Write($"\t\t{message}");
            Console.WriteLine();
        }
        private static void TryMessage(string message)
        {
            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.White;
            Console.Write(Properties.Resources.tryTag);
            Console.ResetColor();
            Console.Write($"\t\t{message}");
            Console.WriteLine();
        }
        private static void InfoMessage(string message) {
            Console.ResetColor();
            Console.Write(Properties.Resources.infoTag);
            Console.Write($"\t\t{message}");
            Console.WriteLine();
        }

        private static void DetailMessage(string message) {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.Write(Properties.Resources.detailTag);
            Console.ResetColor();
            Console.Write($"\t\t\t{message}");
        }
    }
}
