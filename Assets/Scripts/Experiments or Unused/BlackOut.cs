using System.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;

[RequireComponent(typeof(CanvasGroup))]
public class SceneFader : MonoBehaviour
{
    static SceneFader instance;
    public static SceneFader Instance
    {
        get
        {
            if (instance == null)
                instance = Instantiate(Resources.Load<SceneFader>("SceneFader"));
            return instance;
        }
    }

    [SerializeField] float fadeDuration = 0.4f;
    CanvasGroup group;
    bool busy;

    void Awake()
    {
        if (instance != null && instance != this) { Destroy(gameObject); return; }
        instance = this;
        DontDestroyOnLoad(gameObject);
        group = GetComponent<CanvasGroup>();
        group.alpha = 0f;
        group.blocksRaycasts = false;
    }

    public void LoadScene(string sceneName)
    {
        if (!busy) StartCoroutine(Transition(sceneName));
    }

    IEnumerator Fade(float target)
    {
        float start = group.alpha, t = 0f;
        while (t < fadeDuration)
        {
            t += Time.unscaledDeltaTime;
            group.alpha = Mathf.Lerp(start, target, t / fadeDuration);
            yield return null;
        }
        group.alpha = target;
    }

    IEnumerator Transition(string sceneName)
    {
        busy = true;
        group.blocksRaycasts = true;
        yield return Fade(1f);

        yield return SceneManager.LoadSceneAsync(sceneName);

        yield return null; // let the new scene render one frame
        yield return Fade(0f);
        group.blocksRaycasts = false;
        busy = false;
    }
}