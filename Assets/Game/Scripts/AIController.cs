﻿using UnityEngine;
using System.Collections;

/// <summary>
/// Attached to the AI prefab, can be activated (try to reach safe zone) and desactivated
/// </summary>
public class AIController : MonoBehaviour 
{
    public GameObject goal;
    private UnityEngine.AI.NavMeshAgent navMesh;

	void Start () 
    {
        navMesh = this.GetComponent<UnityEngine.AI.NavMeshAgent>();
	}
	
	void Update () 
    {
	    
	}

	public void ActivateAI()
	{
		navMesh.destination = goal.transform.position;
	}

	public void DesactiveAI()
	{
		navMesh.destination = this.transform.position;
	}
}
