using UnityEngine;
using System.Collections;

public class staticBallMover : MonoBehaviour 
{

	public GameObject selectedGameObject;
	public bool ADDForceZ = false ;
	public float FORCE = 190.0f;

	// Use this for initialization
	void Start () 
	{
		selectedGameObject = gameObject;
	}
	
	// Update is called once per frame
	void Update () 
	{
	
		if(ADDForceZ)
		{


			selectedGameObject.GetComponent<Rigidbody>().AddForce(0.0f,0.0f,FORCE);

		}


	}
}
