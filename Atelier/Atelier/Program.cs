using System;

namespace Atelier
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var info = new Services.Info();
            var run = new Services.Run();

            var initial = new Services.InitialOperations();

            Models.EnterArray array = new Models.EnterArray();


            var forming = new Models.Forming();
            forming.Add(array.array);

            Console.WriteLine("Введите строку для поиска");

            string line = Console.ReadLine();
            Services.SearchExtension.Search(array.array, line);

            info.General();
            run.General();

            Services.Common common = new Services.Common();

            common.GetCut(new Services.Run());
            common.GetCount(new Services.Run());
        }
    }
}
