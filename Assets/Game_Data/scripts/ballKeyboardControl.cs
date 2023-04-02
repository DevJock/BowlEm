using UnityEngine;
using System.Collections;

public class ballKeyboardControl : MonoBehaviour 
{

	GameObject bball;
	public float ballForce = 100.0f;
	public float turnTweaker = 50.0f;


	// Use this for initialization
	void Start () 
	{
		bball = gameObject;
	}
	
	// Update is called once per frame
	void Update ()
	{
	
		if(Input.GetKey(KeyCode.W))
		{
			bball.GetComponent<Rigidbody>().AddForce(new Vector3(0.0f,0.0f,ballForce));
		}

		if(Input.GetKey(KeyCode.S))
		{
			bball.GetComponent<Rigidbody>().AddForce(new Vector3(0.0f,0.0f,-ballForce));
		}

		if(Input.GetKey(KeyCode.D))
		{
			bball.GetComponent<Rigidbody>().AddForce(new Vector3(ballForce - turnTweaker,0.0f,0.0f));
		}
		else
		{
			bball.GetComponent<Rigidbody>().AddForce(new Vector3(0.0f,0.0f,0.0f));
		}

		 if(Input.GetKey(KeyCode.A))
		{
			bball.GetComponent<Rigidbody>().AddForce(new Vector3(-ballForce + turnTweaker,0.0f,0.0f));
		}

		else
		{
			bball.GetComponent<Rigidbody>().AddForce(new Vector3(0.0f,0.0f,0.0f));
		}

	}
}
