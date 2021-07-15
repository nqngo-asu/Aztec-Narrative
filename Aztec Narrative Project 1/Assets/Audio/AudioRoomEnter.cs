using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioRoomEnter : MonoBehaviour
{
    public AudioClip rickroll;
    AudioSource audiosource;
    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("Script Started");
        GetComponent<AudioSource>().clip = rickroll;
        audiosource = GetComponent<AudioSource>();
    }

    void OnCollisionEnter(Collision other)
    {
        Debug.Log ("Collision");
        if(other.gameObject.name == "First person controller full" && !audiosource.isPlaying)
            audiosource.Play();
    }


    // Update is called once per frame
    void Update()
    {
        
    }
}
