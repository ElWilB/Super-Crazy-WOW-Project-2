using UnityEngine;

public class CollectGold : MonoBehaviour
{
    public int value;
    private void OnTriggerEnter(Collider other)
    {
      if  (other.CompareTag("Player"))
        GameManager.instance.goldAmount += value;
        UIManager.instance.scoreText.text = GameManager.instance.goldAmount.ToString();
        Destroy(this.gameObject);
    }
}