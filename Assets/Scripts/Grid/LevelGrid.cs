using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelGrid : MonoBehaviour
{
    [SerializeField] private Transform gridDebugObjectPrefab;

    private GridSystem gridSystem;

    private void Awake()
    {
        gridSystem = new GridSystem(10, 10, 2f);
        gridSystem.CreateDebugObjects(gridDebugObjectPrefab);
    }

    public void SetUnitAtGridPosition(GridPosition gridPosition, Unit unit)
    {

    }

    //public Unit GetUnitAtGridPosition(GridPosition gridPosition)
    //{

    //}

    public void ClearUnitAtGridPosition()
    {

    }
}
