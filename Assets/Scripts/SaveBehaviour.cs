using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using System.IO;
using Newtonsoft.Json;


public class SaveBehaviour : MonoBehaviour
{
    public int JNumb;

    public string[] Reader;

    public int JNumb2 = 0;

    public GameObject Obj;

	
    public void StoreData()
    {

        JNumb = Obj.GetComponent<TextBehaviour>().Numbers;

        File.WriteAllText(@"dat.json", JsonConvert.SerializeObject(JNumb));

    }
	
    public void LoadData()
    {
        Reader = File.ReadAllLines(@"dat.json");

        JNumb2 = int.Parse(Reader[0]);

        Obj.GetComponent<TextBehaviour>().Numbers = JNumb2;
    }
}

public class SaveData
{
    public int JNumb3;
}


