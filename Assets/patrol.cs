using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class patrol : MonoBehaviour
{
    public GameObject pointA;
    public GameObject pointB;    
    public int speed;
    
    private Rigidbody2D rb;
    private Transform CurrentPoint;
    // Start is called before the first frame update
    void Start()
    {
        CurrentPoint = pointA.transform;
        rb = GetComponent<Rigidbody2D>();
        CurrentPoint = pointA.transform;
    }

    // Update is called once per frame
    void Update()
    {
        Vector2 point = CurrentPoint.position - transform.position;
        if ( CurrentPoint == pointA.transform)
        {
            rb.velocity = new Vector2(-speed, 0);
        }
        else
        {
            rb.velocity = new Vector2(speed, 0);
        }
        if (Vector2.Distance(transform.position, CurrentPoint.position) < 0.5f && CurrentPoint == pointA.transform)
        {
            CurrentPoint = pointB.transform;
        }
        if (Vector2.Distance(transform.position, CurrentPoint.position) < 0.5f && CurrentPoint == pointB.transform)
        {
            CurrentPoint = pointA.transform;
        }
    }
}
