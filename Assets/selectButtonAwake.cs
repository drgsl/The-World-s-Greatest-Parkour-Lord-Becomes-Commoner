using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

[RequireComponent(typeof(Button))]
public class selectButtonAwake : MonoBehaviour
{
    private void onEnable()
    {
        print("onenable");
        GetComponent<Button>().Select();
    }

    public void Awake()
    {
        GetComponent<Button>().Select();
    }

}
