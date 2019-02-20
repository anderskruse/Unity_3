using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class resetCar : MonoBehaviour
{
    public GameObject car;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.F))
        {
            
            //Move car up 3 metres on Y axis
            car.transform.Translate(0, 3, 0);

            car.transform.rotation = Quaternion.identity;


        }
    }

}
