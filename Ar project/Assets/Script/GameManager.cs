using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public GameObject[] tiles;
    public Transform[] puzzlePos;
    public GameObject tileObj;
    public List<Transform> randPos;
    public Button randButton;
    public Text timeText, solvedText;
    public bool puzzleSolved = false;

    private float time = 0;

    //tiles are randomised at the start, so the pattern is dynamic
    void Start()
    {
        randButton.onClick.AddListener(ShuffleTiles);
        ShuffleTiles();
    }

    //checks the return value of Solved()
    //if it returns false the timer continues
    //if the value is true then the timer displays the final time
    //and displays a text to tell players that they solved the puzzle
    //reloads the scene after a delay
    //if a point awarding system is added in the future, place it under the else statement
    void Update()
    {
        if (Solved() != true)
        {
            time += Time.deltaTime;
            timeText.text = $"Time: {time}";
        }
        else
        {
            puzzleSolved = true;
            solvedText.text = "You solved the puzzle";
            Debug.Log("Hello, if at some point in the future a coin/reward system is added, place the function here");
            StartCoroutine(Delay());
            SceneManager.LoadScene("ARScene", LoadSceneMode.Single);
        }
    }

    //gets all the transforms in puzzlePos array (9 points total) to add them to a list
    //then runs through the array of game objects (8 tiles total) and moves them to a random position
    //once that position has been used, it is removed from the list
    //the list is then cleared to prevent any duplicate points, as there is
    //always 1 point not used
    public void ShuffleTiles()
    {
        foreach (Transform pos in puzzlePos)
        {
            randPos.Add(pos);
            Debug.Log(randPos);
        }

        foreach (GameObject tile in tiles)
        {
            int randInt = Random.Range(0, randPos.Count);
            tile.transform.position = randPos[randInt].transform.position;
            randPos.RemoveAt(randInt);
        }
        randPos.Clear();
    }

    //runs every update frame
    //gets all the tiles and checks the bool varible inPlace
    //to see if they are in place
    //returns false if even one tile is in the wrong place
    //returns true if all the tiles are in place
    private bool Solved()
    {
        foreach (GameObject tile in tiles)
        {
            if (tile.GetComponent<MoveTile>().inPlace == false)
            {
                return false;
            }
        }
        return true;
    }

    //adds a delay before the scene reloads
    //when the scene resets, the game can be played again
    private IEnumerator Delay()
    {
        yield return new WaitForSecondsRealtime(15.0f);
    }
}
