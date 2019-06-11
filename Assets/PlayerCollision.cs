using UnityEngine;

public class PlayerCollision : MonoBehaviour
{
    
public playermovement movement;

    // Update is called once per frame
    void OnCollisionEnter(Collision collisionInfo)
    {
       if (collisionInfo.collider.tag == "obstacle")
       {
           Debug.Log("we hit something");
       }
    }
}
