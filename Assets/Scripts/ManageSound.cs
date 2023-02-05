using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ManageSound : MonoBehaviour
{
   
    public AudioSource AAudioSource;
    float musicVolume=1f;
    
    // Start is called before the first frame update
    void Start()
    {
       AAudioSource.Play();
        
    }

    // Update is called once per frame
    void Update()
    {
        AAudioSource.volume = musicVolume;
    }
    public void VolumeChange(float volume)
    {
        musicVolume = volume;

    }
}
