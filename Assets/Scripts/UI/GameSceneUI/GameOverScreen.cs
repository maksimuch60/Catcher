using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class GameOverScreen : MonoBehaviour
{
    #region Variables

    [SerializeField] private Button _againButton;
    [SerializeField] private Button _exitButton;
    [SerializeField] private TextMeshProUGUI _resultLabel;

    #endregion


    #region Unity lifecycle

    private void Awake()
    {
        _againButton.onClick.AddListener(AgainButtonClicked);
        _exitButton.onClick.AddListener(ExitButtonClicked);
        SetResultText();
    }

    #endregion


    #region Private methods

    private void SetResultText()
    {
        _resultLabel.text = "Score: " + GameManager.Instance.Score;
    }

    private void ExitButtonClicked()
    {
        ExitHelper.Exit();
    }

    private void AgainButtonClicked()
    {
        GameManager.Instance.ResetGame();
        SceneLoader.Instance.ReloadScene();
    }

    #endregion
}