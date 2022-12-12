using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerController : MonoBehaviour
{
    public Coins coins;
    public Inventory inventory;
    private float speed = 5f;
    private float turnSpeed = 2f;
    private float horizontalInput;
    private float verticalInput;

    //Associates the object textCoins
    public Text textCoins;

    // Start is called before the first frame update
    void Start()
    {
        inventory = GameObject.FindGameObjectWithTag("Player").GetComponent<Inventory>();
         
    }

    // Update is called once per frame
    void Update()
    {
        horizontalInput = Input.GetAxis("Horizontal");
        verticalInput = Input.GetAxis("Vertical");

        transform.Translate(Vector3.forward * speed * UnityEngine.Time.deltaTime * verticalInput);
        transform.Translate(Vector3.right * turnSpeed * UnityEngine.Time.deltaTime * horizontalInput);
        
    }
    private void OnTriggerEnter(Collider other)
    {
       
        if (other.gameObject.name.Contains("coin"))
        {
            inventory.Quantity = inventory.Quantity + 1;
            Destroy(other.gameObject);
        }
    }
}
