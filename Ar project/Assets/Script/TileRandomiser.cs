using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TileRandomiser : MonoBehaviour
{
    public GameObject[] tiles;
    public Transform[] puzzlePos;
    public Button randButton;
    public List<Transform> randPos;

    void Start()
    {
        randButton.onClick.AddListener(ShuffleTiles);
        ShuffleTiles();
    }

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
}
