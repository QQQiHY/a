using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class lockdoor : MonoBehaviour {
    public GameObject player;
    public bool opening = false;
    public bool trg = false;
    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        if (opening)
        {
            trg = true;
        }
    }
    public void OnTriggerEnter(Collider other)
    {
        
        if (trg == true && (Vector3.Distance(
                gameObject.transform.position,
                player.transform.position) < 5f))
        {
            SceneManager.LoadScene("dra");
        }
    }
}
