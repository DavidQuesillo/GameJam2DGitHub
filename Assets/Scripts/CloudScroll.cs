using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CloudScroll : MonoBehaviour
{
    public Rigidbody2D rb;
    public Vector2 ScrollSpeed;
    public float DestroyTimer = 5f;

    // Start is called before the first frame update
    void Start()
    {
        rb.AddForce(ScrollSpeed, ForceMode2D.Impulse);
    }

    // Update is called once per frame
    void Update()
    {
        DestroyTimer -= Time.deltaTime;
        if (DestroyTimer <= 0)
        {
            Destroy(gameObject);
        }
    }
}
