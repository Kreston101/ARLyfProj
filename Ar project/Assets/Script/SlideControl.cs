using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SlideControl : MonoBehaviour
{
    private Rigidbody rb3d;
    private Vector2 startPos;
    private Vector2 direction;

    void Start()
    {
        rb3d = GetComponent<Rigidbody>();
        rb3d.isKinematic = true;
    }

    void FixedUpdate()
    {
        if (Input.touchCount > 0)
        {
            Touch touch = Input.GetTouch(0);
            switch (touch.phase)
            {
                case TouchPhase.Began:
                    startPos = touch.position;
                    break;

                case TouchPhase.Moved:
                    direction = touch.position - startPos;
                    rb3d.AddForce(new Vector2(direction.x, direction.y));
                    break;
                case TouchPhase.Ended:
                    DisableRB();
                    break;
            }
        }
    }

    public void DisableRB()
    {
        rb3d.isKinematic = true;
    }
}
