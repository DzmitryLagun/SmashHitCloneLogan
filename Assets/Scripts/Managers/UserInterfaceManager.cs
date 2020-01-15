using UnityEngine;


public enum UIPanelType
{
    Undefined = 0,

    GameplayPanel = 1,
    PausePanel = 2,
    GameOverPanel = 3
}



public class UserInterfaceManager : MonoBehaviour
{
    public static UserInterfaceManager Instance = null;

    [SerializeField]
    private GameplayPanel _gameplayPanel = null;
    [SerializeField]
    private PausePanel _pausePanel = null;
    [SerializeField]
    private GameOverPanel _gameOverPanel = null;

    public void EnablePanel(UIPanelType panelType)
    {
        _gameplayPanel.gameObject.SetActive(panelType == UIPanelType.GameplayPanel);
        _pausePanel.gameObject.SetActive(panelType == UIPanelType.PausePanel);
        _gameOverPanel.gameObject.SetActive(panelType == UIPanelType.GameOverPanel);
    }

    private void Awake()
    {
        Instance = this;
    }
}
