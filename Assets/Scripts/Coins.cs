using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Coins : MonoBehaviour
{
    void Update()
    {

        //Rota la moneda una cantidad diferente en cada direcci�n y en cada intervalo de tiempo
        transform.Rotate(new Vector3(0, 0, 90)*UnityEngine.Time.deltaTime);

    }

}
