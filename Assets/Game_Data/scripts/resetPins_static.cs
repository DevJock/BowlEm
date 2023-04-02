using UnityEngine;
using System.Collections;

public class resetPins_static : MonoBehaviour 
{
	public GameObject bowBall;
	public GameObject pinSetid;
	public GameObject placerid;
	public GameObject pins;

	Vector3 bballpos;
	GameObject oldPins;
	public float placerSpeed = 2.0f; 
	public int delayTime = 4 ;
	public int processing = 0;
	GameObject placer;
	Vector3 placerx;
	public bool placerEnabled = false ;
	public bool MoveDown = false ;
	public bool MoveUp = false ;
	Vector3 placerretract ;
	Vector3 placerxmove;
	GameObject BowlBall1;
	staticBallMover ball1;
	static string tempPinid;

	// Use this for initialization
	void Start () 
	{
		BowlBall1 = GameObject.Find ("bowlingBallStatic1");
		ball1 = BowlBall1.GetComponent<staticBallMover> ();
		oldPins = pinSetid;
		placer = placerid;
		placerx = placer.transform.position;
		placerretract = placerx;
		placerxmove = placerx;
		placerxmove.y=0.9670858f;
		bballpos = bowBall.transform.position;
		tempPinid ="pinSetStatic1";
	}
	
	// Update is called once per frame
	void Update () 
	{
	
		if(MoveDown)
		{
			placer.transform.position = Vector3.MoveTowards(placer.transform.position, placerxmove ,placerSpeed*Time.deltaTime);
			if(placer.transform.position == placerxmove)
			{
				pinSetid = GameObject.Find (tempPinid);
				bowBall.transform.position = bballpos ;
				oldPins = pinSetid;
				Destroy(oldPins);
				MoveDown = false ;
				MoveUp = true ;
				Object newPin = Instantiate (pins, transform.position, transform.rotation);
				newPin.name = tempPinid;
			}
		}
		
		
		
		
		if(MoveUp)
		{
			placer.transform.position = Vector3.MoveTowards (placer.transform.position, placerretract, placerSpeed * Time.deltaTime);
			if(placer.transform.position == placerretract)
			{
				MoveDown = false ;
				MoveUp = false ;
				placerEnabled = false ;
			}
			
		}

	}
	
	
	
	void OnTriggerEnter(Collider col)
	{
		if(col.name == bowBall.name)
		{
			ball1.ADDForceZ = false;
			StartCoroutine(placePins());
		}
		
	}
	IEnumerator placePins()
	{
		
		yield return new WaitForSeconds(delayTime);	
		MoveDown = true;
		placerEnabled = true;

		
	}
	
	
	
	
}
