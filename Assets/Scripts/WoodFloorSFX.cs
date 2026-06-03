using UnityEngine;

public class WoodFloorSFX : MonoBehaviour
{
    public AudioSource stepsSource;
    public AudioClip madera;
    public AudioClip hierba;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            AudioManager.instance.SetSurface(madera);
        }  
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            AudioManager.instance.SetSurface(hierba);
        }    
    }
}
