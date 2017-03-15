using UnityEngine;
using System.Collections;
using UnityEngine.UI;
//class attached to Game Manager empty game object
public class CheckGuess : MonoBehaviour {
	//public properties, set in Editor
	public InputField input;
	public Text label;

	private int RandomNumToGuess;
	private int playerGuess;
	// Use this for initialization
	void Start () {
		RandomNumToGuess = Random.Range(0, 100);
	}
	
	public void CheckPlayerGuess(){
		//convert text to int then store in playerGuess variable
		playerGuess = int.Parse(input.text);

		//conditional statement to check playerGuess against Random Num
		if(playerGuess == RandomNumToGuess){
			label.text = "Mind reader!! Correct number guessed";
		} else if (playerGuess > RandomNumToGuess){
			label.text = "Too high - try a lower number";
		} else if (playerGuess < RandomNumToGuess) {
			label.text = "Too low - try a higher number";
		}

		input.text = "";





	}
}
