using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using System.Linq;

public class loadInformation : MonoBehaviour {

    private bool isActive = false;

    // Update is called once per frame
    public GameObject other;


    void Update()
    {

        if (isActive)

        {
            other.GetComponent<AudioSource>().Play();
            SceneManager.LoadScene("InformationalScene", LoadSceneMode.Single);
        }
    }

    void OnSelect()
    {
        isActive = !isActive;
    }
}

