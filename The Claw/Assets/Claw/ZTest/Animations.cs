using UnityEngine;
using System.Collections;

public class Animations : MonoBehaviour 
{
	//Animator anim;
	bool buttonDown;
	bool buttonUp;
	//bool buttonIsDown;

	// Use this for initialization
	void Start () 
	{
		//Animating();
	}
	
	// Update is called once per frame
	void Update () 
	{
		if(buttonDown == true)
		{
			GetComponent<Animation>().Play("ButtonDown");
		}
		if(buttonUp == true)
		{
			GetComponent<Animation>().Play("ButtonUp");
		}

		if(Input.GetKeyDown(KeyCode.Alpha0))
		{
			buttonDown = true;
		}
		else
		{
			buttonDown = false;
			//buttonUp = true;
		}
		if(Input.GetKeyUp(KeyCode.Alpha0))
		{
			buttonUp = true;
		}
		else
		{
			buttonUp = false;
		}
		//animation_bool = false;

	}
	void Awake()
	{
		//anim = GetComponent<Animator>();
	}
	void Animating()
	{
		bool clicked = true;
		//anim.SetBool("IsClicked",true);
	}
}
