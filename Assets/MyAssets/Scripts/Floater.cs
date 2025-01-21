using System;
using UnityEngine;

public class Floater : MonoBehaviour
{
    public Rigidbody rb;
    public float depthBeforeSubmered = 1f;
    public float displacementAmount = 3f;

    private void FixedUpdate() {
        if (transform.position.y < 0f) {
            // Calculating how deep is the object is sunk
            float displacementMultiplyer = Mathf.Clamp01(-transform.position.y / depthBeforeSubmered) * displacementAmount;
            rb.AddForce(new Vector3(0f, Mathf.Abs(Physics.gravity.y) * displacementMultiplyer, 0f), ForceMode.Acceleration);
        }
    }

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
