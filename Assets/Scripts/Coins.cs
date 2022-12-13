using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Coins : MonoBehaviour
{
    /*
    //buscar script puntos
    public GameObject ObjPoints;
    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            ObjPoints.GetComponent<Puntos>().points += 1;
            Destroy(gameObject);
        }
    }
    */

   // public Inventory Inventory;
   // public Text puntos;

    // Start is called before the first frame update
    void Start()
    {
       // Inventory = GameObject.FindGameObjectWithTag("Player").GetComponent<Inventory>();
    }

    // Update is called once per frame
    void Update()
    {

        //Rota la moneda una cantidad diferente en cada dirección y en cada intervalo de tiempo
        transform.Rotate(new Vector3(0, 0, 90)*UnityEngine.Time.deltaTime);

    }

}
