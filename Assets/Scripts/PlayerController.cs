using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class PlayerController : MonoBehaviour
{
    //player movement variables
    private float speed = 2f;
    private float turnSpeed = 2f;
    private float horizontalInput;
    private float verticalInput;
    //total score and poins variables
    private int score;
    private int points = 1;
    //variable to make a reference for the text of the canvas
    public TMP_Text scoreText;
    public TMP_Text GameOverText;
    //variable for the GameOver
    private bool GameOver;




    // Start is called before the first frame update
    void Start()
    {
        //At the beggining the GameOver has to be false to be able to play
        GameOver = false;
        //The reference to the text of the Canva.The reference to the objects text.Mode not active so the text does not show on the screen
        GameOverText.gameObject.SetActive(false);
        //The score has to start with the 0
        score = 0;
        //Calling the function so the score for the canva gets updated
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
       //to recognize with what object the player should react/collide like this
        if (other.gameObject.name.Contains("coin"))
        {
            
            Debug.Log($"You have collected {points} coins of 31");
            Destroy(other.gameObject);
            //the points for the Console
            points++;
            //the total score for the canvas
            score++;
            UpdateScore();

            //Game Over mechanic
            if (score == 31)
            {
                FinalGameOver();
                Time.timeScale = 0;
            }
            
        }
    }
    private void UpdateScore()
    {
        //The variable that represents the text and its text string. "The text" + the variable of the points 
        scoreText.text = "Coins: " + score;
    }

    public void FinalGameOver()
    {
        //This will active the text in the game when the GameOver is true. 
        GameOverText.gameObject.SetActive(true);
        GameOver = true;


    }
    
}
