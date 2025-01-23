using UnityEngine;

public class Flipper : MonoBehaviour
{
    // Update is called once per frame
    void FixedUpdate()
    {
        if (Vector3.Dot(transform.up, Vector3.down) > 0) {
            Debug.LogWarning("Fliffing");
            gameObject.transform.position = gameObject.transform.position + new Vector3(0,0.20f,0);
            gameObject.transform.rotation = new Quaternion(0, 0, 0, 0);
        }
    }
}
