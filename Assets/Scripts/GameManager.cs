using System;
using UnityEngine;

public class GameManager : SingletonMonoBehaviour<GameManager>
{
    #region Variables

    [SerializeField] private int _originalLives;
    
    private int _score;
    private int _lives;

    #endregion


    #region Events

    public event Action<int> OnScoreChanged;
    public event Action<int> OnLivesChanged;
    
    public event Action OnGameOver;
    public event Action OnPaused;

    #endregion


    #region Properties

    public int Score => _score;
    public int Lives => _lives;

    #endregion


    #region Unity lifecycle

    protected override void Awake()
    {
        base.Awake();

        _lives = _originalLives;
    }

    #endregion


    #region Public methods

    public void AddScore(int points)
    {
        _score += points;
        OnScoreChanged?.Invoke(_score);
    }

    public void ChangeLives(int live)
    {
        _lives += live;
        OnLivesChanged?.Invoke(_lives);

        CheckGameOver();
    }

    public void ResetGame()
    {
        _score = 0;
        _lives = _originalLives;
        OnPaused?.Invoke();
    }

    #endregion


    #region Private methods

    private void CheckGameOver()
    {
        if (_lives == 0)
        {
            OnGameOver?.Invoke();
            OnPaused?.Invoke();
        }
    }

    #endregion
}