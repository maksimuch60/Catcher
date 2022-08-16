using UnityEngine;

public class ItemSpawner : MonoBehaviour
{
    #region Variables

    [SerializeField] private ItemBase[] _itemPrefabArray;
    [SerializeField] private float _startTime;
    [SerializeField] private float _repeatingRate;

    private float _totalChanceValue;

    #endregion


    #region Unity lifecycle

    private void Start()
    {
        InvokeRepeating(nameof(SpawnItem), _startTime, _repeatingRate);

        foreach (ItemBase item in _itemPrefabArray)
        {
            _totalChanceValue += item.SpawnChance;
        }
    }

    #endregion


    #region Private methods

    private void SpawnItem()
    {
        float randomChance = Random.Range(0f, _totalChanceValue);
        float currentChance = 0;
        Vector3 randomPosition = new(Random.Range(-5f, 5f), 10f, 0);

        foreach (ItemBase item in _itemPrefabArray)
        {
            currentChance += item.SpawnChance;
            if (currentChance >= randomChance)
            {
                Instantiate(item, randomPosition, Quaternion.identity);
                break;
            }
        }
    }

    #endregion
}