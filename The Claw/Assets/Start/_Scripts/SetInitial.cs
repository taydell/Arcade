using UnityEngine;
using System.Collections;


namespace Assets._Scripts
{
    public class SetInitial : MonoBehaviour
    {
        private Objects people;

        void Awake()
        {
            people = GameObject.Find("Objects").GetComponent<Objects>();

            people.player.SetMoney(5.00);
            people.player.SetTickets(0);
            people.bully.SetMoney(100);
            people.bully.SetTickets(0);
        }

        // Use this for initialization
        void Start()
        {

        }

        // Update is called once per frame
        void Update()
        {

        }
    }
}
