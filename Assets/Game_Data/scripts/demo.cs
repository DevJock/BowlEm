using UnityEngine;
using System.Collections;

public class demo : MonoBehaviour 
{
	public float transitionTime = 2.0f;
	public float speed = 2.0f;
	public int count = 1;
	GameObject democam ;
	GameObject balcamera;
	GameObject stalkCam;
	bool dcam = true , scam = false  ;
	GameObject selCode;
	Selector sCode;
	public bool finishedDemo = false ;



	// Use this for initialization
	void Start () 
	{
		selCode = GameObject.Find ("Controller");
		sCode = selCode.GetComponent<Selector> ();
		democam = GameObject.Find ("DemoCam");
		balcamera = GameObject.Find ("BallCam");
		balcamera.SetActive (false);
		democam.SetActive(true);
		stalkCam = GameObject.Find ("stalkCamera");
		stalkCam.SetActive (false);
	}


	void Update () 
	{
	

		Vector3 currentpos = democam.transform.position;
		Vector3 finalpos = currentpos;
		finalpos.x = 4.374387f;

		Vector3 currentposstalk = stalkCam.transform.position;
		Vector3 finalposstalk = currentposstalk;
		finalposstalk.z = 5.147166f;


		if(dcam)
		{

		democam.transform.position = Vector3.MoveTowards (currentpos, finalpos, speed * Time.deltaTime);
			if(democam.transform.position == finalpos)
			{
				dcam = false ;
				scam = true ;

				democam.SetActive(false);
				balcamera.SetActive(false);
				stalkCam.SetActive (true);
			}
		
		}


		 if(scam)
		{

			stalkCam.transform.position = Vector3.MoveTowards (currentposstalk, finalposstalk , speed * Time.deltaTime);
			if(stalkCam.transform.position == finalposstalk)
			{
				scam = false ;
				StartCoroutine(changeCamera());
			}
		}


	


	}


	IEnumerator changeCamera()
	{

		yield return new WaitForSeconds(transitionTime);



		democam.SetActive(false);
		balcamera.SetActive(true);
		stalkCam.SetActive (false);
		sCode.direcArrowEnabled = true;
		finishedDemo = true;
	}


}
