﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlusBehaviour : MonoBehaviour
{
    public GameObject Obj;

    public int PlusCounter;
    public void spawn()
    {
        PlusCounter++;

        //if (Obj.GetComponent<TextBehaviour>().Numbers > Obj.GetComponent<TextBehaviour>().Numbers + 1 || Obj.GetComponent<TextBehaviour>().Numbers < Obj.GetComponent<TextBehaviour>().Numbers - 1)
        //{
        //    PlusCounter = 0;
        //}
    }
}
       