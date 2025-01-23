using UnityEngine;

public class Camera3D_Following_Boat : MonoBehaviour
{
    public Transform player;

    // public float x_offset = 1.3f;
    // public float y_offset = 0.6f;
    // public float z_offset = -0.04f;
    // public float rotate_yaw = 0f;
    // public float rotate_pitch = 0f;




    // // Update is called once per frame
    // void Update () {
    //     transform.position = player.transform.position + new Vector3(x_offset,y_offset, z_offset);
    //     transform.rotation = player.transform.rotation;
    // }
    // public Transform player;
    public float smoothSpeed = 0.03f;
    public Vector3 locationOffset = new Vector3(0, 0.52f, -1.3f);
    public Vector3 rotationOffset = new Vector3(19.46f, 0, 0);

    // void Start () {
    //     locationOffset = new Vector3(0, 0.52f, -1.3f);
    //     rotationOffset = new Vector3(19.46f, 0, 0);
    // }

    void FixedUpdate()
    {
        Vector3 desiredPosition = player.position + player.rotation * locationOffset;
        Vector3 smoothedPosition = Vector3.Lerp(transform.position, desiredPosition, smoothSpeed);
        transform.position = smoothedPosition;

        Quaternion desiredrotation = player.rotation * Quaternion.Euler(rotationOffset);
        Quaternion smoothedrotation = Quaternion.Lerp(transform.rotation, desiredrotation, smoothSpeed);
        transform.rotation = smoothedrotation;
    }
}
