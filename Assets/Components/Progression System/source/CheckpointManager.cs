using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CheckpointManager : MonoBehaviour
{
    static Transform activeCheckpoint;

    private void Update()
    {
        if (!Input.GetKeyDown(KeyCode.R))
            return;

        teleportToLastCheckpoint();
    }

    public static void teleportToLastCheckpoint()
    {
        PlayerTeleporter.teleportPlayerTo(activeCheckpoint);
    }


    public static void updateActiveCheckpoint(Transform newCheckpoint)
    {
        activeCheckpoint = newCheckpoint;
        print("Checkpoint updated to " + activeCheckpoint.position);
        CheckpointDisplayer.incrementCheckpointCount();
    }

}
