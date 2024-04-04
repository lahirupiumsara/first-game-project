using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerCollision : MonoBehaviour
{
    private void OnCollisionEnter(Collision collisionInfo)
    {
        if (collisionInfo.collider.tag == "obstacle")
        {
            FindObjectOfType<gameManager>().GameOver();
            FindObjectOfType<playerMovement>().enabled = false;
        }

    }

}
