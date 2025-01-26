using System.Threading.Tasks;
using Unity.VisualScripting;
using UnityEngine;

public class Movement : MonoBehaviour
{
    Rigidbody rb;
    private float speed = 700f;
    private float boostSpeed = 500f;
    private float regularSpeed = 300;
    public float rotationSpeed = 75f;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    private UiManage_BBR canvasManager;
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        speed = regularSpeed;
        canvasManager = GameObject.FindAnyObjectByType<UiManage_BBR>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.UpArrow)) {
            rb.AddForce(transform.forward * speed * Time.deltaTime);
            canvasManager.ShowMovementSapeedometer(false);
            if (speed == boostSpeed) {
                canvasManager.ShowBoosterSapeedometer(false);
            }
        }
        else {
            canvasManager.ShowMovementSapeedometer(true);
            canvasManager.ShowBoosterSapeedometer(true);
        }
        if (Input.GetKey(KeyCode.   DownArrow)) {
            rb.AddForce(-transform.forward * speed * Time.deltaTime);
            canvasManager.ShowMovementSapeedometer(false);
            if (speed == boostSpeed) {
                canvasManager.ShowBoosterSapeedometer(false);
            }
        }
        // } else {
        //     canvasManager.ShowMovementSapeedometer(true);
        //     canvasManager.ShowBoosterSapeedometer(true);
        // }
        if (Input.GetKey(KeyCode.LeftArrow)) {
            rb.freezeRotation = true;
            transform.Rotate(-transform.up * rotationSpeed * Time.deltaTime);
            rb.freezeRotation = false;
        }
        if (Input.GetKey(KeyCode.RightArrow)) {
            rb.freezeRotation = true;
            transform.Rotate(transform.up * rotationSpeed * Time.deltaTime);
            rb.freezeRotation = false;
        }
    }

    // private void OnTriggerEnter(Collider other) {
    //     if (other.gameObject.tag == "speed_boost") {
    //         speed = boostSpeed;
    //         Destroy(other.gameObject);
    //     }
    // }

    public async Task BoostSpeed() {
        speed = boostSpeed;
        await Task.Delay(3000);
        speed = regularSpeed;
    }
}
