﻿using System;

namespace csharp_intermediate
{
    public class Customer
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public void Promote()
        {
            //var rating = CalculateRating(excludeOrders: true);
            //if (rating == 0)
            //    Console.WriteLine("Promoted to Level 1");
            //else
            //    Console.WriteLine("Promoted to Level 2");
            Console.WriteLine("Promote logic change");
        }

        //protected int CalculateRating(bool excludeOrders)
        //{
        //    return 0;
        //}
    }
}
