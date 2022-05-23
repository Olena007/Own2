﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atelier.Services
{
    internal class Run : Services.Info, Interfaces.ICount, Interfaces.ICut
    {
        Models.Client client = new Models.Client();

        public void Count(string[] array)
        {
            int price = 0;

            if (array.Length >= 3)
            {
                string[] measure = array[2].Split(' ');

                string[] features = array[3].Split(' ');

                if (client.Request.ToString() == "Trousers")
                {
                    price = Convert.ToInt32(measure[0]) * Convert.ToInt32(measure[1]) * Convert.ToInt32(features[2]);
                }
                else if (client.Request.ToString() == "Dress")
                {
                    price = (Convert.ToInt32(measure[0]) + 50) * 70 * Convert.ToInt32(features[2]);
                }
                else if (client.Request.ToString() == "Skirt")
                {
                    price = Convert.ToInt32(measure[0]) * 50 * Convert.ToInt32(features[2]);
                }
                else if (client.Request.ToString() == "Shirt")
                {
                    price = ((Convert.ToInt32(measure[0]) * 80) + (Convert.ToInt32(measure[1]) * 8)) * Convert.ToInt32(features[2]);
                }

                Console.WriteLine(price);
            }
        }

        public void Cut()
        {
            Console.WriteLine("Measurements taken and fabric prepared");
        }

        public override void General()
        {
            Console.WriteLine("Finished tailoring!");
        }
    }
}
