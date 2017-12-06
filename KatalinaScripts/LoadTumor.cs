using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using Academy.HoloToolkit.Unity;
using System.Linq;

namespace Academy.HoloToolkit.Unity
{

    public class LoadTumor : MonoBehaviour
    {
        private bool isActive = false;

        void Update()
        {
            if (isActive)
            {
                SceneManager.LoadScene("TumorScene", LoadSceneMode.Single);

            }
        }
        void OnSelect()
        {
            isActive = !isActive;
        }
    }
}
