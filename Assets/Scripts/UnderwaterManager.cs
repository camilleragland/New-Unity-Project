using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;
using UnityStandardAssets.Characters.FirstPerson;

public class UnderwaterManager : MonoBehaviour
{
   
    public GameObject player;
    public GameObject underwaterVolume;
    public AudioSource natureSound;
    public bool isUnderwater;
   
    
    

    void Start()
    {
        
        
        underwaterVolume.SetActive(false);
        isUnderwater = false;
        

    }

    // Update is called once per frame
    void FixedUpdate()
    {
        if (player.transform.position.y < 17.0f)
        
            UnderWaterBehavior();
        

        else if(player.transform.position.y >= 17.0f)
            OnLandBehavior();
    }


    void UnderWaterBehavior()
    {
        
            underwaterVolume.SetActive(true);
            natureSound.Pause();
            Debug.Log("Sound paused");
            isUnderwater = true;


    }

    void OnLandBehavior ()
    {
        
            underwaterVolume.SetActive(false);
            natureSound.UnPause();
            isUnderwater = false;
            Debug.Log("Out of water");
    }

   
}
