using System;
using System.Collections.Generic;

namespace PrinterQueue
{
    class Program
    {
        static void Main(string[] args)
        {
            Queue<string> printerQueue = new Queue<string>();

            while (true)
            {
                string input = Console.ReadLine();

                if (input == "print")
                {
                    // Испечати ги сите преостанати фајлови во редот
                    while (printerQueue.Count > 0)
                    {
                        Console.WriteLine(printerQueue.Dequeue());
                    }
                    break;
                }
                else if (input == "cancel")
                {
                    if (printerQueue.Count > 0)
                    {
                        string canceledFile = printerQueue.Dequeue();
                        Console.WriteLine($"Canceled {canceledFile}");
                    }
                    else
                    {
                        Console.WriteLine("Standby");
                    }
                }
                else
                {
                    // Нов фајл - стави го во ред
                    printerQueue.Enqueue(input);
                }
            }
        }
    }
}
