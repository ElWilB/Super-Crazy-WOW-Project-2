using UnityEngine;

public class GameManager : MonoBehaviour
{
    // This is stuff to make the GameManager work. Don't touch it!
    public static GameManager instance;

    // You can add your own variables below here.
    public int currentLives = 3;
    public int maxLives = 5;
    public int goldAmount = 0;
    public bool playerCanMove = true;
    public bool enemyPoint = false;
    public int finalGoldAmount = 0;
    public bool jumpEnabled = true;


    // This is also stuff to make the GameManager work. Don't touch it!
    private void Awake()
    {
        if(instance != null)
        {
            Destroy(this.gameObject);
            return;
        }
        instance = this;
        DontDestroyOnLoad(this.gameObject);
    }
}
