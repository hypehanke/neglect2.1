using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BalleroSystem : MonoBehaviour
{
    public GameObject neglectTarget;
    public int amountOfTargets = 5;
    public float radius = 1.2f;
    public List<GameObject> balleroGameObjects = new List<GameObject>();

    void Start()
    {
        BalleroCreator();
    }

    // Update is called once per frame
    void Update()
    {

    }

    private void BalleroCreator() {
        for (int i = 0; i <= amountOfTargets; i++)
        {

            float degree = i * 10;
            var angle = i * Mathf.PI * 2 / amountOfTargets;
            var pos = new Vector3(Mathf.Cos(angle), 0, Mathf.Sin(angle)) * radius;

            GameObject jee = Instantiate(neglectTarget, pos, Quaternion.identity);
            jee.transform.LookAt(gameObject.transform);

            balleroGameObjects.Add(jee);
            Debug.Log("rot " + transform.rotation.ToString());
        }
    }
}
