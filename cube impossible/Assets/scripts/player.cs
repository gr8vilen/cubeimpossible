using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class player : MonoBehaviour
{
    public float moveSpeed = 5f;
    public Rigidbody2D rb;
    Vector2 movement;
    // Start is called before the first frame update
    //void Start()
    //{

    //}

    // Update is called once per frame
    void Update()
    {
        movement.x = Input.GetAxisRaw("Horizontal");
        movement.y = Input.GetAxisRaw("Vertical");
    }
    void FixedUpdate()
    {
       rb.MovePosition(rb.position + movement * moveSpeed * Time.fixedDeltaTime);
    }
    //own start
    /* void OnCollisionEnter(Collision coll)
    {
        if (coll.gameObject.tag == "Player")
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene());
            //SceneManager.LoadScene(SceneManager.GetActiveScene());
        }
    } */
    void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.tag == "coll")
            //SceneManager.LoadScene("mainlevel");
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }
    //own end
}
