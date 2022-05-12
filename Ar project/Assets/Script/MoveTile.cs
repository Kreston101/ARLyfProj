using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MoveTile : MonoBehaviour
{
    public Button buttonUp, buttonDown, buttonLeft, buttonRight;

    // Start is called before the first frame update
    void Start()
    {
        buttonUp.onClick.AddListener(moveUp);
        buttonDown.onClick.AddListener(moveDown);
        buttonLeft.onClick.AddListener(moveLeft);
        buttonRight.onClick.AddListener(moveRight);
    }

    // Update is called once per frame
    void Update()
    {
        checkPos();
    }

    public void checkPos()
    {
        if (transform.position.x > 1)
        {
            transform.position = new Vector3(1, transform.position.y, transform.position.z);
        }
        else if (transform.position.x < -1)
        {
            transform.position = new Vector3(-1, transform.position.y, transform.position.z);
        }
        else if (transform.position.z > 1)
        {
            transform.position = new Vector3(transform.position.x, transform.position.y, 1);
        }
        else if (transform.position.z < -1)
        {
            transform.position = new Vector3(transform.position.x, transform.position.y, -1);
        }
    }

    public void moveUp()
    {
        if (Physics.Raycast(transform.position, transform.TransformDirection(Vector3.forward), out RaycastHit hit, 1f))
        {

        }
        else
        {
            transform.position += Vector3.forward;
        }
    }

    public void moveDown()
    {
        if (Physics.Raycast(transform.position, transform.TransformDirection(Vector3.back), out RaycastHit hit, 1f))
        {

        }
        else
        {
            transform.position += Vector3.back;
        }
    }

    public void moveLeft()
    {
        if (Physics.Raycast(transform.position, transform.TransformDirection(Vector3.left), out RaycastHit hit, 1f))
        {

        }
        else 
        {
            transform.position += Vector3.left;
        }
    }

    public void moveRight()
    {
        if (Physics.Raycast(transform.position, transform.TransformDirection(Vector3.right), out RaycastHit hit, 1f))
        {

        }
        else 
        {
            transform.position += Vector3.right;
        }
    }
}
