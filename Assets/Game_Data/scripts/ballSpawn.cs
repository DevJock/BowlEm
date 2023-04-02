using UnityEngine;
using System.Collections;

public class ballSpawn : MonoBehaviour
{

	public Rigidbody ball;
	public bool spawnBall = false ;
	public int count = 0;
	int i =0;
	// Use this for initialization
	void Start () 
	{

		SpawnBall();

	}
	
	// Update is called once per frame
	void Update () 
	{

		if (spawnBall) 
		{
			SpawnBall();
		}
		else
		{
			SpawnBallAuto();
		}


	}

	void SpawnBall()
	{
		while(i<count)
		{

			StartCoroutine(spawnBallthreaded());
			i++;
		}

	}


	IEnumerator spawnBallthreaded()
	{
		

		
		Rigidbody temp = Instantiate (ball, transform.position, transform.rotation)as Rigidbody;
		temp.velocity = transform.TransformDirection (new Vector3 (-3.0f, 0.0f, 0.0f));
		yield return new WaitForSeconds(1.0f);	
		
	}



	void SpawnBallAuto()
	{
		if (count >=500) 
		{
			Rigidbody temp = Instantiate (ball, transform.position, transform.rotation)as Rigidbody;
			temp.velocity = transform.TransformDirection (new Vector3 (-3.0f, 0.0f, 0.0f));
			count = 0;
		}
		count++;
	}





}
