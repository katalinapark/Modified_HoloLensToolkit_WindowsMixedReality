﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using Academy.HoloToolkit.Unity;
using System.Linq;

namespace Academy.HoloToolkit.Unity
{
   
    public class loadCollecting : MonoBehaviour
    {
        
        private bool isActive = false;
        public GameObject other; 

    
   
        void Update()
        {

            if (isActive)
            {
                other.GetComponent<AudioSource>().Play(); 
                SceneManager.LoadScene("CollectingScene", LoadSceneMode.Single);
            }
        }


        void OnSelect()
        {
            isActive = !isActive;
        }
    }
}
