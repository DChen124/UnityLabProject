using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AutoMoveObject : MonoBehaviour
{
    public float speed = 5.0f;
    public float boundaryX = 10.0f;

    void Update()
    {
        MoveObject();
        CheckBoundary();
    }

    void MoveObject()
    {
        // Move the object along the x-axis
        transform.Translate(Vector3.right * speed * Time.deltaTime);
    }

    void CheckBoundary()
    {
        // Check if the object is past the specified distance
        if (Mathf.Abs(transform.position.x) > boundaryX)
        {
            // Reverse the direction when reaching the specified distance
            speed *= -1;
        }
    }
}
