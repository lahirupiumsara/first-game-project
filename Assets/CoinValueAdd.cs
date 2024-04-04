 
using UnityEngine;

public class CoinValueAdd : MonoBehaviour
{
    public GameObject scoreText;

    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            scoreText.GetComponent<playerScore>().coinValue = scoreText.GetComponent<playerScore>().coinValue + 100;
            Destroy(gameObject);
        }
    
    
    }

}
