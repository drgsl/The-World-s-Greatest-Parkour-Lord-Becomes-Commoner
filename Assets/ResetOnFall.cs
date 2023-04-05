using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ResetOnFall : MonoBehaviour
{
    private float resetPoint = -15f;

    void Update()
    {
        if (transform.position.y < resetPoint)
        {
            CheckpointManager.teleportToLastCheckpoint();
        }
    }
}
