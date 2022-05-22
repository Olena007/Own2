using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atelier.Models
{
    internal class Forming 
    {
        public void Add(string[] array)
        {
            Services.InitialOperations initial = new Services.InitialOperations();

            string[] client = new string[1];
            string[] measure = new string[2];
            string[] features = new string[1];

            string [] arr = initial.LogIn(client).Concat(initial.Measure(measure)).ToArray();

            array = arr.Concat(initial.Options(features)).ToArray();
        }
    }
}
