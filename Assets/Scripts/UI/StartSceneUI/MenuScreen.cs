using UnityEngine;
using UnityEngine.UI;

public class MenuScreen : MonoBehaviour
{
    #region Variables

    [SerializeField] private Button _playButton;
    [SerializeField] private string _sceneName;
    

    #endregion


    #region Unity lifecycle

    private void Awake()
    {
        _playButton.onClick.AddListener(PlayButtonClicked);
    }

    #endregion


    #region Private methods

    private void PlayButtonClicked()
    {
        SceneLoader.Instance.LoadScene(_sceneName);
    }

    #endregion
}