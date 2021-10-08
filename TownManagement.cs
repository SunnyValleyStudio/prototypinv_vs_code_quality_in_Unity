using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TownManagement : MonoBehaviour
{
    public GameObject townUi;
    public void HandleMouseClick(GameObject colldier)
    {
        townUi.SetActive(colldier != null && colldier.CompareTag("Town"));
    }
}
