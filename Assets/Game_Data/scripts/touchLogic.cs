using UnityEngine;
using System.Collections;

public class touchLogic : MonoBehaviour
{
	
	void Update () 
	{
		
		if(Input.touches.Length <= 0 )
		{
			
		}
		else
		{
			for(int i = 0;i< Input.touchCount;i++)
			{
				
				if(this.GetComponent<GUITexture>().HitTest(Input.GetTouch(i).position))
				{
					if(Input.GetTouch(i).phase == TouchPhase.Began)
					{
						this.SendMessage("Touched");
						//Debug.Log("Touched");
					}
					
					
					
				}
				
				
			}
		}
	}
	
	
}
