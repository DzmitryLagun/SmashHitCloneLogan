using UnityEngine;
using UnityEngine.UI;

public class GameplayPanel : MonoBehaviour
{
        [SerializeField]
        private Text _scoreLabel = null;

        private void OnEnable()
        {
            ScoreManager.Instance.EventCurrentScoreChanged += OnCurrentScoreChanged;
            _scoreLabel.text = ScoreManager.Instance.CurrentScore.ToString();
        }

        private void OnDisable()
        {
            ScoreManager.Instance.EventCurrentScoreChanged -= OnCurrentScoreChanged;
        }

        private void Update()
        {
            if (Input.GetKeyDown(KeyCode.Escape))
            {
                UserInterfaceManager.Instance.EnablePanel(UIPanelType.PausePanel);
            }
        }

        private void OnCurrentScoreChanged(int currentScore)
        {
            _scoreLabel.text = currentScore.ToString();
        }
    
}
