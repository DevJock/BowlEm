using UnityEngine;
using System.Collections;

public class pinNumber : detectFallen
{
	public int pinNum = 0;
	int i=0;
	// Use this for initialization
	void Start () 
	{

	}
	
	// Update is called once per frame
	void Update () {
	 
	}

	void OnTriggerEnter(Collider col)
	{
		if(col.GetComponent<Collider>().name.Equals("Detector"))
		{

			fallenPins.Add(4);
			Debug.Log ("pinID:"+pinNum);
			i++;
			if(i>=10)
				i=0;
		}
	}



}
