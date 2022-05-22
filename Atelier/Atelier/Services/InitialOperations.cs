using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atelier.Services
{
    internal class InitialOperations
    {
        Models.Measurements measurements = new Models.Measurements();
        Models.Features features = new Models.Features();

        public string[] LogIn(string[] arr)
        {
            Console.WriteLine("Customer information:");

            Console.Write("Name: ");
            string name = Console.ReadLine();

            Console.Write("Surname: ");
            string surname = Console.ReadLine();

            Console.Write("Gender: ");
            string gender = Console.ReadLine();

            Models.Client client = new Models.Client(name, surname, gender, null);

            for (int i = 0; i < arr.Length; i++)
            {
                if (i == 0)
                {
                    arr[i] = $"{client.Surname}";
                }
            }

            return arr;
        }

        public string[] Measure(string[] arr)
        {
            Console.Write("Clothing request: ");
            string request = Console.ReadLine();

            Models.Client client = new Models.Client(null, null, null, request);

            Console.WriteLine("Parameters: ");

            if (client.Request.ToString() == "Trousers")
            {
                Console.Write("Hips (cm): ");
                int hips = Convert.ToInt32(Console.ReadLine());

                Console.Write("Leg length (см): ");
                int legs = Convert.ToInt32(Console.ReadLine());

                Models.Measurements measure = new Models.Measurements(hips, legs, false);

                for (int i = 0; i < arr.Length; i++)
                {
                    if (i == 0)
                    {
                        arr[i] = $"{client.Request}";
                    }
                    else if (i == 1)
                    {
                        arr[i] = $"{measure.Hips} {measure.LegLength}";
                    }
                }

                return arr;
            }
            else if (client.Request.ToString() == "Dress")
            {
                Console.Write("Torso length (см): ");
                int torso = Convert.ToInt32(Console.ReadLine());

                Models.Measurements measure = new Models.Measurements(torso, false);

                for (int i = 0; i < arr.Length; i++)
                {
                    if (i == 0)
                    {
                        arr[i] = $"{client.Request}";
                    }
                    else if (i == 1)
                    {
                        arr[i] = $"{measure.TorsoLength}";
                    }
                }

                return arr;
            }
            else if (client.Request.ToString() == "Skirt")
            {
                Console.Write("Hips (см): ");
                int hips = Convert.ToInt32(Console.ReadLine());

                Models.Measurements measure = new Models.Measurements(hips, true);

                for (int i = 0; i < arr.Length; i++)
                {
                    if (i == 0)
                    {
                        arr[i] = $"{client.Request}";
                    }
                    else if (i == 1)
                    {
                        arr[i] = $"{measure.Hips}";
                    }
                }

                return arr;
            }
            else if (client.Request.ToString() == "Shirt")
            {
                Console.Write("Torso length (см): ");
                int torso = Convert.ToInt32(Console.ReadLine());

                Console.Write("Arm length (см): ");
                int arm = Convert.ToInt32(Console.ReadLine());

                Models.Measurements measure = new Models.Measurements(torso, arm, true);

                for (int i = 0; i < arr.Length; i++)
                {
                    if (i == 0)
                    {
                        arr[i] = $"{client.Request}";
                    }
                    else if (i == 1)
                    {
                        arr[i] = $"{measure.TorsoLength} {measure.ArmLength}";
                    }
                }

                return arr;
            }

            return null;
        }

        public string[] Options(string[] arr)
        {
            Console.WriteLine("Features:");

            Console.Write("Type: ");
            string type = Console.ReadLine();

            Console.Write("Color: ");
            string color = Console.ReadLine();

            Console.Write("Material: ");
            string material = Console.ReadLine();

            Console.Write("Price: ");
            int price = Convert.ToInt32(Console.ReadLine());

            Models.Features features = new Models.Features(type, color, material, price);

            for (int i = 0; i < arr.Length; i++)
            {
                if (i == 0)
                {
                    arr[i] = $"{features.Color} {features.Material} {features.Price}";
                }
            }

            return arr;
        }
    }
}
