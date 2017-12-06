﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Academy.HoloToolkit.Unity;
using System.Linq;


namespace Academy.HoloToolkit.Unity
{

    public class GestureHandlerHealthyKidney: Singleton<GestureHandlerHealthyKidney>
    {

        public GameObject body;
        public GameObject kidneyCancer;
        public GameObject arteryBig;
        public GameObject collectingBig;
        public GameObject tumorBig;
        public GameObject veinBig;
        public GameObject healthyKidney;



        private bool isActive = false;





        void Update()
        {

            if (isActive)
            {
                body.SetActive(false);
                kidneyCancer.SetActive(false);
                arteryBig.SetActive(false);
                collectingBig.SetActive(false);
                tumorBig.SetActive(false);
                veinBig.SetActive(false);
                healthyKidney.SetActive(true);
            }

        }

        void OnSelect()
        {
            isActive = !isActive;
        }

    }
}