using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class triggerJumpscareSound : MonoBehaviour {

    public AudioSource jumpscareSound;
    
    void OnTriggerEnter(Collider col)
    {
        if (col.gameObject.tag == "Player")
        {
            jumpscareSound.Play();
        }

    }
}
