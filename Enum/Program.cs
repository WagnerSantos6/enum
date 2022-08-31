﻿using System;
using Enum.Entities;
using Enum.Entities.Enums;

namespace Enum
{
    class Program
    {
        static void Main(string[] args)
        {
            Order order = new Order
            {
                Id = 500,
                Moment = DateTime.Now,
                Status = OrderStatus.PendingPayment
            };
            Console.WriteLine(order);

            string txt = OrderStatus.Shipped.ToString();

            

            Console.WriteLine(txt);

            
            
        }
    }
}
