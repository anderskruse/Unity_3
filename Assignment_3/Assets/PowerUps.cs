using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using DG.Tweening;

public class PowerUps : MonoBehaviour
{
    public AudioSource audio;
    public GameObject player;
    public PowerUpCounter pou;
    float posX;
    float posY;
    float posZ;
    public float targetX;


    void Start()
    {
        posX = transform.position.x;
        posY = transform.position.y;
        posZ = transform.position.z;

        StartCoroutine("CoroutineDemo");
    }


    void Update()
    {

    }
    void OnTriggerEnter(Collider other)
    {

        if (other.gameObject.tag == "Player")
        {
            pou.increment();
            Destroy(gameObject);
            audio.Play();


        }

    }

    IEnumerator CoroutineDemo()
    {
    
            yield return new WaitForSeconds(1f);
            DoMove();
            CoroutineDemo();

    }

    void DoMove()
    {
        transform.DOMove(new Vector3(transform.position.x + targetX, posY, posZ), 5f);
    }


}
