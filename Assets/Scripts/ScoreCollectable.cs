using UnityEngine;

public class ScoreCollectable : MonoBehaviour
{
    public int value; // This is the value of this coin

    public string playerTag = "Player";

    private void OnTriggerEnter(Collider other)
    {
        // Check to see if the collision was with the player.
        if (other.CompareTag(playerTag))
        {
            // Add the value of this score to the Game Manager's "score"
            GameManager.instance.goldAmount += value;

            // This tells the new UI manager to set the visible text to be our GameManager score.
            UIManager.instance.scoreText.text = GameManager.instance.goldAmount.ToString();

            // Destroy this game objects

        }
    }
}
