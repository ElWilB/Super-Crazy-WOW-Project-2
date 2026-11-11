using System.Runtime.CompilerServices;
using UnityEngine;

public class CollectGold : MonoBehaviour
{
    public int value;
    public string playerTag = "Player";
    private void OnTriggerEnter(Collider other)
    {
      if (other.CompareTag(playerTag))
        {
            GameManager.instance.goldAmount += value;
            UIManager.instance.scoreText.text = GameManager.instance.goldAmount.ToString();
            Destroy(this.gameObject);
        }

        if (GameManager.instance.goldAmount < 0)
            GameManager.instance.goldAmount = 0;
    }
}
