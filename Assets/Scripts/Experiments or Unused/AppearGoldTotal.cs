using UnityEngine;
using UnityEngine.UI;

public class AppearGoldTotal : MonoBehaviour
{
    [SerializeField] private Image goldImage;
    public int goldRequired;

    private void Update()
    {
        if (GameManager.instance.goldAmount >= goldRequired)
            goldImage.enabled = true;
        else
            goldImage.enabled = false;
    }
}