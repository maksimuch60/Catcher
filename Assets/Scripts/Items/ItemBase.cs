using UnityEngine;

public abstract class ItemBase : MonoBehaviour
{
    #region Variables

    [Header(nameof(ItemBase))]
    [SerializeField] private float _spawnChance;

    #endregion


    #region Properties

    public float SpawnChance => _spawnChance;

    #endregion


    #region Unity lifecycle

    private void OnCollisionEnter2D(Collision2D col)
    {
        if (!col.gameObject.CompareTag(Tags.Catcher))
        {
            return;
        }

        ApplyEffect();
    }

    #endregion


    #region Private methods

    protected abstract void ApplyEffect();

    #endregion
}