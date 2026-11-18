using UnityEngine.UI;
using UnityEngine;

public class DismissImage : MonoBehaviour
{

    [SerializeField] private Image displayImage;
    public void Update()
    {
        if (Input.GetKeyDown(KeyCode.Mouse0))
        {
            displayImage.enabled = false;
        }
    }
}
