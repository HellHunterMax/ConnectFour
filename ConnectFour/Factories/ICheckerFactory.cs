using ConnectFour.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConnectFour.Factories
{
    public interface ICheckerFactory
    {
        Checker Create(Board board);
    }
}
