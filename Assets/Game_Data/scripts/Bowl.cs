using UnityEngine;
using System.Collections;

public class Bowl : MonoBehaviour 
{
	public float centerer = 0.4f;
	public float multiplier = 30.0f ;
	public float BallBowlForce = 100.0f;
	GameObject bowlBall;
	GameObject selCode;
	Selector sCode;
	// Use this for initialization
	void Start () 
	{
		selCode = GameObject.Find ("Controller");
		sCode = selCode.GetComponent<Selector> ();
		bowlBall = GameObject.Find ("bowlingBall");
	}
	
	// Update is called once per frame
	void Update () 
	{
		if (sCode.triggerdPos != -11111f)
		{
			float forcer = sCode.triggerdPos - centerer ;
		//	if(forcer < 0.305)
			{
				//left Force
		//		forcer = -forcer ;
			}
			//1 2
			// 1 
		bowlBall.GetComponent<Rigidbody>().AddForce(forcer * multiplier, 0.0f ,BallBowlForce);
		}
		
	}
}
