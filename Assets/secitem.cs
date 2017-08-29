using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class secitem : MonoBehaviour {

    public SECSOW shs;
    public GameObject ms;
    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }
    void OnTriggerEnter(Collider other)
    {
        {
            shs.sesow = true;
            ms.SetActive(false);
        }
    }
}
