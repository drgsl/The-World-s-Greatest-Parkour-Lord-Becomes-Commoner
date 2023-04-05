using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class CheckpointDisplayer : MonoBehaviour
{
    public TMP_Text checkpointText;

    public static CheckpointDisplayer instance;

    private static int checkpointCount = 0;

    private void Awake()
    {
        checkpointCount = 0;
        if (instance != null)
        {
            Destroy(gameObject);
            return;
        }
        instance = this;

        if(checkpointText == null){
            checkpointText = GetComponentInChildren<TMP_Text>();
        }
    } 

    public static void incrementCheckpointCount(){
        checkpointCount += 1;
        updateCheckpointCount();
    }

    public static void updateCheckpointCount(){
        instance.checkpointText.text = checkpointCount.ToString();
    }
}
