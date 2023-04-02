using UnityEngine;
using System.Collections;

public class followBall : MonoBehaviour 
{

	public float distanceFromBall =2.0f;
	public bool enablefollowBall = true;


	GameObject ballCam;
	Vector3 initialPos;
	// Use this for initialization
	void Start () 
	{
		ballCam = GameObject.Find ("BallCam");
		initialPos = ballCam.transform.position;
	}
	
	// Update is called once per frame
	void Update () 
	{
		if(enablefollowBall)
		{
		Vector3 pos = gameObject.transform.position; 
		Vector3 campos = ballCam.transform.position;
		campos.z = pos.z- distanceFromBall;
		ballCam.transform.position = campos;
		}

		if(ballCam.transform.position == initialPos)
		{
			enablefollowBall = true;
		}

	}


	void OnTriggerEnter(Collider col)
	{
	
		enablefollowBall = false;
	}



}
