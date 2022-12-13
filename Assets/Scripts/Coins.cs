using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Coins : MonoBehaviour
{
    void Update()
    {

        //Rotates the coin a different amount in each direction and at each time interval
        transform.Rotate(new Vector3(0, 0, 90)*UnityEngine.Time.deltaTime);

    }

}
