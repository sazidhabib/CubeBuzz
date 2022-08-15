
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    //This is the reference to the Rigidbody component called "rc"
    public Rigidbody rc;
    public float forwardForce = 2000f;
    public float sidewaysForce = 2000f;
    // Start is called before the first frame update
    //void Start()
    //{
    //  rc.AddForce(0, 200, 500);
    //}

    //We marked this as "Fixed"Update because we are using it to mess with physics.
    // Update is called once per frame
    void FixedUpdate()
    {
        //Add a forward force
        rc.AddForce(0, 0, forwardForce * Time.deltaTime); //Add a force of 2000 on the z - axis

        if (Input.GetKey("d"))
        {
            //Add a force to the right
            rc.AddForce(sidewaysForce * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
        }

        if (Input.GetKey("a")) 
        {
            //Add a force to the left
            rc.AddForce(-sidewaysForce * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
        }

        if (rc.position.y < -1f)
        {
            FindObjectOfType<GameManager>().EndGame();
        }
    }
}
