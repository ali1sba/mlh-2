﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class tmer : MonoBehaviour
{
     [SerializeField]private Text uitext;
     [SerializeField]private float mainTimer;
     private float timer;
     private bool canCount=true;
     private bool doOnce=false;
       void Start()
    {
        timer=mainTimer;
    }

    // Update is called once per frame
    void Update()
    {
        if (timer>= 0.0f && canCount){
            timer -= Time.deltaTime;
            uitext.text =timer.ToString("F");
        }
        else if (timer<=0.0f && !doOnce){
            canCount= false;
            doOnce=true;
            uitext.text="0.00";
            timer=0.0f;
        }
    }
}
