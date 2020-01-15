using UnityEngine;
using UnityEngine.SceneManagement;

public class PausePanel : MonoBehaviour
{
    private void OnEnable()
    {
        Time.timeScale = 0.0f;
    }

    private void OnDisable()
    {
        Time.timeScale = 1.0f;
    }

    public void OnRestartButtonClick()
    {
        SceneManager.LoadScene(0);
    }

    public void OnResumeButtonClick()
    {
        UserInterfaceManager.Instance.EnablePanel(UIPanelType.GameplayPanel);
    }
}
