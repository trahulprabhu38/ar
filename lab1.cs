using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FirstLab : MonoBehaviour
{
    public float speed = 100f;
    public ParticleSystem Particles;

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.W))
        {
            transform.Translate(Vector3.forward * speed * Time.deltaTime);
        }

        if (Input.GetKeyDown(KeyCode.A))
        {
            transform.Translate(Vector3.left * speed * Time.deltaTime);
        }

        if (Input.GetKeyDown(KeyCode.D))
        {
            transform.Translate(Vector3.right * speed * Time.deltaTime);
        }
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("End"))
        {
            Particles.Play(); // Activate particles on collision with "End" tagged object
        }
    }
}
