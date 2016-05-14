using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entities;
using Data;
using System.Configuration;

namespace BusinessLogic
{
    public class PrizesBL
    {
        private IPrizeDAO _prizesDAO;

        public PrizesBL()
        {
            if (ConfigurationSettings.AppSettings["UseDB"] == "True")
            {
                _prizesDAO = new PrizesSqlDAO();
            }
            else
            {
                _prizesDAO = new PrizesDAO();
            }
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
            return GetPrizesList();
        }
    }
}
