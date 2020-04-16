using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{

    // Axis variables
    public float horizontalInput;
    public float verticalInput;

    // Speed of the player
    public float speed = 17f;

    // Ranges for players to move
    public float xRange = 16f;
    public float zForwardRange = 17f;
    public float zBackwardRange = -1.5f;

    // Projectile prefab
    public GameObject[] projectiles;

    /* MOUSE MOVE TEST VARIABLES
    * public float mouseHorizontalInput;
    * public float mouseVerticalInput;
    */

    // Update is called once per frame
    void Update()
    {

        if(Input.GetKeyDown(KeyCode.F7))
        {
            // Create a new instance of the projectile on the screen (at player position with player rotation)
            Debug.Log("F7 is pressed down, firing cookie!");
            Instantiate(projectiles[0], transform.position, transform.rotation);
        } else if(Input.GetKeyDown(KeyCode.F8))
        {
            Debug.Log("F8 is pressed down, firing pizza!");
            Instantiate(projectiles[1], transform.position, transform.rotation);
        } else if(Input.GetKeyDown(KeyCode.F9))
        {
            Debug.Log("F9 is pressed down, firing steak!");
            Instantiate(projectiles[2], transform.position, transform.rotation);
        }

        // Axis setup
        horizontalInput = Input.GetAxis("Horizontal");
        verticalInput = Input.GetAxis("Vertical");
        
        // Move the player left and right.
        transform.Translate(Vector3.right * horizontalInput * Time.deltaTime * speed);

        // Move the player forward and backwards
        transform.Translate(Vector3.forward * verticalInput * Time.deltaTime * speed);

        /* X-Coordinate Range Checker
         * Checks if the player is outwith the X range of 16, and if so, snap them back to it. */
        if (transform.position.x < -xRange)
        {
            transform.position = new Vector3(-xRange, transform.position.y, transform.position.z);

        } else if (transform.position.x > xRange)
        {
            transform.position = new Vector3(xRange, transform.position.y, transform.position.z);
        }

        /* Z-Coordinate Range Checker
         * Checks if the player is outwith the Z range of forward 17 and backwards 1.5, and if so, snap them back to it. */
        if(transform.position.z > zForwardRange)
        {
            transform.position = new Vector3(transform.position.x, transform.position.y, zForwardRange);
        } else if(transform.position.z < zBackwardRange)
        {
            transform.position = new Vector3(transform.position.x, transform.position.y, zBackwardRange); 
        }

        /* MOUSE MOVE TEST
        * mouseHorizontalInput = Input.GetAxis("Mouse X");
        * mouseVerticalInput = Input.GetAxis("Mouse Y");

        * transform.Translate(Vector3.right * mouseHorizontalInput * Time.deltaTime * speed);
        * transform.Translate(Vector3.forward * mouseVerticalInput * Time.deltaTime * speed);*/
 
    }
}
