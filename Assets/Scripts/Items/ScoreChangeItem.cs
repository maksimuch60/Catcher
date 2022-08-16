using UnityEngine;

public class ScoreChangeItem : ItemBase
{
    #region Variables

    [Header(nameof(ScoreChangeItem))]
    [SerializeField] private int _score;

    #endregion


    protected override void ApplyEffect()
    {
        GameManager.Instance.AddScore(_score);
    }
}