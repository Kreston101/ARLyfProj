using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class NewSlideControl : MonoBehaviour
{
    public bool selected = false;

    private float dampener = 0.25f;
    private Rigidbody rb3d;

    void Start()
    {
        rb3d = GetComponent<Rigidbody>();
        rb3d.isKinematic = true;
    }

    public void Move(string direction)
    {
        //Debug.Log("if this runs, everything should be ok(?)");
        switch (direction)
        {
            case "up":
                rb3d.MovePosition(transform.position + Vector3.forward * dampener);
                Debug.Log("there shoudl be movement");
                //selected = false;
                break;
            case "down":
                rb3d.MovePosition(transform.position + Vector3.back * dampener);
                Debug.Log("there shoudl be movement");
                //selected = false;
                break;
            case "left":
                rb3d.MovePosition(transform.position + Vector3.left * dampener);
                Debug.Log("there shoudl be movement");
                //selected = false;
                break;
            case "right":
                rb3d.MovePosition(transform.position + Vector3.right * dampener);
                Debug.Log("there shoudl be movement");
                //selected = false;
                break;

        }
    }
}
