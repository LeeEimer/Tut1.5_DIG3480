using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MusicScript : MonoBehaviour
{
    public AudioSource musicSource; 

    public AudioClip musicClipOne;

    public AudioClip musicClipTwo; 

     Animator anim;
    
    // Start is called before the first frame update
    void Start()
    {
        anim = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update(){
        //audio clip 1 + Walk
        if(Input.GetKeyDown(KeyCode.W)){
            musicSource.clip = musicClipOne;
            musicSource.Play(); 
            anim.SetInteger("State", 1);
        }
        if(Input.GetKeyUp(KeyCode.W)){
            musicSource.Stop();
            anim.SetInteger("State", 0);
        }
        //audio clip 2 + Run
        if(Input.GetKeyDown(KeyCode.R)){
            musicSource.clip = musicClipTwo;
            musicSource.Play(); 
            anim.SetInteger("State", 2);
        }
        if(Input.GetKeyUp(KeyCode.R)){
            musicSource.Stop();
            anim.SetInteger("State", 0);
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
