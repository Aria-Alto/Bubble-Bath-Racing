using UnityEngine;

public class DirectionSignal : MonoBehaviour
{
    public UiManage_BBR uiManage_BBR;
    // private bool canToggle = true;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        // uiManage_BBR = FindAnyObjectByType<UiManage_BBR>();    
    }

    // Update is called once per frame
    void OnTriggerEnter(Collider other) {
        // if (!canToggle) {return;}
        switch (gameObject.tag) {
            case "d_uTurnLeft":
                uiManage_BBR.toggleUturnLeft(); 
                // canToggle = false;
                break;
            case "d_uTurnRight":
                uiManage_BBR.toggleUturnRight();
                break;
            case "d_LeftTurn":
                uiManage_BBR.toggleTurnLeft();
                break;
            case "d_RightTurn":
                uiManage_BBR.toggleTurnRight();
                break;
        }
    }
}
