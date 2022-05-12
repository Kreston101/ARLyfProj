using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CFSlideControl : MonoBehaviour
{
    private Rigidbody rb;
    private ConstantForce cf;
    [SerializeField]
    private Button butUp, butDown, butLeft, butRight;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        cf = GetComponent<ConstantForce>();

        butUp.onClick.AddListener(MoveUp);
        butDown.onClick.AddListener(MoveDown);
        butLeft.onClick.AddListener(MoveLeft);
        butRight.onClick.AddListener(MoveRight);
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        
    }

    private void MoveUp()
    {
        cf.relativeForce = Vector3.forward;
    }

    private void MoveDown()
    {
        cf.relativeForce = Vector3.back;
    }

    private void MoveLeft()
    {
        cf.relativeForce = Vector3.left;
    }

    private void MoveRight()
    {
        cf.relativeForce = Vector3.right;
    }
}
