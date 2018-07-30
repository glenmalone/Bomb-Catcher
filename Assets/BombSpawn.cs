using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BombSpawn : MonoBehaviour {

	public float speed = 1;
    private float Timer;
    private float speedUp = .01f;
    public GameObject bomb;
    GameObject bombClone;
 
    void Start () 
    {
    	Timer = speed;
    }
     
    void Update () 
    {
        Timer -= Time.deltaTime;
        if (Timer <= 0){
        	bombClone = Instantiate (bomb,(new Vector3 ((Random.Range (-1, 2)), 2, 0)), transform.rotation )  as GameObject;
            Timer = speed - speedUp;
            speed = Timer;
        }
    }
}
