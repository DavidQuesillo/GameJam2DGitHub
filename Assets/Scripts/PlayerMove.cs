using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMove : MonoBehaviour
{
    public Rigidbody2D rb;
    public Vector2 MoveSpeed;
    public LeftButton ButtonL;
    public RightButton ButtonR;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (ButtonL.left == true)
        {
            rb.AddForce(MoveSpeed, ForceMode2D.Force);
        }
        if (ButtonR.right == true)
        {
            rb.AddForce(-MoveSpeed, ForceMode2D.Force);
        }
    }
}
