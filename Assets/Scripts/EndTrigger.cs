using UnityEngine;

public class EndTrigger : MonoBehaviour
{
    public GameManager gameManager;
    
    void OnTriggerEnter(Collider colliderInfo) // Need to use the word "Trigger" not "Collision"
    {
        if (colliderInfo.name == "Player") 
        {
            gameManager.CompleteLevel();
        }
    }
}
