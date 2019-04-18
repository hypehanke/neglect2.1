using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class touch : MonoBehaviour
{
    //audio
    public AudioClip hitSound;
    private AudioSource sound;
    private bool played = false;

    void Start()
    {
        //audio
        sound = gameObject.GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        //if (other.CompareTag("patteri_placeholder") && !isTriggered)
        //{
        //Irroitetaan kädestä
        //hand_left.
        Debug.Log("Hitting something");
        Debug.Log(other.gameObject.name);
        Debug.Log(this.gameObject.name + " hit " + other.gameObject.name);

        if( other.gameObject.name == "RightHandCollider" || other.gameObject.name == "LeftHandCollider")
        {
            Debug.Log("### Hitting ###");

            //tämä pitää ajaa omassa functiossaan
            gameObject.GetComponent<activated>().active = false;
            gameObject.GetComponent<activated>().touched = true;
            playSound();
        }
 

        //    isTriggered = true;
        //}
    }

    private void playSound()
    {
        if (!played)
        {
            //gameObject.GetComponent<AudioSource>().Play();
            sound.PlayOneShot(hitSound, 0.9f);
            //played = true;
            //gameObject.GetComponent<AudioClip>();
        }
    }
}
