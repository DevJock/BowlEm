using UnityEngine;
using System.Collections;

public class detectFallen : MonoBehaviour 
{

	public ArrayList fallenPins;
	public int abc;

	// Use this for initialization
	void Start () 
	{

	
	
	}
	
	// Update is called once per frame
	void Update () 
	{
		abc = (int)fallenPins [0];
	}



}
