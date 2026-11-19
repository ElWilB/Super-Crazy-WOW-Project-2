using UnityEngine;
using UnityEngine.UI;

public class AppearGoldTotalEnding : MonoBehaviour
{
    [SerializeField] private Image goldImage;
    public int goldRequired;

    private void Update()
    {
        if (GameManager.instance.finalGoldAmount >= goldRequired)
            goldImage.enabled = true;
        else
            goldImage.enabled = false;
    }
}