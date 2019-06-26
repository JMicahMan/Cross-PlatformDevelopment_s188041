using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MinusBehaviour : MonoBehaviour {

    public GameObject Obj;

    public int MinusCounter;
    public void spawn()
    {
        MinusCounter++;

        //if (Obj.GetComponent<TextBehaviour>().Numbers > Obj.GetComponent<TextBehaviour>().Numbers + 1 || Obj.GetComponent<TextBehaviour>().Numbers < Obj.GetComponent<TextBehaviour>().Numbers - 1)
        //{
        //    MinusCounter = 0;
        //}

    }
}
