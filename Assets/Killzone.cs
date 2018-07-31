using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Killzone : MonoBehaviour {

	public GameObject bombSpawner;
	private SpriteRenderer spriteRenderer;
	public Sprite fourHealth, threeHealth, twoHealth, oneHealth, zeroHealth;
	public int health = 4;

	void Start ()
	{
    	spriteRenderer = GetComponent<SpriteRenderer>();
	}

	void Update(){
		if (health == 4){
			spriteRenderer.sprite = fourHealth;
		}
		else if (health == 3){
			spriteRenderer.sprite = threeHealth;
		}
		else if (health == 2){
			spriteRenderer.sprite = twoHealth;
		}
		else if (health == 1){
			spriteRenderer.sprite = oneHealth;
		}
		else if (health == 0){
			spriteRenderer.sprite = zeroHealth;
			//Destroy(GameObject.Find("Bomb(Clone)"));
			Destroy(bombSpawner);
		}
	}

	void OnCollisionEnter2D(Collision2D coll) {
        if (coll.gameObject.tag == "Bomb"){
            Destroy(coll.gameObject);
            health--;
       }
    }
}
