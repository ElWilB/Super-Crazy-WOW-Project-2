using JetBrains.Annotations;
using Unity.VisualScripting;
using UnityEditor.Experimental.GraphView;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LoseLife : MonoBehaviour
{
    public int spawnLevel;
    public string Tag = "Player";
    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag(Tag))
        {
            GameManager.instance.currentLives -= 1;
            GameManager.instance.goldAmount = 0;
            UIManager.instance.liveText.text = GameManager.instance.currentLives.ToString();
            if (GameManager.instance.currentLives == 0)
            {
                SceneManager.LoadScene(spawnLevel);
            }
            else
            {
                SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
            }
        }
    }
}

// Set "Is Trigger" to true, ensure the player is Tagged and you should be set !