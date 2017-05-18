using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class NumberWizard : MonoBehaviour {
    int min;
    int max;
    int guess;
    int maxGuessAllowed = 10;

    public Text text;

    // Use this for initialization
    void Start () {
        StartGame();
        text.text = guess.ToString();
    }

	void StartGame()
    {
        min = 1;
        max = 1001;
        guess = Random.Range(1, 1001);
    }

    void NextGuess()
    {
        guess = Random.Range(min, max + 1);
        text.text = guess.ToString();
        maxGuessAllowed -= 1;

        if (maxGuessAllowed <= 0) {
            SceneManager.LoadScene("Win");
        }
    }

    public void GuessHigher() {
        min = guess;
        NextGuess();
    }

    public void GuessLower() {
        max = guess;
        NextGuess();
    }
}
