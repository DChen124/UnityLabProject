using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterBoundary : MonoBehaviour
{
    public float minX = -5f;
    public float maxX = 5f;
    public float minY = -3f;
    public float maxY = 3f;

    void Update()
    {
        // Get the current position of the character
        Vector3 currentPosition = transform.position;

        // Clamp the position to the specified range
        float clampedX = Mathf.Clamp(currentPosition.x, minX, maxX);
        float clampedY = Mathf.Clamp(currentPosition.y, minY, maxY);

        // Update the character's position
        transform.position = new Vector3(clampedX, clampedY, currentPosition.z);
    }
}