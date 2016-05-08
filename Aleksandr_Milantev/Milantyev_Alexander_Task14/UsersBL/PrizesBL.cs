using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entities;
using Data;

namespace BusinessLogic
{
    public class PrizesBL
    {
        private IPrizeDAO _prizesDAO;

        public PrizesBL()
        {
            _prizesDAO = new PrizesDAO();
        }

        private int CalculateNewID()
        {
            int lastId = 0;
            foreach (var prize in _prizesDAO.GetPrizeList())
            {
                if (prize.ID > lastId)
                {
                    lastId = prize.ID;
                }
            }
            return lastId + 1;
        }

        public Prize CreatePrize(string title, string description = "")
        {
            int ID = CalculateNewID();
            Prize prize = new Prize(ID, title, description);
            return prize;
        }

        public void AddPrize(Prize prize)
        {
            if (prize == null)
            {
                throw new ArgumentException("Null prize");
            }
            _prizesDAO.AddPrize(prize);
        }

        public void ChangePrize(Prize oldPrize, Prize newPrize)
        {
            if (oldPrize == null || newPrize == null)
            {
                throw new ArgumentException("Null prize");
            }
            _prizesDAO.ChangePrize(oldPrize, newPrize);
        }

        public void DeletePrize(Prize prize, UsersBL users)
        {
            if (prize == null)
            {
                throw new ArgumentException("Null prize");
            }
            _prizesDAO.DeletePrize(prize);
            foreach (var user in users.GetUsersList())
            {
                user.PrizesList.Remove(prize);
            }
        }

        public IEnumerable<Prize> GetPrizesList()
        {
            return _prizesDAO.GetPrizeList();
        }

        public IEnumerable<Prize> InitList()
        {
            AddPrize(CreatePrize("Nobel prize", "The best award"));
            AddPrize(CreatePrize("Diploma"));
            return GetPrizesList();
        }
    }
}
