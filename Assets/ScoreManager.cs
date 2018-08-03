using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScoreManager : MonoBehaviour {

	public GameObject digitOne, digitTwo, digitThree, digitFour;
	public int score;

	// Use this for initialization
	void Start () {
		score = 0;
	}

	public void IncreaseScore(){
		score++;
		//Checking if the score is at 999, in which case it resets those three digits to zero and puts the fourth digit to 1
		if (GameObject.Find("digitThree").GetComponent<Numbers>().currentNum == 9 & GameObject.Find("digitTwo").GetComponent<Numbers>().currentNum == 9 & GameObject.Find("digitOne").GetComponent<Numbers>().currentNum == 9){
			GameObject.Find("digitFour").GetComponent<Numbers>().currentNum++;
			GameObject.Find("digitThree").GetComponent<Numbers>().currentNum = 0;
			GameObject.Find("digitTwo").GetComponent<Numbers>().currentNum = 0;
			GameObject.Find("digitOne").GetComponent<Numbers>().currentNum = 0;
		}
		//Checking if the score is at 99, in which case it resets those two digits to zero and puts the third digit to 1
		else if (GameObject.Find("digitTwo").GetComponent<Numbers>().currentNum == 9 & GameObject.Find("digitOne").GetComponent<Numbers>().currentNum == 9){
			GameObject.Find("digitThree").GetComponent<Numbers>().currentNum++;
			GameObject.Find("digitTwo").GetComponent<Numbers>().currentNum = 0;
			GameObject.Find("digitOne").GetComponent<Numbers>().currentNum = 0;	
		}
		//Checking if the score is at 9, in which case it resets the first digit back to zero and puts the second digit to 1
		else if (GameObject.Find("digitOne").GetComponent<Numbers>().currentNum == 9){
			GameObject.Find("digitOne").GetComponent<Numbers>().currentNum = 0;
			GameObject.Find("digitTwo").GetComponent<Numbers>().currentNum++;
		}
		else{
			GameObject.Find("digitOne").GetComponent<Numbers>().currentNum++;
		}
	}
}
