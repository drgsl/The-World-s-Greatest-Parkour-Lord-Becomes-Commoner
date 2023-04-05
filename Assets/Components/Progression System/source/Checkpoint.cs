using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Checkpoint : MonoBehaviour
{
    static bool canBeUsedMultipleTimes = false;

    public Transform spawnLocation;

    private void Awake()
    {
        if (spawnLocation == null)
            spawnLocation = transform;
    }

    private void OnTriggerEnter(Collider other)
    {
        // print("Triggered");
        if (!other.CompareTag("Player"))
            return;
        CheckpointManager.updateActiveCheckpoint(spawnLocation);

        // TODO: Update Score

        // Destroy checkpoint if it can't be used multiple times
        if (!canBeUsedMultipleTimes)
            gameObject.SetActive(false);
    }

}
