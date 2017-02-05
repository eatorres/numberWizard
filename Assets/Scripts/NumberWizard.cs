using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NumberWizard : MonoBehaviour {

	// Use this for initialization
	void Start () {
        print("Welcome to Number Wizard");
        print("Pick a number in your head and don't tell me:");
        int low = 0;
        int high = 1000;

        print("The highest number you can pick is " + high);
        print("The lowest number you can pick it" + low);

        print("Is your number higher or lower than 500?");
        print("Arrow up for higher, Arrow down for lower");
	}
	
	// Update is called once per frame
	void Update () {
        if (Input.GetKeyDown(KeyCode.UpArrow))
        {
            print("Up arrow pressed");
        }
        else if (Input.GetKeyDown(KeyCode.DownArrow))
        {
            print("Down arrow pressed");
        }
        else if (Input.GetKeyDown("Enter"))
        {
            print("I won!");
        }
    }
}
