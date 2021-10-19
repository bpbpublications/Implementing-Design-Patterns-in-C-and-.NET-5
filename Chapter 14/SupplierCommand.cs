using System;
using System.Collections.Generic;
using System.Text;

namespace _14.ChapterFourteen
{
    public class SupplierCommand : IPurchaseCommand
    {
        private readonly Purchase _purchase;

        public SupplierCommand(Purchase purchase)
        {
            this._purchase = purchase;
        }

        public void ExecuteOperation()
        {
            Console.WriteLine("Operation to notify the supplier");
        }

        public void RevertOperation()
        {
            Console.WriteLine("Something failed in the supplier notification");
        }
    }
}
