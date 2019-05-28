using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ChangeSpeedSlider : MonoBehaviour
{
    public Slider slider;
    public float defaultSpeed = 50f;
    //public float defaultSpeed = 0.5f;
    public bool startFadeDone = false;

    public GameObject affectedObject;

    public float setScaled;
    public int balleroAmount;

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //slider.value = Mathf.MoveTowards(slider.value, 1f, 2f * Time.deltaTime);
        //Debug.Log("slider.value");
        //Debug.Log(slider.value);

        if (gameObject.tag == "Speed")
        {
            affectedObject.GetComponent<Movement>().speedMin = slider.value;
            fadeSliderOnChange(defaultSpeed);
        } else if (gameObject.tag == "Size") {
            setScaled = slider.value;
        } else if (gameObject.tag == "Amount")
        {
            balleroAmount = (int) slider.value;
        }
    }

    public void fadeSliderOnChange(float defaultValue) {
        float defaultStart = defaultValue;
        //float defaultSpeedStart = defaultSpeed;
        //Debug.Log("startFadeDone");
        //Debug.Log(startFadeDone);
        if (!startFadeDone)
        {
            if (slider.value != defaultStart)
            {
                slider.value = Mathf.MoveTowards(slider.value, defaultStart, 0.5f * Time.deltaTime);
            }
            else
            {
                startFadeDone = true;
            }
            
        }
    }
}
