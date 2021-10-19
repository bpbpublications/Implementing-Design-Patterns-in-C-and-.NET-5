﻿using System;
using System.Collections.Generic;
using System.Text;

namespace _6.ChapterSix6._1.OpenClosedPrinciple
{
    class PlatformAccount : IPlatformAccount
    {
        public Customer Generate(User user)
        {
            var customer = new Customer()
            {
                FullName = user.FullName,
                Active = user.Active,
                Email = user.Email
            };

            if (customer.IsPremiumAccount)
            {
                GenerateAccount(customer);
            }


            return customer;
        }

        private void GenerateAccount(Customer customer)
        {
            //Custom implementation for premium account
        }
    }
}
