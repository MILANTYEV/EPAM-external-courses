using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entities;

namespace Data
{
    public interface IPrizeDAO
    {
        void AddPrize(Prize prize);
        void ChangePrize(Prize oldPrize, Prize newPrize);
        void DeletePrize(Prize prize);
        IEnumerable<Prize> GetPrizeList();
    }
}
