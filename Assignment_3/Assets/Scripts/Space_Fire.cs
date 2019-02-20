using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Space_Fire : MonoBehaviour
{
    public GameObject bullet;
    public Transform barrelLocation;

    public float speed = 1000000000000f;
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.F))
        {
            GameObject instBullet = Instantiate(bullet, transform.transform.position, Quaternion.identity) as GameObject;
            instBullet.GetComponent<Rigidbody>().AddForce(barrelLocation.forward * speed);
            
        }
    }
}
