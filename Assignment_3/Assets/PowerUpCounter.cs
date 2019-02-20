using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using DG.Tweening;

public class PowerUpCounter : MonoBehaviour

{
    [SerializeField] TextMeshProUGUI counter;
    public int score;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void counterText()
    {
        counter.text = "Score: " + score.ToString();
        ScaleText();

    }

    public void increment()
    {
        score++;
        counterText();
    }

    void ScaleText()
    {
        counter.transform.DOScale(new Vector3(2f, 2f, 2f), 2f);
    }
}
