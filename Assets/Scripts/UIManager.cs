using TMPro;
using UnityEngine;

public class UIManager : MonoBehaviour
{
    public static UIManager instance;

    public TextMeshProUGUI scoreText;
    public TextMeshProUGUI liveText;

    private void Awake()
    {
        instance = this;
    }

    private void Start()
    {
        UIManager.instance.liveText.text = GameManager.instance.currentLives.ToString();
    }
}
