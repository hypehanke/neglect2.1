using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class Presets
{
    [SerializeField]
    public float speed;
    [SerializeField]
    public float randomTime;
    [SerializeField]
    public float scaleSize;

    public Presets(float speed, float randomTime, float scaleSize)
    {
        this.speed = 1f;
        this.randomTime = 1f;
        this.scaleSize = 1f;
    }
    
}

public class ChangeToPreset : MonoBehaviour
{
    public GameObject sliderSpeed;
    public List<Presets> presetsAverage; // = new List<Presets>();
    // Start is called before the first frame update
    void Start()
    {
        presetsAverage.Add(new Presets(80f,0.5f,1f));
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void TriggerButton()
    {
        Debug.Log(presetsAverage[0].speed);

        sliderSpeed.GetComponent<ChangeSpeedSlider>().startFadeDone = false;
        sliderSpeed.GetComponent<ChangeSpeedSlider>().defaultSpeed = presetsAverage[0].speed;
        
        
    }
}
