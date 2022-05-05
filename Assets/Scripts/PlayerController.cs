using UnityEngine;
using UnityEngine.SceneManagement;


public class PlayerController : MonoBehaviour
{
    public float speed;
    public Rigidbody rb;
    private int score = 0;
    public int health = 5;


    void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Pickup")
        {
            this.score++;
            Debug.Log("Score: "+ score);
            Destroy(other.gameObject);
        }

        if (other.tag == "Trap")
        {
            health--;
            Debug.Log("Health: " + health);
        }

        if (other.tag == "Goal")
        {
            Debug.Log("You win!");

        
        }
    }


    // Update is called once per frame
    void FixedUpdate()
    {
         float forwordForce = this.speed;
         float backwordForce = this.speed * -1;
        if (Input.GetKey("d") || Input.GetKey("right"))
        {
            rb.AddForce(forwordForce * Time.deltaTime, 0, 0);
        }

        if (Input.GetKey("w") || Input.GetKey("up"))
        {
            rb.AddForce(0, 0, forwordForce * Time.deltaTime);
        }

        if (Input.GetKey("s")|| Input.GetKey("down"))
        {
            rb.AddForce(0, 0, backwordForce * Time.deltaTime);
        }

        if (Input.GetKey("a") || Input.GetKey("left"))
        {
            rb.AddForce(backwordForce * Time.deltaTime, 0, 0);
        }
    }
    void Update()
    {
        if (this.health == 0)
        {
            Debug.Log("Game Over!");
            SceneManager.LoadScene(0, LoadSceneMode.Single);

        }
    }
  
}