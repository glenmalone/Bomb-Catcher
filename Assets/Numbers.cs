using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Numbers : MonoBehaviour {

	public Sprite zero, one, two, three, four, five, six, seven, eight, nine;
	public int currentNum;
	private SpriteRenderer spriteRenderer;

	void Start (){
    	spriteRenderer = GetComponent<SpriteRenderer>();
		currentNum = 0;
	}
	
	// Update is called once per frame
	void Update () {
		if (currentNum == 0){
			spriteRenderer.sprite = zero;
		}
		else if (currentNum == 1){
			spriteRenderer.sprite = one;
		}
		else if (currentNum == 2){
			spriteRenderer.sprite = two;
		}
		else if (currentNum == 3){
			spriteRenderer.sprite = three;
		}
		else if (currentNum == 4){
			spriteRenderer.sprite = four;
		}
		else if (currentNum == 5){
			spriteRenderer.sprite = five;
		}
		else if (currentNum == 6){
			spriteRenderer.sprite = six;
		}
		else if (currentNum == 7){
			spriteRenderer.sprite = seven;
		}
		else if (currentNum == 8){
			spriteRenderer.sprite = eight;
		}
		else if (currentNum >= 9){
			spriteRenderer.sprite = nine;
		}
	}
}
