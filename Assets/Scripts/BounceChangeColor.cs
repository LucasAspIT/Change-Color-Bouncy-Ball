using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BounceChangeColor : MonoBehaviour
{
    [SerializeField]
    private bool enableAutoBounce = true;

    [SerializeField]
    [Range(200f, 400f)]
    private float bounceForce = 300f;

    Rigidbody rb;
    Renderer mat;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        mat = GetComponent<Renderer>();
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (enableAutoBounce)
        {
            rb.AddForce(0f, bounceForce, 0f);
        }

        // Set a random color when a collision is detected
        mat.material.color = Random.ColorHSV(0f, 1f, 1f, 1f, 1f, 1f, 1f, 1f);
    }
}
