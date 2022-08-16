using UnityEngine;

public class Catcher : MonoBehaviour
{
    #region Unity lifecycle

    private void OnCollisionEnter2D(Collision2D col)
    {
        Destroy(col.gameObject);
    }

    #endregion
}
