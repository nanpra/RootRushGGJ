using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class Enemy : MonoBehaviour
{
    [Header("Movement")]
    [SerializeField] float moveSpeed;
    [SerializeField] Transform[] wayPoints;
    [SerializeField] Transform moveObj;
    [SerializeField] float offset;
    [SerializeField] Transform player;
    NavMeshAgent agent;

    void Start()
    {
        agent = GetComponent<NavMeshAgent>();
        //transform.position = wayPoints[0].position;
    }

    // Update is called once per frame
    void Update()
    {
        moveObj.transform.position = transform.position;

        float distance = Vector2.Distance(transform.position, player.position);
        if (distance <= offset)
        {
            PlayerFollow();
        }
    }

    public void PlayerFollow() 
    {
        agent.SetDestination(player.transform.position);
    }
}

