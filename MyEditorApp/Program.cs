using MyEditorLibrary;
using System;
using System.Collections.Generic;

namespace MyEditorApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter imeges count: ");
            var countPhoto = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter worker count: ");
            var workerCount = int.Parse(Console.ReadLine());

            var workerSpeds = new List<int>();
            for (var i = 1; i <= workerCount; i++)
            {
                Console.WriteLine($"Enter {i} worker's speed: ");
                workerSpeds.Add(int.Parse(Console.ReadLine()));
            }

            var editor = new EditorServices(countPhoto, workerSpeds);
            var result = editor.Process();

            var seconds = result.TotalMinutes * 60;
            var h = seconds / 3600;
            var m = (seconds - 3600 * h) / 60;

            Console.WriteLine($"\nSum time took : {h} h {m} m\n\n");

            for (var i = 1; i <= result.ProcessedImeges.Count; i++)
            {
                Console.WriteLine($"{i} worker edited {result.ProcessedImeges[i - 1]} photos\n");
            }

            Console.ReadLine();
        }
    }
}
