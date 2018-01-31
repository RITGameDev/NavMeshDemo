using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class NavMeshtarget : MonoBehaviour
{
    public NavMeshAgent agent;
    
	// Update is called once per frame
	void Update ()
    {
        CheckInput();
	}

    private void CheckInput()
    {
        RaycastHit hit;
        if (Input.GetMouseButtonDown(0))
        {
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            if (Physics.Raycast(ray, out hit))
                agent.SetDestination(hit.point);

        }
    }
}
