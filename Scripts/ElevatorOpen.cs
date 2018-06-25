using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ElevatorOpen : MonoBehaviour {

    public Animator anim;
    public BoxCollider boxCol;

    public bool locked = true;
    public bool opening = false;

    public void Start()
    {
        boxCol = GetComponent<BoxCollider>();
    }

    public void Update()
    {
        if (!opening)
        {
            anim.StartPlayback();
            boxCol.enabled = false;
        }
        else
        {
            anim.StopPlayback();
        }

    }

    public void ElevatorDoorsOpen()
    {
        locked = false;

        if (!locked)
        {
            opening = true;
        }
        else
        {

        }

    }
}
