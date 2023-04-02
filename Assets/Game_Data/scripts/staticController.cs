using UnityEngine;
using System.Collections;

public class staticController : MonoBehaviour 
{

	GameObject dcam;
	demo dscript;
	GameObject BowlBall1;
	GameObject BowlBall2;
	staticBallMover ball1;
	staticBallMover ball2;
	public float delayTime = 5.0f;
	int count = 0;
	bool finishedDemo = false ;


	// Use this for initialization
	void Start () 
	{
		dcam = GameObject.Find ("Controller");
		BowlBall1 = GameObject.Find ("bowlingBallStatic1");
		BowlBall2 = GameObject.Find ("bowlingBallStatic2");
		dscript = dcam.GetComponent<demo> ();
		ball1 = BowlBall1.GetComponent<staticBallMover> ();
		ball2 = BowlBall2.GetComponent<staticBallMover> ();


	}




	// Update is called once per frame
	void Update () 
	{
	
		if(dscript.finishedDemo)
		{

			StartCoroutine(delayMe());
			finishedDemo =true ;
		}

		else if(finishedDemo)
		{  
			ball1.ADDForceZ = false;
			ball2.ADDForceZ = false;
			StartCoroutine(ticker());
		}





	}

	IEnumerator ticker()
	{
			count+=1;
			if(count >=delayTime)
			{
				ball1.ADDForceZ = true;
				yield return new WaitForSeconds(delayTime);
				ball2.ADDForceZ = true;
				count=0;
			}
			yield return new WaitForSeconds(1.0f);
	}


	IEnumerator delayMe()
	{
		ball1.ADDForceZ = true;
		yield return new WaitForSeconds(delayTime);
		ball2.ADDForceZ = true;
		
		StopCoroutine("delayMe");
	}
	
	

}
