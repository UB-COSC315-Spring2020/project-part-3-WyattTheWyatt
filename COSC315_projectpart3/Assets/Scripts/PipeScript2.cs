﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PipeScript2 : MonoBehaviour
{
    public GameObject playerChara;

    public Transform teleportGoal;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerStay(Collider other)
    {
        if ((other.gameObject.tag == "Player"))
        {
            playerChara.transform.position = teleportGoal.transform.position;
            Debug.Log("warp");

        }

    }



}
