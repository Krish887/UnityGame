
using UnityEngine;

public class playerCollision : MonoBehaviour
{
    public playerMovement movement;
    void OnCollisionEnter (Collision collisionInfo) 
    {
        if (collisionInfo.collider.name == "Obstacle"){
            movement.enabled = false;
        }

    }

}
