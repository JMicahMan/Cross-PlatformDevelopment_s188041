using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlusBehaviour : MonoBehaviour
{
    public GameObject Ball;
    public void spawn()
    {
        Instantiate(Ball);
    }
}
       