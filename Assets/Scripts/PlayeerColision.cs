
using UnityEngine;

public class PlayeerColision : MonoBehaviour
{
    public PlayerMovement movement; //A reference to our PlayerMovement script


    
    //This function runs when we hit another abject.
    //We get information about the collision and call it "collisionInfo".
    void OnCollisionEnter(Collision collisionInfo)
    {
        //We check if the object we collided with has a tag called "obstacle".
        if (collisionInfo.collider.tag == "Obstacle")
        {
            movement.enabled = false;
            FindObjectOfType<GameManager>().EndGame();
        }
    }
}
