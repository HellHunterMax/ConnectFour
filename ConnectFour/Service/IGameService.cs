using ConnectFour.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConnectFour.Service
{
    public interface IGameService
    {
        public void CheckGameEnd(Board board);
    }
}
