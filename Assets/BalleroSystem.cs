using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BalleroSystem : MonoBehaviour
{
    public GameObject neglectTarget;
    public int amountOfTargets;
    public float radius = 1.2f;
    public float balleroSize = 0.35f;

    //empty list for balleros to be added
    public List<GameObject> balleroGameObjects = new List<GameObject>();

    public GameObject sizeSliderObject;
    public GameObject amountSliderObject;

    void Start()
    {
        BalleroCreator();
    }

    // Update is called once per frame
    void Update()
    {
        int count = balleroGameObjects.Count;
        balleroSize = sizeSliderObject.GetComponent<ChangeSpeedSlider>().setScaled / 100;
        
        if (amountOfTargets != amountSliderObject.GetComponent<ChangeSpeedSlider>().balleroAmount) {
            amountOfTargets = amountSliderObject.GetComponent<ChangeSpeedSlider>().balleroAmount;
            for (int i = 0; i < count; i++)
            {
                Destroy(balleroGameObjects[i]);
            }
            balleroGameObjects = new List<GameObject>();

            BalleroCreator();
        }
        if (balleroGameObjects[0].GetComponent<activated>().startSize.x != balleroSize)
        {
            for (int i = 0; i < count; i++)
            {
                balleroGameObjects[i].GetComponent<activated>().startSize = new Vector3(balleroSize, balleroSize, balleroSize);
            }
        }
    }

    private void BalleroCreator() {
        for (int i = 0; i < amountOfTargets; i++)
        {

            float balleroAngle = 180 / amountOfTargets;

            //float degree = i * 10;
            float degree = i * balleroAngle;
            var angle = i * Mathf.PI * 2 / amountOfTargets;
            var pos = new Vector3(Mathf.Cos(angle), 0, Mathf.Sin(angle)) * radius;

            GameObject ballero = Instantiate(neglectTarget, pos, Quaternion.identity);
            
            ballero.transform.LookAt(gameObject.transform);
            ballero.transform.localScale = new Vector3(0.1f, 0.1f, 0.1f);

            balleroGameObjects.Add(ballero);
            //Debug.Log("rot " + transform.rotation.ToString());
        }
    }
}
