using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NumberWizard : MonoBehaviour {
    int min = 1;
    int max = 1001;
    int guess = 500;
    // Use this for initialization
    void Start () {
        StarGame();
	}

	void StarGame()
    {
        print("Welcome to Number Wizard");
        print("Pick a number in your head and don't tell me:");


        print("The highest number you can pick is " + max);
        print("The lowest number you can pick it" + min);

        print("Is your number higher or lower than " + guess + "?");
        print("Arrow up for higher, Arrow down for lower");
    }

    void NextGuess()
    {
        guess = (min + max) / 2;
        print("Higher or lower than " + guess);
    }

	// Update is called once per frame
	void Update () {
        if (Input.GetKeyDown(KeyCode.UpArrow))
        {
            print("Up arrow pressed");
            min = guess;
            NextGuess();
        }
        else if (Input.GetKeyDown(KeyCode.DownArrow))
        {
            print("Down arrow pressed");
            max = guess;
            NextGuess();
        }
        else if (Input.GetKeyDown(KeyCode.Return))
        {
            print("I won!");
        }
    }
}
