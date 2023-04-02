using UnityEngine;
using System.Collections;

public class destroyBall : MonoBehaviour 
{

	public int spawnLife = 0;


	// Use this for initialization
	void Start () 
	{
	
	}
	
	// Update is called once per frame
	void Update () 
	{
	if (spawnLife >= 800)
		{
			Destroy(gameObject);

		}
		spawnLife++;
	}
}
