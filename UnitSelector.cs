using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class UnitSelector : MonoBehaviour
{
    public LayerMask agentMask;

    public UnityEvent<GameObject> HandleMouseClick;
    public UnityEvent<Vector3> HandleMouseFinishDragging;

    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Vector3 mouseInput = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            mouseInput.z = 0f;
            Collider2D colider = Physics2D.OverlapPoint(mouseInput, agentMask);
            GameObject selectedGameObject = colider == null ? null : colider.gameObject;
            HandleMouseClick?.Invoke(selectedGameObject);
        }
        if (Input.GetMouseButtonUp(0))
        {
            Vector3 mouseInput = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            HandleMouseFinishDragging?.Invoke(mouseInput);
        }
    }
}
