using UnityEngine;
using TMPro;

public class UIScoreBoard : MonoBehaviour
{
    public TMP_Text scoreField;

private void Start()
    {
        ScoreManager.OnScoreChange += UpdateUI;         
    }
    private void OnDisable()
    {
        ScoreManager.OnScoreChange -= UpdateUI; 
    }
        private void UpdateUI(int score)
    {
        scoreField.text = "Score: "+score;
    }

    }
