
//using System.Diagnostics;
using UnityEngine;
using UnityEngine.AI;

public class Player : MonoBehaviour
{

    [Header("Movement")]
    [SerializeField] float moveSpeed;
    [SerializeField] Transform target;
    [SerializeField] Transform moveObj;

    NavMeshAgent agent;

    void Start()
    {
        agent = GetComponent<NavMeshAgent>();
        //agent.updateUpAxis= false;
        //agent.updateRotation= false;
    }

    
    void Update()
    {
        Movement();
       moveObj.transform.position = transform.position;
    }

    void Movement() 
    {
        float moveX = Input.GetAxis("Horizontal");
        float moveY = Input.GetAxis("Vertical");

        Vector2 mainMov = new Vector2(moveX+0.0001f,moveY);

        //transform.Translate(mainMov * moveSpeed * Time.deltaTime);

        agent.Move(mainMov * moveSpeed * Time.deltaTime);
        //agent.SetDestination(target.position);
    }
}
