using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FlashlightPickUp : MonoBehaviour {

    public GameObject playerLight;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public void onClick()
    {
        playerLight.SetActive(true);
        Destroy(gameObject);
    }
}
