using System;
using UnityEngine;

public class ScoreManager : MonoBehaviour
{
    public static ScoreManager Instance;

    public event Action<int> EventCurrentScoreChanged;

    public int CurrentScore { get; private set; }

    public void ModifyScore(int score)
    {
        CurrentScore += score;
        EventCurrentScoreChanged?.Invoke(CurrentScore);
    }

    private void Awake()
    {
        Instance = this;
    }
}
