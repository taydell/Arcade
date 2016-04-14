using UnityEngine;
using System.Collections;



namespace Assets._Scripts
{

    public class People
    {
        private double _money;
        private int _tickets;

        public double GetMoney()
        {
            return _money;
        }

        public void SetMoney(double money)
        {
            this._money = money;
        }

        public int GetTickets()
        {
            return _tickets;
        }

        public void SetTickets(int tickets)
        {
            this._tickets = tickets;
        }
    }
}
