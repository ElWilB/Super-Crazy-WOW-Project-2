using System.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;
using static UnityEngine.Rendering.DebugUI;

public class CatchPlayer : MonoBehaviour
{
    public int timeToCatch = 0;
    public int withinSight = 0;
    private int catchRate = 1;
    public string playerTag = "Player";
    public int LoseScene;

    public static CatchPlayer instance;


    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag(playerTag))
        {
            withinSight = 1;
 
        }
    }

        void OnTriggerExit(Collider other)
    {
        withinSight = 0;
    }

    void Update()
    {
        if (withinSight == 1)
            if (timeToCatch == 400)
            {
                StartCoroutine(EndGame());
            }
            else
            {
                timeToCatch += 1;
            }
        if (withinSight == 0)
        {
            timeToCatch = 0;
        }
    }

    IEnumerator EndGame()
    {
        yield return new WaitForSeconds(0);
        SceneFader.Instance.LoadScene("3");
    }
}
