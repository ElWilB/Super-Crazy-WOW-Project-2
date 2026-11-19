using UnityEngine;
using UnityEngine.SceneManagement;

public class Win : MonoBehaviour
{
   
    public int Respawn;
    public int WinLoseLevel;
    public int neutralLevel;
    public int fullWinLevel;
    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            GameManager.instance.finalGoldAmount = GameManager.instance.goldAmount;
            GameManager.instance.goldAmount = 0;

            if (GameManager.instance.finalGoldAmount < 7)
                SceneManager.LoadScene(WinLoseLevel);
            else if (GameManager.instance.finalGoldAmount == 7)
                SceneManager.LoadScene(neutralLevel);
            else if (GameManager.instance.finalGoldAmount > 7)
                SceneManager.LoadScene(fullWinLevel);
        }
    }
}
