using UnityEngine;

public class Battleship_Grid : MonoBehaviour
{
    public void setGuess(string guessCoordinate) => PlayerPrefs.SetString("battleship_guessCoordinate", guessCoordinate);
}
