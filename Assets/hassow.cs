using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class hassow : MonoBehaviour {
    public bool sow = false;
    public lockdoor ld;
    public GameObject sw;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if (sow)
        {
            sw.SetActive(true);
            ld.opening = true;
        }
	}
}