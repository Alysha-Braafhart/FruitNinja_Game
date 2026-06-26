using System;
using UnityEngine;
using UnityEngine.SocialPlatforms.Impl;

public class ScoreManager : MonoBehaviour
{
    public static event Action<int> OnScoreChange;
    public static ScoreManager Instance;
    public int score = 0;

    private void Awake()
    {
        if (Instance != null && Instance != this)
        {
            Destroy(gameObject);
            return;
        }
        Instance = this;
    }

    public void AddScore(int amount)
    {
        score += amount;
        OnScoreChange?.Invoke(score);
    }

    void Start()
    {
    }

    void Update()
    {
    }
}
