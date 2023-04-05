using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotateAround : MonoBehaviour
{
    void Update()
    {
        rotateAroundYAxis();
    }

    void rotateAroundYAxis()
    {
        transform.Rotate(Vector3.up * Time.deltaTime * 50);
    }
}
