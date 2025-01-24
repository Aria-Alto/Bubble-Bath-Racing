using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class QuitStart : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }


    private void Awake()
    {
       
        // adding a delegate with no parameters
        Button btn = GetComponent<Button>();
        btn.onClick.AddListener(NoParamaterOnclick);

        // adding a delegate with parameters
        btn.onClick.AddListener(delegate { ParameterOnClick("Button was pressed!"); });
    }

    private void NoParamaterOnclick()
    {
        Debug.Log("Button clicked with no parameters");
    }

    private void ParameterOnClick(string test)
    {
        Debug.Log(test);
        Application.Quit();
    }
}
