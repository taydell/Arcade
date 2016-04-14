using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class Gotomainscene : MonoBehaviour 
{
	void Update () 
    {
        if (Input.GetKeyDown(KeyCode.Alpha1))
        {
            SceneManager.LoadScene("Arcade");
        }
	}
}
