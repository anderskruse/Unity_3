using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;
using TMPro;

public class CountdownTimer : MonoBehaviour

{
    [SerializeField] TextMeshProUGUI canvascounter;

    public GameObject car;
    public float countdown;

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        CountText();
    }

    void CountText()
    {
        countdown -= Time.deltaTime;
        canvascounter.text = "Time left: " + countdown.ToString("F2");

        if(countdown < 0)
        {
            GameOver();
            canvascounter.text = "GAME OVER, THE TIME RAN OUT.";

        }
    }

    void GameOver()
    {
            Destroy(car);
    }

    public void increment()
    {
        countdown += 5;
    }
}
