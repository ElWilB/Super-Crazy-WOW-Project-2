using UnityEngine;
using UnityEngine.SceneManagement;

public class CatchPlayer : MonoBehaviour
{
    public int timeToCatch = 0;
    public bool withinSight = false;
    private int catchRate = 1;
    public string spawnLevel;
    public string playerTag = "Player";


    void OnTriggerEnter(Collider other)
    {
        withinSight = true;

    }


        void OnTriggerExit(Collider other)
    {
            withinSight = false;
    }

    void Update()
    {
        if (withinSight == true)
            if (timeToCatch == 600)
            {
                SceneManager.LoadScene(spawnLevel);
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
}
