using ConnectFour.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConnectFour.Service
{
    public interface IBoardService
    {
        void DropChecker(Board board,Checker checker, int collumn);
    }
}
