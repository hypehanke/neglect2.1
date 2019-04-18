using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BalleroSystem : MonoBehaviour
{
    public GameObject neglectTarget;
    public int amountOfTargets = 10;
    public int radius = 1;
    //GameObject jee;
    List<GameObject> balleroGameObjects = new List<GameObject>();
    // Start is called before the first frame update
    void Start()
    {
        for (int i = 0; i <= amountOfTargets; i++)
        {
            
            float degree = i * 10;

            var angle = i * Mathf.PI * 2 / amountOfTargets;
            var pos = new Vector3(Mathf.Cos(angle), 0, Mathf.Sin(angle)) * radius;

            GameObject jee = Instantiate(neglectTarget, pos, Quaternion.identity);
            jee.transform.LookAt(gameObject.transform);

            balleroGameObjects.Add( jee );         
            Debug.Log("rot " + transform.rotation.ToString());
        }

        //gameObject.transform.Rotate(0, 0, 0, Space.World);

        //jee.transform.position = new Vector3(0, 0, gameObject.transform.position.z - 20);
    }

    // Update is called once per frame
    void Update()
    {
        
        //jee.transform.Rotat

        //jee.transform.rotation = Quaternion.RotateTowards(transform.rotation, jee.transform.rotation, 0f);
        //Vector3 pos = gameObject.transform.position;
        //pos.x = this.transform.position.x;
        //pos.x = 0;
        //jee.transform.LookAt(pos);
        //jee.transform.LookAt(gameObject.transform);
        //Debug.Log("dsa " + jee.transform.rotation);
    }
}
