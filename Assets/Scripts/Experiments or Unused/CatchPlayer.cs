using System.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;
using static UnityEngine.Rendering.DebugUI;

public class CatchPlayer : MonoBehaviour
{
    public int timeToCatch = 0;
    public bool withinSight = false;
    private int catchRate = 1;
    public string playerTag = "Player";
    public bool isCaught = true;

    public static CatchPlayer instance;


    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag(playerTag))
        {
            withinSight = true;
 
        }
    }

        void OnTriggerExit(Collider other)
    {
        withinSight = false;
    }

    void Update()
    {
        if (withinSight == true)
            if (timeToCatch == 400)
            {


            }
            else
            {
                timeToCatch += 1;
            }
        if (withinSight == false)
        {
            timeToCatch = 0;
        }
    }

    IEnumerator Start()
    {
        yield return new WaitForSeconds(1);
        SceneManager.LoadScene(3);
    }
}
