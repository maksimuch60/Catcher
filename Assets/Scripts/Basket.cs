using System;
using UnityEngine;

public class Basket : MonoBehaviour
{
    #region Unity lifecycle

    private void Update()
    {
        if (Time.timeScale == 0)
        {
            return;
        }
        
        MoveWithMouse();
    }

    #endregion


    #region Private methods

    private void MoveWithMouse()
    {
        Vector3 mousePositionInPixels = Input.mousePosition;
        Vector3 mousePositionInUnits = Camera.main.ScreenToWorldPoint(mousePositionInPixels);

        Vector3 currentPosition = transform.position;
        currentPosition.x = mousePositionInUnits.x;
        transform.position = currentPosition;
    }

    #endregion
}