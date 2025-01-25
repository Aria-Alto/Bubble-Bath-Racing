using System.Collections;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class UiManage_BBR : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    public Image TurnLeft;
    public Image TurnRight;
    public Image UturnRight;
    public Image UturnLeft;
    public Image movementSpeedometer;
    public Image boosterSpeedometer;
    void Start()
    {
        ResetDirections();   
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.V))
        {
            toggleTurnRight();
        }
        if (Input.GetKeyDown(KeyCode.Z))
        {
            toggleTurnLeft();
        }
        if (Input.GetKeyDown(KeyCode.X))
        {
            toggleUturnRight();
        }
        if (Input.GetKeyDown(KeyCode.C))
        {
            toggleUturnLeft();
        }
    }



    public void toggleTurnLeft()
    {
        // TurnLeft.enabled = !TurnLeft.enabled; 
        StartCoroutine(Togglewaiter(TurnLeft));
    }

    public void toggleTurnRight()
    {
        // TurnRight.enabled = !TurnRight.enabled;
        StartCoroutine(Togglewaiter(TurnRight));
    }
 
    public void toggleUturnLeft()
    {
        // UturnLeft.enabled = !UturnLeft.enabled;
        StartCoroutine(Togglewaiter(UturnLeft));
    }

    public void toggleUturnRight()
    {
        // UturnRight.enabled = !UturnRight.enabled;
        StartCoroutine(Togglewaiter(UturnRight));
    }

    IEnumerator Togglewaiter(Image image) {
        ResetDirections();
        image.enabled = true;
       yield return new WaitForSeconds(2);
       image.enabled = false;
    }

    private void ResetDirections() {
        Debug.Log("Reseting");
        TurnLeft.enabled = false;
        TurnRight.enabled = false;
        UturnRight.enabled = false;
        UturnLeft.enabled = false;
    }

    public void ShowMovementSapeedometer(bool show) {
        movementSpeedometer.gameObject.SetActive(show);
    }

    public void ShowBoosterSapeedometer(bool show) {
        boosterSpeedometer.gameObject.SetActive(show);
    }
    
}



