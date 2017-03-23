using UnityEngine;
using System.Collections;

public class PlayerController : MonoBehaviour {
    // Public fields
    public float speed;

    public GameObject laser;
    public Transform laserSpawn;

    // Private fields
    private Rigidbody2D rb;

    private float nextFire = 0.5f; // How often the player can shoot.
    private float myTime = 0.0f; // Variable to hold our time

    // Initialize our variables
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        myTime += Time.deltaTime;

        if(Input.GetButton("Fire1") && myTime > nextFire)
        {
            Instantiate(laser, laserSpawn.position, laserSpawn.rotation);

            myTime = 0.0f;
        }
    }

    // When using physics
	void FixedUpdate () {
        float moveHorizontal = Input.GetAxis("Horizontal");
        float moveVertical = Input.GetAxis("Vertical");

        Vector2 movement = new Vector2(moveHorizontal, moveVertical);
        rb.velocity = movement * speed;

        rb.position = new Vector2(Mathf.Clamp(rb.position.x, -8.0f, 4.0f),
            Mathf.Clamp(rb.position.y, -4.25f, 4.25f));
	}
}
