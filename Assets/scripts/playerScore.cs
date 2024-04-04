 
using UnityEngine;
using UnityEngine.UI;

public class playerScore : MonoBehaviour
{
    public Transform playerTransform;
    public Text scoreText;
    public float coinValue;
    

    // Update is called once per frame
    void Update()
    {
        scoreText.text = (playerTransform.position.z+coinValue).ToString("0");

    }
}
