using UnityEngine;

class LiveAddItem : ItemBase
{
    #region Variables

    [Header(nameof(LiveAddItem))]
    [SerializeField] private int _lives;

    #endregion


    #region Private methods

    protected override void ApplyEffect()
    {
        GameManager.Instance.ChangeLives(_lives);
    }

    #endregion
}