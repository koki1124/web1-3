using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Test : MonoBehaviour {

    // Use this for initialization

    void Start ()
    {
        Vector2 playerPos= new Vector2(0.0f, 0.0f);

        int[] speed = new int[5];
       
      for(int i=0;i<5; i++)
        {
            playerPos.x += 2.0f;
           
            Debug.Log(playerPos);
        }
      

    }
   
	
	// Update is called once per frame
	void Update () {
		
	}
}
