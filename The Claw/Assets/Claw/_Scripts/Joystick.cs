using UnityEngine;
using System.Collections;

public class Joystick : MonoBehaviour 
{
	

	bool InNeutral;

	bool IsLeaningRight;
	bool dragRight;
	bool RightAnimRunning;

	bool IsLeaningLeft;
	bool dragLeft;
	bool LeftNeutral;


	// Update is called once per frame
	void Start()
	{
		InNeutral = true;
	}
	void Update () 
	{

		ButtonCheck();
	}

	
	void ButtonCheck()
	{




		//Debug.Log("InNeutral: " + InNeutral);
		if(InNeutral == true)
		{
			if(dragRight == true && IsLeaningRight == false)
			{
				GetComponent<Animation>().Play("LeanRight");
				
				IsLeaningRight = true;
				InNeutral = false;

			}
			else if(dragLeft == true && IsLeaningLeft == false)
			{
				GetComponent<Animation>().Play("LeanLeft");

				IsLeaningLeft = true;
				InNeutral = false;
			}

		}
		else if(IsLeaningRight)
		{
			if(dragLeft == true && IsLeaningRight == true)
			{
				GetComponent<Animation>().Play("Right-idle");

				IsLeaningRight = false;
			}
		}
		else if(IsLeaningLeft)
		{
			if(dragRight == true && IsLeaningLeft == true)
			{
				GetComponent<Animation>().Play("Left-idle");

				IsLeaningLeft = false;
			}
		}
		else
		{
			InNeutral = true;
		}



//		if(dragLeft == true && IsLeaningRight == true)
//		{
//			GetComponent<Animation>().Play("Right-idle");
//			IsLeaningRight = false;
//		}
//		if(dragLeft == true && IsLeaningLeft == false  )
//		{
//			GetComponent<Animation>().Play("LeanLeft");
//			IsLeaningLeft = true;
//
//
//		}
//		if(dragRight == true && IsLeaningLeft == true )
//		{
//			GetComponent<Animation>().Play("Left-idle");
//			IsLeaningLeft = false;
//
//
//
//		}
	}

	private Vector3 v3Pos;
	private int threshold = 9;

	void OnMouseDown()
	{
		v3Pos = Input.mousePosition;
	}
	void OnMouseDrag()
	{

		Vector3 v3 = Input.mousePosition - v3Pos;
		v3.Normalize();

		float Direction = Vector3.Dot(v3,Vector3.up);

		if(Vector3.Distance (v3Pos, Input.mousePosition) < threshold)
		{
			Debug.Log("No Movement");
			dragRight = false;
			dragLeft = false;

			return;
		}

		if(Direction >= 0.5)
		{
			Debug.Log("Up");
		
		}
		else if(Direction <= -.5)
		{
			Debug.Log("Down");
		}
		else
		{
			Direction = Vector3.Dot(v3,Vector3.right);
			if(Direction >= 0.5)
			{
				Debug.Log("Right");
				dragRight = true;


				//LeftNeutral = true;



			}
			else
			{
				Debug.Log("Left");
				dragLeft = true;

				//RightNeutral = true;




			}

			v3Pos = Input.mousePosition;
		}
	}
//	//Immediate location of the mouse's X coordinate
//	float mouseX()
//	{
//		return Input.mousePosition.x;
//	}
//	
//	//Immediate location of the mouse's Y coordinate
//	float mouseY()
//	{
//		return Input.mousePosition.y;
//	}
}