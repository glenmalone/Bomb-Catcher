using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour {

	[SerializeField] private float distanceToMove;
	[SerializeField] private float moveSpeed;
	private bool moveToPoint = false;
	private Vector3 endPosition;
    private int score;

	void Start () {
        score = 0;
    	endPosition = transform.position;
    }
  
	void FixedUpdate () {
    	if (moveToPoint)
        {
            transform.position = Vector3.MoveTowards(transform.position, endPosition, moveSpeed * Time.deltaTime);
        }
    }
    void Update() {
        if (Input.GetKeyDown(KeyCode.A)) //Left Press
        {
            endPosition = new Vector3(endPosition.x - distanceToMove, endPosition.y, endPosition.z);
            moveToPoint = true;
        }
        if (Input.GetKeyUp(KeyCode.A)) //Left Release
        {
            endPosition = new Vector3(endPosition.x + distanceToMove, endPosition.y, endPosition.z);
            moveToPoint = true;
        }
        if (Input.GetKeyDown(KeyCode.D)) //Right Press
        {
            endPosition = new Vector3(endPosition.x + distanceToMove, endPosition.y, endPosition.z);
            moveToPoint = true;
        }
        if (Input.GetKeyUp(KeyCode.D)) //Right Release
        {
            endPosition = new Vector3(endPosition.x - distanceToMove, endPosition.y, endPosition.z);
            moveToPoint = true;
        }
        // if (Input.GetKeyDown(KeyCode.W)) //Up
        // {
        //     endPosition = new Vector3(endPosition.x, endPosition.y + distanceToMove, endPosition.z);
        //     moveToPoint = true;
        // }
        // if (Input.GetKeyDown(KeyCode.S)) //Down
        // {
        //     endPosition = new Vector3(endPosition.x, endPosition.y - distanceToMove, endPosition.z);
        //     moveToPoint = true;
        // }
    }
    
    void OnCollisionEnter2D(Collision2D coll) {
        if (coll.gameObject.tag == "Bomb"){
            Destroy(coll.gameObject);
            score++;
       }
    }
}
