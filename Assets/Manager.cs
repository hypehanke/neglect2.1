using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Manager : MonoBehaviour
{
    //public List<GameObject> balleros = new List<GameObject>();
    public GameObject playerObject;
    public List<GameObject> balleros;
    public static int currentIndex;
    private float delay = 4f;
    // Start is called before the first frame update
    void Start()
    {
        balleros = playerObject.GetComponent<BalleroSystem>().balleroGameObjects;
        currentIndex = Random.Range(0, 7);
        //InvokeRepeating("makeRandom", 0f, delay);
        makeRandom();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void makeRandom()
    {
        
        balleros[currentIndex].gameObject.GetComponent<activated>().active = true;
        StartCoroutine("deActivate");
    }
    private IEnumerator deActivate(){
        yield return new WaitForSeconds(delay);
        balleros[currentIndex].gameObject.GetComponent<activated>().active = false;
        if (balleros[currentIndex].gameObject.GetComponent<activated>().touched)
        {
            //poistellaan se
            balleros.Remove(balleros[currentIndex]);
        }
        currentIndex = Random.Range(0, balleros.Count);
        makeRandom();
    }
}
