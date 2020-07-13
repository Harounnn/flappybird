using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Bird : MonoBehaviour 
{
    int Score = 0;
    public GameObject ReplayButton;
    Rigidbody2D rb2d;
    //public variables are editable from inspector
    public float speed = 5f;
    //use serializeField to edit a variable even if it is private
    [SerializeField]
    private float flapForce = 20f;
    bool isDead;
    public Text score;
    void OnTriggerEnter2D(Collider2D col)
    {
        if (col.gameObject.tag == "Score") 
        {
            Score++;
            Debug.Log(Score);
            score.text = Score.ToString();
            
        }
        
    }
    void OnCollisionEnter2D(Collision2D col)
    {
        isDead = true;
        rb2d.velocity = Vector2.zero;
        ReplayButton.SetActive(true);
        //change the isDead parameter of the animator to start the dead animation
        GetComponent<Animator>().SetBool("isDead", true);
        //getcomponent<animator>() is a reference to the animator of the bird
    }
    // Start is called before the first frame update
    void Start()
    {
        Time.timeScale = 0;
        //  get a refenrence to the rigidbidy2D of the bird
        rb2d = GetComponent < Rigidbody2D>();
        //Go right
        rb2d.velocity = Vector2.right * speed * Time.deltaTime;
        
    }
    public void UnFreeze() 
    {
        Time.timeScale = 1;
    }

    // Update is called once per frame
    void Update()
    {
        //wait for flap input
        if (Input.GetMouseButtonDown(0)) 
        {
            //Reset velocity
            rb2d.velocity = Vector2.right * speed * Time.deltaTime;
            //add Up force to the bird
            rb2d.AddForce(Vector2.up * flapForce);
        
        }
        if(Input.GetMouseButtonDown(0) && !isDead) 
        {
            rb2d.velocity = Vector2.right * speed * Time.deltaTime;
            rb2d.AddForce(Vector2.up * flapForce);
        }
        
    }
    public void Replay() 
    {
        //this line changes the scene to the scene 0 in your build settings
        SceneManager.LoadScene(0);
    }
}
