using System;
using System.Collections.Generic;
using System.Text;

namespace _14.ChapterFourteen
{
    public interface IPurchaseCommand
    {
        void ExecuteOperation();
        void RevertOperation();
    }
}
