using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{ 
    private Vector3 pos;
    private bool up = true;
    private float speed;

    //changeable from settings
    public float randomTime = 5f; //delay for how often ball is changed
    public float speedMin = 0.5f;
    public float speedMax = 2f;

    // Start is called before the first frame update
    void Start()
    {
        pos = gameObject.transform.position;
        InvokeRepeating("speedVariation",1f,randomTime);
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 posCurrent = gameObject.transform.position;

        if (posCurrent.y < pos.y + 1.2 && up) {
            transform.Translate(0, speed * Time.deltaTime, 0);
        }
        else {
            up = false;
        }

        if (posCurrent.y > pos.y - 1.2 && !up) {
            transform.Translate(0, -speed * Time.deltaTime, 0);
        }
        else
        {
            up = true;
        }

    }
    private void speedVariation(){
        speed = Random.Range(speedMin, speedMax);
        //Debug.Log("Speed set(random) " + speed);
    } 
}
