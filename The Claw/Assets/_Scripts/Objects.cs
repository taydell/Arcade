using UnityEngine;
using System.Collections;

namespace Assets._Scripts
{
    public class Objects : MonoBehaviour
    {
        public People player = new People();
        public People bully = new People();
        void Awake()
        {
            DontDestroyOnLoad(transform.gameObject);
           
           
        }

        public void load()
        {
            
        }
    }

}


