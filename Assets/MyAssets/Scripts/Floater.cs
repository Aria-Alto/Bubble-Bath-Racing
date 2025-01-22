using System;
using Unity.VisualScripting.FullSerializer;
using UnityEngine;

public class Floater : MonoBehaviour
{
    public Rigidbody rb;
    public float depthBeforeSubmered = 1f;
    public float displacementAmount = 3f;
    public int floaterCount = 1;
    public float waterDrag = 0.99f;
    public float waterAngularDrag = 0.5f;

    public GameObject water;

    private void FixedUpdate() {
        rb.AddForceAtPosition(Physics.gravity / floaterCount, transform.position, ForceMode.Acceleration);

        float waveHeight = WaveManager.instance.GetWaveHeight(transform.position.x) + WaveManager.instance.transform.position.y;
        Debug.Log(waveHeight);
        if (transform.position.y < waveHeight) {
            // Calculating how deep is the object is sunk
            float displacementMultiplyer = Mathf.Clamp01((waveHeight - transform.position.y) / depthBeforeSubmered) * displacementAmount;
            rb.AddForceAtPosition(new Vector3(0f, Mathf.Abs(Physics.gravity.y) * displacementMultiplyer, 0f), transform.position, ForceMode.Acceleration);
            rb.AddForce(displacementMultiplyer * -rb.linearVelocity * waterDrag * Time.deltaTime, ForceMode.VelocityChange);
            rb.AddTorque(displacementMultiplyer * -rb.angularVelocity * waterAngularDrag * Time.deltaTime, ForceMode.VelocityChange);
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
