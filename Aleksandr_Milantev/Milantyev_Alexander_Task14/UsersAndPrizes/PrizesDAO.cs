using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entities;

namespace Data
{
    public class PrizesDAO : IPrizeDAO
    {
        private List<Prize> _prizes = new List<Prize>();

        public void AddPrize(Prize prize)
        {
            if (prize == null)
            {
                throw new ArgumentException("null prize");
            }
            _prizes.Add(prize);
        }

        public void ChangePrize(Prize oldPrize, Prize newPrize)
        {
            int index = _prizes.IndexOf(oldPrize);
            _prizes[index] = newPrize;
        }

        public void DeletePrize(Prize prize)
        {
            _prizes.Remove(prize);
        }

        public IEnumerable<Prize> GetPrizeList()
        {
            return _prizes;
        }
    }
}
