using System.Collections;
using System.Runtime.CompilerServices;
using TMPro;
using Unity.VisualScripting;
using UnityEngine;

public class CollectGoldRework : MonoBehaviour
{

    [SerializeField] private TextMeshProUGUI CollectText;
    [SerializeField] private TextMeshProUGUI UIText;


    public int value = 1;
    public string playerTag = "Player";
    public bool nearToCollect = false;
    public int pickupTime = 3;
    public bool isFakeOrSecret = false;
    public bool isNormal = true;
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag(playerTag))
        {
            nearToCollect = true;
            UIText.enabled = true;
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.CompareTag(playerTag))
        {
            nearToCollect = false;
            UIText.enabled = false;
        }
    }

    public void Update()
    {
        if (isNormal && nearToCollect && Input.GetKeyDown(KeyCode.E))
        {
            StartCoroutine(CollectGold());
        }
        else if (isFakeOrSecret && nearToCollect && Input.GetKeyDown(KeyCode.E))
        {
            StartCoroutine(CollectFake());
        }
    }


    IEnumerator CollectGold()
    {
        CollectText.enabled = true;
        GameManager.instance.playerCanMove = false;
        yield return new WaitForSeconds(pickupTime);
        GameManager.instance.goldAmount += value;
        UIManager.instance.scoreText.text = GameManager.instance.goldAmount.ToString();
        CollectText.enabled = false;
        GameManager.instance.playerCanMove = true;
        print("Collected [1] gold!");
        Destroy(this.gameObject);
        UIText.enabled = false;


    }

    IEnumerator CollectFake()
    {
        CollectText.enabled = true;
        GameManager.instance.playerCanMove = false;
        yield return new WaitForSeconds(pickupTime);
        GameManager.instance.goldAmount += value;
        UIManager.instance.scoreText.text = GameManager.instance.goldAmount.ToString();
        CollectText.enabled = false;
        GameManager.instance.playerCanMove = true;
        Destroy(this.gameObject);
        UIText.enabled = false;
    }
}
