using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerTeleporter : TargetTeleporter
{
    public static void teleportPlayerTo(Transform location)
    {
        teleportTargetTo("Player", location.transform);
    }
}
