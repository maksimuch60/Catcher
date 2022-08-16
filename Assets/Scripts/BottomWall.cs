using UnityEngine;

public class BottomWall : MonoBehaviour
{
    #region Unity lifecycle

    private void OnCollisionEnter2D(Collision2D col)
    {
        if (col.gameObject.CompareTag(Tags.GoodItem))
        {
            GameManager.Instance.ChangeLives(-1);
        }
        Destroy(col.gameObject);
    }

    #endregion
}
