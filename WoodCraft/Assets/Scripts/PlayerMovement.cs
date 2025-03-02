﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class PlayerMovement : MonoBehaviour
{
    NavMeshAgent agent;
    public GameObject panel;
    

    void Start()
    {
        agent = GetComponent<NavMeshAgent>();
    }

    void Update()
    {
        if(Input.touchCount > 0)
        {
            RaycastHit hit;
            Ray ray = Camera.main.ScreenPointToRay(Input.GetTouch(0).position);
            if(Physics.Raycast(ray, out hit, Mathf.Infinity))
            {
                agent.SetDestination(hit.point);

                if(hit.transform.name == "Cube")
                {
                    panel.SetActive(true);
                    GetComponent<PlayerMovement>().enabled = false;
                }
            }
            
        }
    }

    public void TurnOnMovement()
    {
        GetComponent<PlayerMovement>().enabled = true;
    }
}
