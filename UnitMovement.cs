using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UnitMovement : MonoBehaviour
{

    GameObject unit;
    public float threshold = 0.3f;

    public void HandleUnitMovement(Vector3 endPosition)
    {
        if (unit == null || unit.CompareTag("Character") == false)
            return;
        endPosition.z = 0f;
        if (Vector2.Distance(endPosition, unit.transform.position) > threshold)
        {
            Vector2 direction = (endPosition - unit.transform.position);
            if (Mathf.Abs(direction.x) > Mathf.Abs(direction.y))
            {
                float sign = Mathf.Sign(direction.x);
                direction = Vector2.right * sign;
            }
            else
            {
                float sign = Mathf.Sign(direction.y);
                direction = Vector2.up * sign;
            }
            unit.transform.position += (Vector3)direction;
        }
        unit = null;
    }

    public void HandleUnitSelection(GameObject collider)
    {

        if (collider != null)
        {
            unit = collider;
        }
        else
        {
            unit = null;
        }
    }
}

