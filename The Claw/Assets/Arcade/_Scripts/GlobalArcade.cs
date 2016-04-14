using UnityEngine;
using System.Collections;
using UnityEngine.UI;

namespace Assets._Scripts
{
     

    public class GlobalArcade : MonoBehaviour
    {
        private Objects people;
        public Text Tickets;
        public Text Money;

        void Awake()
        {

            people = GameObject.Find("Objects").GetComponent<Objects>();

            
        }

        void Start()
        {
            Debug.Log(people.player.GetMoney());
            Debug.Log(people.bully.GetMoney());
            SetScreenText();
        }

        // Update is called once per frame

        public void SetScreenText()
        {
            Tickets.text = "Tickets: " + people.player.GetTickets();
            Money.text = "Money: $" + people.player.GetMoney();
        }
    }

}