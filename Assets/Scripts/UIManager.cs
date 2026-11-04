using TMPro;
using Unity.VisualScripting;
using UnityEngine;

public class UIManager : MonoBehaviour
{
    public static UIManager instance;

    public TextMeshProUGUI scoreText;
    public TextMeshProUGUI liveText;
    public TextMeshProUGUI resultText;


    private void Awake()
    {
        instance = this;
    }

    private void Start()
    {
        UIManager.instance.liveText.text = GameManager.instance.currentLives.ToString();
        UIManager.instance.scoreText.text = GameManager.instance.goldAmount.ToString();


        if (GameManager.instance.goldAmount == 10)
            UIManager.instance.resultText.text = "      loser";
        else if (GameManager.instance.goldAmount <= 9)
            UIManager.instance.resultText.text = "winner alert";
    }
}
