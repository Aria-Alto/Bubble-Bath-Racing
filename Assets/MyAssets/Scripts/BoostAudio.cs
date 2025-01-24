using UnityEngine;
using System.Collections;

public class BoostAudio : MonoBehaviour
{
  public AudioSource source;

    public void Awake()
    {
      
        
    }
    public void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            source.Play();
            Movement m = other.GetComponent<Movement>();
            m.BoostSpeed();
            Destroy(gameObject);   
        }
       

    }

}
