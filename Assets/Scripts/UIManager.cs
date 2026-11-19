using TMPro;
using Unity.VisualScripting;
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

    private void Update()
    {
        UIManager.instance.scoreText.text = GameManager.instance.goldAmount.ToString();
    }
}
