using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class LoadGame : MonoBehaviour 
{

    void loadSkeeball()
    {
        SceneManager.LoadScene("Skeeball");
    }
    void loadGalaga()
    {
        SceneManager.LoadScene("Galaga");
    }
    void loadClaw()
    {
        SceneManager.LoadScene("Main");
    }
    void loadShop()
    {
        SceneManager.LoadScene("Shop");
    }

    void OnTriggerStay(Collider other)
    {
        if (other.tag.Equals("Player"))
        {
            if (GetComponentInParent<LoadGame>().tag.Equals("Galaga") && Input.GetKeyDown(KeyCode.A))
            {
                loadGalaga();
            }
            else if (GetComponentInParent<LoadGame>().tag.Equals("Skeeball") && Input.GetKeyDown(KeyCode.A))
            {
                loadSkeeball();
            }
            else if (GetComponentInParent<LoadGame>().tag.Equals("Claw") && Input.GetKeyDown(KeyCode.A))
            {
                loadClaw();
            }
            else if (GetComponentInParent<LoadGame>().tag.Equals("Shop") && Input.GetKeyDown(KeyCode.A))
            {
                loadShop();
            }
        }
    }
}
