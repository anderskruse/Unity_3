using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletScript : MonoBehaviour
{
    public int destroyTime;
    public GameObject explosion;
    private GameObject explo;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Destroy(gameObject, 5);


    }

    private void OnTriggerEnter(Collider other)
    {

        if(other.gameObject.transform.tag == "Enemy")
        {
            explo = Instantiate(explosion);
            explo.transform.position = other.transform.position;
            explo.gameObject.SetActive(true);
            other.gameObject.SetActive(false);
        }
        
    }

}
