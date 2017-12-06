using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using Academy.HoloToolkit.Unity;
using System.Linq;

namespace Academy.HoloToolkit.Unity
{
    public class rendMat : MonoBehaviour
    {
    
        private bool isActive = false;
        public Material[] material;
        Renderer rend;
     

        void Start()
        {
            rend = GetComponent<Renderer>();
            rend.enabled = true;
            rend.sharedMaterial = material[0];
        }

        void Update()
        {
            if (isActive)
            {

         
                // assign it to the renderer
                rend.sharedMaterial = material[1];
            }
        }

        void OnSelect()
        {
            isActive = !isActive;
            rend.sharedMaterial = material[0];
      
        }
    }
}