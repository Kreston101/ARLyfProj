using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MoveTile : MonoBehaviour
{
    public Button buttonUp, buttonDown, buttonLeft, buttonRight;
    public Transform correctPos;
    public bool inPlace = false;
    public GameManager gmScript;

    // Gets all the buttons and adds functions to them
    void Start()
    {
        buttonUp.onClick.AddListener(moveUp);
        buttonDown.onClick.AddListener(moveDown);
        buttonLeft.onClick.AddListener(moveLeft);
        buttonRight.onClick.AddListener(moveRight);
    }

    //checkPos() checks to make sure the tile has not left the "boundary box"
    /*the tile then checks its localPosition against the localPosition of its designated point
     returns false if out of position and true if in position. Moving the tile out of position resets
    the variable to false. This value is checked every frame in the GameManager*/
    //(the tile are attached to an empty object which is attached to the
    //vuforia image wall, thus the local positon is more accurate then the world positon)
    //the last check is used to see if the puzzle has been solved by checking a varible on the
    //GameManager Object, if true then the buttons are disabled
    void Update()
    {
        checkPos();
        if (transform.localPosition == correctPos.localPosition)
        {
            inPlace = true;
        }
        else
        {
            inPlace = false;
        }

        if(gmScript.GetComponent<GameManager>().puzzleSolved == true)
        {
            buttonUp.enabled = false;
            buttonDown.enabled = false;
            buttonLeft.enabled = false;
            buttonRight.enabled = false;
        }
    }

    //checks the position of the tiles to make sure they have not exceeded
    //either the x or z axis
    //the bounding box of the puzzle is between x = -1 to 1 and z = -1 or 1
    //resets the tiles position back to what its previous position was
    public void checkPos()
    {
        if (transform.localPosition.x > 1)
        {
            transform.localPosition = new Vector3(1, transform.localPosition.y, transform.localPosition.z);
        }
        else if (transform.localPosition.x < -1)
        {
            transform.localPosition = new Vector3(-1, transform.localPosition.y, transform.localPosition.z);
        }
        else if (transform.localPosition.z > 1)
        {
            transform.localPosition = new Vector3(transform.localPosition.x, transform.localPosition.y, 1);
        }
        else if (transform.localPosition.z < -1)
        {
            transform.localPosition = new Vector3(transform.localPosition.x, transform.localPosition.y, -1);
        }
    }

    //movement functions attached to the buttons on Start()
    //the tile checks if the space next to it is empty
    //if the check returns true the tile does not move
    //if not the tiles moves in the dirction indicated
    public void moveUp()
    {
        if (Physics.Raycast(transform.position, transform.TransformDirection(Vector3.forward), out RaycastHit hit, 0.25f))
        {

        }
        else
        {
            transform.localPosition += Vector3.forward;
        }
    }

    public void moveDown()
    {
        if (Physics.Raycast(transform.position, transform.TransformDirection(Vector3.back), out RaycastHit hit, 0.25f))
        {

        }
        else
        {
            transform.localPosition += Vector3.back;
        }
    }

    public void moveLeft()
    {
        if (Physics.Raycast(transform.position, transform.TransformDirection(Vector3.left), out RaycastHit hit, 0.25f))
        {

        }
        else 
        {
            transform.localPosition += Vector3.left;
        }
    }

    public void moveRight()
    {
        if (Physics.Raycast(transform.position, transform.TransformDirection(Vector3.right), out RaycastHit hit, 0.25f))
        {

        }
        else 
        {
            transform.localPosition += Vector3.right;
        }
    }
}
