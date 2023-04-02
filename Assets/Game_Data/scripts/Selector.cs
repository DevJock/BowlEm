using UnityEngine;
using System.Collections;

public class Selector : MonoBehaviour 
{
	public GameObject direcGUI;
	public float triggerdPos = -11111f; 
	public bool direcArrowEnabled = false ;
	public float speed = 0.5f ;
	public float initialX = 0.07f;
	public float finalX = 0.67f;
	bool left2right = true ;
	bool right2left = false ;
	Vector3 direcArrowPOS ;



	public GameObject speedGUI;
	
	public bool speedArrowEnabled = false ;
	public float initialY = 0.03f;
	public float finalY = 0.42f;
	bool down2top = true ;
	bool top2down = false ;
	Vector3 speedArrowPOS ;



	// Use this for initialization
	void Start () 
	{
		speedGUI = GameObject.Find ("speedArrowGUI");
		direcGUI = GameObject.Find ("directionArrowGUI");
		direcArrowPOS = direcGUI.transform.position;
		direcArrowPOS.x = initialX;
		speedArrowPOS = speedGUI.transform.position;
		speedArrowPOS.y = initialY;
	}
	
	// Update is called once per frame
	void Update () 
	{
	
		if(direcArrowEnabled)
		{
			if(left2right)
			{
				direcArrowPOS.x = finalX ;
			}
			if(right2left)
			{
				direcArrowPOS.x = initialX ;
			}
			direcGUI.transform.position = Vector3.MoveTowards(direcGUI.transform.position , direcArrowPOS , speed*Time.deltaTime);

			if(Input.GetKey(KeyCode.Space))
			{
				triggerdPos = direcGUI.transform.position.x ;
				direcArrowEnabled = false;
				direcGUI.GetComponent<Renderer>().enabled = false ;
			}

			if(Input.touches.Length <= 0 )
			{
				
			}
			else
			{
				for(int i = 0;i< Input.touchCount;i++)
				{

						if(Input.GetTouch(i).phase == TouchPhase.Began)
						{
						  triggerdPos = direcGUI.transform.position.x ;
						  direcArrowEnabled = false;
					    	direcGUI.GetComponent<Renderer>().enabled = false ;
							//Debug.Log("Touched");
						}
					
				}
			}
		

			if(direcGUI.transform.position.x == initialX)
			{
				left2right = true ;
				right2left = false ;
			}
			else if(direcGUI.transform.position.x == finalX)
			{
				left2right = false;
				right2left = true ;
			}
		}



		if(speedArrowEnabled)
		{
			if(down2top)
			{
				speedArrowPOS.y = finalY ;
			}
			if(top2down)
			{
				speedArrowPOS.y = initialY ;
			}
			speedGUI.transform.position = Vector3.MoveTowards(speedGUI.transform.position , speedArrowPOS , speed*Time.deltaTime);
			if(speedGUI.transform.position.y == initialY)
			{
				down2top = true ;
				top2down = false ;
			}
			else if(speedGUI.transform.position.y == finalY)
			{
				down2top = false;
				top2down = true ;
			}
		}











	}
}
