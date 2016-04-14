using UnityEngine;
using System.Collections;

public class ButtonController : MonoBehaviour 
{
	Ray ray;
	RaycastHit hit;

	bool buttonDown;
	bool buttonUp;
	
	// Update is called once per frame
	void Update () 
	{

		ray = Camera.main.ScreenPointToRay(Input.mousePosition);
		if(Physics.Raycast(ray,out hit))
		{
			if(hit.collider.tag == "Button")
			{

				if(Input.GetMouseButtonDown(0))
				{
					buttonDown = true;
					Debug.Log("Hit");
				}
				else
				{
					buttonDown = false;
				}
				if(Input.GetMouseButtonUp(0))
				{
					buttonUp = true;
				}
				else
				{
					buttonUp = false;
				}
			}
		
		}
		ButtonCheck();
	}

	void ButtonCheck()
	{
		if(buttonDown == true)
		{
			GetComponent<Animation>().Play("ButtonDown");
		}
		if(buttonUp == true)
		{
			GetComponent<Animation>().Play("ButtonUp");
		}
	}
}
