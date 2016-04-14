using UnityEngine;
using System.Collections;
using Assets._Scripts;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

namespace Assets._Scripts
{
    public class GalagaGUI : MonoBehaviour
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

        void OnTriggerStay(Collider other)
        {
            if (other.tag.Equals("Player"))
            {
                if (Input.GetKeyDown(KeyCode.Alpha1))
                {
                    money -= .25;
                    tickets += 5;
                    people.player.SetMoney(money);
                    people.player.SetTickets(tickets);

                    SetScreenText();
                }
                if (Input.GetKeyDown(KeyCode.B))
                {
                    SceneManager.LoadScene("Arcade");
                }

            }
        }

        void SetScreenText()
        {
            Tickets.text = "Tickets: " + people.player.GetTickets();
            Money.text = "Money: $" + people.player.GetMoney();
        }
    }
}