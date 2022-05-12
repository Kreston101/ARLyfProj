using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Raycast : MonoBehaviour
{
    public GameObject arCamera;

    [SerializeField]
    private Button butUp, butDown, butLeft, butRight;
    private string[] names = {"Right", "Left", "Top",
        "Bottom", "TopR", "TopL", "BottomR", "BottomL"
    };

    private void Start()
    {
        butUp.onClick.AddListener(MoveUp);
        butDown.onClick.AddListener(MoveDown);
        butLeft.onClick.AddListener(MoveLeft);
        butRight.onClick.AddListener(MoveRight);
    }

    public void Select(string direction)
    {
        //Debug.Log("select");
        if (Physics.Raycast(arCamera.transform.position, arCamera.transform.forward, out RaycastHit hit))
        {
            //Debug.Log("raycast");
            foreach (string i in names)
            {
                if (hit.transform.name == i)
                {
                    hit.transform.gameObject.GetComponent<NewSlideControl>().selected = true;
                    hit.transform.gameObject.GetComponent<NewSlideControl>().Move(direction);
                    //Debug.Log("actions here");
                }
            }
        }
    }

    private void MoveUp()
    {
        //Debug.Log("button up");
        Select("up");
    }

    private void MoveDown()
    {
        //Debug.Log("button down");
        Select("down");
    }

    private void MoveLeft()
    {
        //Debug.Log("button left");
        Select("left");
    }

    private void MoveRight()
    {
        //Debug.Log("button right");
        Select("right");
    }
}