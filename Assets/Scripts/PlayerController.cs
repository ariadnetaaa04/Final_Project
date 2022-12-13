using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class PlayerController : MonoBehaviour
{
  
    private int points;
    private float speed = 2f;
    private float turnSpeed = 2f;
    private float horizontalInput;
    private float verticalInput;
    private int score;

    public TMP_Text scoreText;
    public TMP_Text GameOverText;
    private bool GameOver;




    // Start is called before the first frame update
    void Start()
    {
        GameOver = false;
        //The reference to the text.The reference to the object text.Not active
        GameOverText.gameObject.SetActive(false);

        score = 0;
       UpdateScore();
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
            
            Debug.Log($"You have collected {points} coins of 31");
            Destroy(other.gameObject);
            score++;
            UpdateScore();
        }
    }
    private void UpdateScore()
    {
        //La variable que representa el texto y su cadena de texto. "El texto" + la variable de los puntos
        scoreText.text = "Coins: " + score;
    }
    
}
