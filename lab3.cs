// agent:

using UnityEngine;
using UnityEngine.AI;

public class AI : MonoBehaviour
{
    public GameObject player;
    public NavMeshAgent agent;

    void Update()
    {
        agent.SetDestination(player.transform.position);
    }
}

// lab3

using UnityEngine;

public class LAB4 : MonoBehaviour
{
    public float speed = 50f;
    public float rotation = 700f;
    public CharacterController controller;
    private Vector3 moveDirection;

    void Update()
    {
        // Get input from the user
        float moveX = Input.GetAxis("Horizontal");
        float moveZ = Input.GetAxis("Vertical");

        // Calculate movement direction based on input
        moveDirection = new Vector3(moveX, 0f, moveZ);

        if (moveDirection.magnitude > 0)  //to look towards someone
        {
            Quaternion toRotation = Quaternion.LookRotation(moveDirection, Vector3.up);
            transform.rotation = Quaternion.RotateTowards(transform.rotation, toRotation,
                rotation * Time.deltaTime);
        }

        // Apply the movement to the character
        controller.Move(moveDirection * speed * Time.deltaTime);
    }
   
}