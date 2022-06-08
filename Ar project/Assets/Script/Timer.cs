using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Timer : MonoBehaviour
{
    public GameObject[] tiles;
    public Text timeText;
    private float time = 0;
    private MoveTile moveTile;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if(Solved() != true)
        {
            time += Time.deltaTime;
            timeText.text = $"Time: {time}";
        }
    }

    private bool Solved()
    {
        foreach(GameObject tile in tiles)
        {
            if(tile.GetComponent<MoveTile>().inPlace == false)
            {
                return false;
            }
        }
        return true;
    }
}
