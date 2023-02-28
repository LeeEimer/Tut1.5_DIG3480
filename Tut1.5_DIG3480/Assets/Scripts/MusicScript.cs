using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MusicScript : MonoBehaviour
{
    public AudioSource musicSource; 

    public AudioClip musicClipOne;

    public AudioClip musicClipTwo; 
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update(){
        //audio clip 1
        if(Input.GetKeyDown(KeyCode.W)){
            musicSource.clip = musicClipOne;
            musicSource.Play(); 
        }
        if(Input.GetKeyUp(KeyCode.W)){
            musicSource.Stop();
        }
        //audio clip 2
        if(Input.GetKeyDown(KeyCode.R)){
            musicSource.clip = musicClipTwo;
            musicSource.Play(); 
        }
        if(Input.GetKeyUp(KeyCode.R)){
            musicSource.Stop();
        }
        //add loop
         if (Input.GetKeyDown(KeyCode.L)){
          musicSource.loop = true;
         }

        if (Input.GetKeyUp(KeyCode.L)){
          musicSource.loop = false;
        }
    }
}
