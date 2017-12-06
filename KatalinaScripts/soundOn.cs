using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class soundOn : MonoBehaviour
{

    private bool isActive = false;

    // Update is called once per frame
    public GameObject sound;
 

 

    void Update()
    {

        if (isActive)

        {
          
            sound.gameObject.SetActive(true);
        }
    }

    void OnSelect()
    {
        isActive = !isActive;
        sound.gameObject.SetActive(false);
    }
}

