using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Battleship_Master : MonoBehaviour
{
    List<string> shipCoordinates = new List<string>() {
        "A5",
        "B5",
        "C5",
        "D5",
        "H1",
        "H2",
        "H3",
        "H4",
        "H5",
        "H6",
        "G10",
        "H10",
        "I10",
        "J10"
    };

    private void Start() => initialize();

    private void initialize() {
        StartCoroutine("CheckForGuess");
    }

    IEnumerator CheckForGuess() {
        while (true) {
            if (PlayerPrefs.GetString("battleship_guessCoordinate") != "") 
                checkGuess(PlayerPrefs.GetString("battleship_guessCoordinate"));
        
            yield return null;
        }
    }

    private void checkGuess(string guess) {
        shipCoordinates.ForEach(coordinate => {
            if (guess == coordinate) {
                Debug.Log("HIT");
            } else {
                Debug.Log("MISS");
            }
        });

        PlayerPrefs.SetString("battleship_guessCoordinate", "");
    }
}
