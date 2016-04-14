using UnityEngine;
using System.Collections;
using Assets._Scripts;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

namespace Assets._Scripts
{
    public class ClawGUI : MonoBehaviour
    {
        private Objects people;

        private double money;
        private int tickets;

        public Text Tickets;
        public Text Money;
        // Use this for initialization
        void Awake()
        {
            people = GameObject.Find("Objects").GetComponent<Objects>();
        }
        void Start()
        {

            money = people.player.GetMoney();
            tickets = people.player.GetTickets();
            SetScreenText();

        }

        // Update is called once per frame
        void Update()
        {

        }

        void SetScreenText()
        {
            Tickets.text = "Tickets: " + people.player.GetTickets();
            Money.text = "Money: $" + people.player.GetMoney();
        }
    }
}