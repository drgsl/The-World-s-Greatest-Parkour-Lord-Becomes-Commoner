using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ResetWalls : MonoBehaviour
{
    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            CheckpointManager.teleportToLastCheckpoint();
        }
    }
}
