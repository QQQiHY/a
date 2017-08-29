using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SECSOW : MonoBehaviour {
    public bool sesow = false;
    public GameObject sd;
    public GameObject ssw;
    public GameObject ssd;
    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (sesow && Input.GetKeyDown(KeyCode.Alpha1))
        {
            sd.SetActive(true);
            ssw.SetActive(false);
            ssd.SetActive(false);
        }
        else if (sesow && Input.GetKeyDown(KeyCode.Alpha2))
        {
            sd.SetActive(false);
            ssw.SetActive(true);
            ssd.SetActive(true);
        }
    }
}
