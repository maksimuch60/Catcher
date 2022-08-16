using System;
using TMPro;
using UnityEngine;

public class GameScreen : MonoBehaviour
{
    #region Variables

    [SerializeField] private TextMeshProUGUI _scoreLabel;
    [SerializeField] private TextMeshProUGUI _livesLabel;
    [SerializeField] private GameObject _gameOverScreen;
    

    #endregion


    #region Unity lifecycle

    private void Start()
    {
        GameManager.Instance.OnScoreChanged += SetScoreText;
        GameManager.Instance.OnLivesChanged += SetLivesText;
        GameManager.Instance.OnGameOver += ChangeScreen;

        SetScoreText(GameManager.Instance.Score);
        SetLivesText(GameManager.Instance.Lives);
    }

    private void OnDestroy()
    {
        GameManager.Instance.OnScoreChanged -= SetScoreText;
        GameManager.Instance.OnLivesChanged -= SetLivesText;
        GameManager.Instance.OnGameOver -= ChangeScreen;
    }

    #endregion


    #region Private methods

    private void ChangeScreen()
    {
        _gameOverScreen.SetActive(true);
        gameObject.SetActive(false);
    }

    private void SetLivesText(int lives)
    {
        _livesLabel.text = "Lives: " + lives;
    }

    private void SetScoreText(int score)
    {
        _scoreLabel.text = "Score: " + score;
    }

    #endregion
}