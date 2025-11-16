using UnityEngine;

public class Bird_Script : MonoBehaviour
{
    public float flapStrength;
    public Rigidbody2D myRigidBody2D;
    public LogicManager logic;
    public bool birdAlive=true;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        logic = GameObject.FindGameObjectWithTag("Logic Manager").GetComponent<LogicManager>();

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space) == true && birdAlive)
        {
            myRigidBody2D.linearVelocity = Vector2.up * flapStrength;

        }
       
    }
    

    private void OnCollisionEnter2D(Collision2D collision)
    {
        Debug.Log("Collision is hapenning-tryign to play the game over");
        logic.gameOver();
        birdAlive = false;
        
    }
}
