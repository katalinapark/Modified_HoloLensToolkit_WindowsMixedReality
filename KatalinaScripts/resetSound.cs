using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class resetSound : MonoBehaviour
{

    public GameObject sound;
    private bool isActive = false;

    // Update is called once per frame
    void Update()
    {

        if (isActive)

        {
            sound.gameObject.SetActive(false);
            sound.gameObject.SetActive(true);

        }
    }

    void OnSelect()
    {
        isActive = !isActive;
    }
}

