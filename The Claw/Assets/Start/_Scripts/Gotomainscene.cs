using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class Gotomainscene : MonoBehaviour 
{
    public void LoadScene(string level)
    {
        Debug.Log("ayy");
        SceneManager.LoadScene(level);
    }
}
