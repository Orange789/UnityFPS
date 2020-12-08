using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class npc : MonoBehaviour
{
    public Transform target;
    NavMeshAgent agent;
    public float range;
    string theCollider;
    public GameObject receiver;
    // Start is called before the first frame update
    void Start()
    {
        agent = GetComponent<NavMeshAgent>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Vector3.Distance(target.position, transform.position) < range)
        {
            agent.SetDestination(target.position);
        }

        
    }

    public void OnTriggerEnter(Collider other)
    {
        theCollider = other.tag;
        if (theCollider == "Player")
        {
            receiver.SendMessage("DecreaseHealth");
        }
    }
}


