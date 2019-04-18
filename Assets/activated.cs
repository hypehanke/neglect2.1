using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class activated : MonoBehaviour
{
    //audio
    public AudioClip beaconSound;
    private AudioSource sound;
    private bool played = false;

    //general
    public bool active = false;
    public bool touched = false;
    public Vector3 startSize = new Vector3(0.35f, 0.35f, 0.35f);
    private Color originalMaterial;

    //changeable from settings
    public float scaleAmount = 1f;
    
    // Start is called before the first frame update
    void Start()
    {
        //audio
        sound = GetComponent<AudioSource>();
 
        //general
        originalMaterial = gameObject.GetComponent<Renderer>().material.color;
    }

    // Update is called once per frame
    void Update()
    {
        if (active && !touched)
        {
            gameObject.transform.localScale = new Vector3(scaleAmount, scaleAmount, scaleAmount);
            gameObject.GetComponent<Renderer>().material.color = Color.green;
            playSound();
        }
        else
        {
            gameObject.transform.localScale = startSize;
            gameObject.GetComponent<Renderer>().material.color = originalMaterial;

            played = false;
        }

        if (touched)
        {
            gameObject.GetComponent<Renderer>().material.color = Color.blue;
            
        }
    }

    private void playSound() {
        if (!played)
        {
            //gameObject.GetComponent<AudioSource>().Play();
            sound.PlayOneShot(beaconSound, 0.1f);
            played = true;
        }
    }
}
