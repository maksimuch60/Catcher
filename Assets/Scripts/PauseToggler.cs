using UnityEngine;

public class PauseToggler : MonoBehaviour
{
    #region Properties

    public bool IsPaused { get; private set; }

    #endregion


    #region Unity lifecycle

    private void Start()
    {
        GameManager.Instance.OnPaused += TogglePause;
    }

    private void OnDestroy()
    {
        GameManager.Instance.OnPaused -= TogglePause;
    }

    #endregion


    #region Public methods

    public void TogglePause()
    {
        IsPaused = !IsPaused;
        Time.timeScale = IsPaused ? 0 : 1;
    }

    #endregion
}