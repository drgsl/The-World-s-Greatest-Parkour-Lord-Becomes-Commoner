using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TargetTeleporter : MonoBehaviour
{
    public static void teleportTargetTo(string targetTag, Transform location)
    {
        print("Teleporting " + targetTag + " to " + location.position);
        GameObject target = getTargetByTag(targetTag);
        if (target == null)
            return;

        target.transform.position = location.position;
    }

    private static GameObject getTargetByTag(string targetTag)
    {
        GameObject target = GameObject.FindGameObjectWithTag(targetTag);
        if (target == null)
            Debug.LogError("No target with tag " + targetTag + " found.");
        return target;
    }

}
