using UnityEngine;
using UnityEngine.SceneManagement;

public class GoToScene : MonoBehaviour
{
   public void LoadScenePrimary(int index)
    {
        SceneManager.LoadScene(index);
        GameManager.instance.currentLives = 1;
    }
}
