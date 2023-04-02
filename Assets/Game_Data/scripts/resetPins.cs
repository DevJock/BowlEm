using UnityEngine;
using System.Collections;

public class resetPins : MonoBehaviour 
{
	public GameObject bballcam;
	public GameObject bowBall;
	Vector3 bballpos;
	GameObject oldPins;
	public float placerSpeed = 5.0f; 
	public int delayTime = 4 ;
	public int processing = 0;
	GameObject placer;
	Vector3 placerx;
	public bool placerEnabled = false ;
	public bool MoveDown = false ;
	public bool MoveUp = false ;
	Vector3 placerretract ;
	Vector3 placerxmove;
	public GameObject pins;
	Vector3 bbcampos ;
	GameObject selCode;
	Selector sCode;

	// Use this for initialization
	void Start () 
	{
		selCode = GameObject.Find ("Controller");
		sCode = selCode.GetComponent<Selector> ();
		//bballcam = GameObject.Find ("BallCam");
		//bowBall = GameObject.Find ("bowlingBall");
		oldPins = GameObject.Find ("pinSet");
		placer = GameObject.Find ("placer");
		placerx = placer.transform.position;
		placerretract = placerx;
		placerxmove = placerx;
		placerxmove.y=0.9670858f;
	    bbcampos = bballcam.transform.position;
		bballpos = bowBall.transform.position;
	}
	
	// Update is called once per frame
	void Update () 
	{
			if(MoveDown)
			{
				placer.transform.position = Vector3.MoveTowards(placer.transform.position, placerxmove ,placerSpeed*Time.deltaTime);
				if(placer.transform.position == placerxmove)
				{
				sCode.triggerdPos = -11111f ;
				bowBall.transform.position = bballpos ;
				bballcam.transform.position = bbcampos ;
				oldPins = GameObject.Find ("pinSet");
				Destroy(oldPins);
				MoveDown = false ;
				MoveUp = true ;

				Object newPin = Instantiate (pins, transform.position, transform.rotation);
				newPin.name = "pinSet";
				sCode.direcArrowEnabled = true ;
				sCode.direcGUI.GetComponent<Renderer>().enabled = true ;
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
		if(col.name == "bowlingBall")
		{
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
