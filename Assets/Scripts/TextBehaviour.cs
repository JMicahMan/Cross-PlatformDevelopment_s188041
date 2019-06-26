using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TextBehaviour : MonoBehaviour {

    public GameObject Obj1;
    public GameObject Obj2;
    public GameObject Obj3;

    
    public int Numbers = 0;

   // private string testNumbs;

    public Text txt;
	void Start ()
    {
        txt = GetComponent<Text>();
	}
	

    public void lod()
    {
        Numbers = Obj3.GetComponent<SaveBehaviour>().JNumb2;
    }

    public void plusit()
    {
        //Numbers = Numbers + Obj1.GetComponent<PlusBehaviour>().PlusCounter;

        Numbers++;
    }

    public void Minusit()
    {
        //Numbers = Numbers - Obj2.GetComponent<MinusBehaviour>().MinusCounter;
        Numbers--;
    }

    // Update is called once per frame
    void Update ()
    {

       // Numbers = Numbers + (Obj1.GetComponent<PlusBehaviour>().PlusCounter - Obj2.GetComponent<MinusBehaviour>().MinusCounter);

        //  testNumbs = "123";

        txt.text = Numbers.ToString();

	}

}
