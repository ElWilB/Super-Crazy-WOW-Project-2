using UnityEngine;
using UnityEngine.ProBuilder;

public class StoryIncrementButton : MonoBehaviour
{

    public void Update()
    {
        if (Input.GetKeyDown(KeyCode.Mouse0))
        {
            GameManager.instance.goldAmount += 1;
        }
    }
}
