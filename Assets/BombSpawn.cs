using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BombSpawn : MonoBehaviour {

	public float speed = 1;
	private float minSpeed = 0.2f;
    private float Timer;
    private float speedUp = .007f;
    public GameObject bomb;
 
    void Start () 
    {
    	Timer = speed;
    }
     
    void Update () 
    {
        Timer -= Time.deltaTime;
        if (Timer <= 0){
        	int randomPos = Random.Range (0, 3);
        	if (randomPos == 1){
        		randomPos = -2;
        	}
    		GameObject bombClone;
        	bombClone = Instantiate (bomb,(new Vector3 (randomPos, 2, 0)), transform.rotation) as GameObject;
        	if (speed - speedUp < minSpeed ){
            	Timer = minSpeed;
        	}
        	else {
        		Timer = speed - speedUp;
        	}
        	speed = Timer;
        }
    }
}
