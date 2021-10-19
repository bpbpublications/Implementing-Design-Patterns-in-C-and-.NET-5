using System;
using System.Collections.Generic;
using System.Text;

namespace _6.ChapterSix6._1.OpenClosedPrinciple
{
    class PremiumPlatformAccount : IPlatformAccount
    {
        public Customer Generate(User user)
        {
            var customer = new Customer()
            {
                FullName = user.FullName,
                Active = user.Active,
                Email = user.Email
            };

            GeneratePremiumAccount(customer);
            
            return customer;
        }

        private void GeneratePremiumAccount(Customer customer)
        {
            //Custom implementation for premium account
        }
    }
}
