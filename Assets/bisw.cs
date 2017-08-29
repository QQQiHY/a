using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bisw : MonoBehaviour {
    public hassow hs;
    public GameObject ms;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
    void OnTriggerEnter(Collider other)
    {
        hs.sow = true;
        ms.SetActive(false);
    }
}
