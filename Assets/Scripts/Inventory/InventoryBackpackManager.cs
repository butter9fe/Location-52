using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class InventoryBackpackManager : Common.DesignPatterns.Singleton<InventoryBackpackManager>
{
    [Header("Config")]
    [SerializeField] Vector2Int gridSize = new();
    [SerializeField] Dictionary<InventoryItemType, GameObject> backpackItemPrefabs;
/*    [SerializeField] List<BackpackItem> spawnedBackpackItems; // for shelf*/
    // then, list of prefabs here associated with each type

    // TODO: Object pooling!!!
    [Header("Objects")]
    [SerializeField] GameObject gridItemPrefab;
    [SerializeField] GridLayoutGroup inventoryGroup;

    List<GameObject> storedItems = new(); // To hide/unhide the stored items

    Dictionary<Vector2Int, InventoryGridItem> grids = new();
    [HideInInspector] public InventoryGridItem CurrGrid = null;
    [HideInInspector] public bool bShouldDisableItemButtons = false;

    // Stores all the important info!!!
    [HideInInspector] public Dictionary<Vector2Int, BackpackItemInfo> BackpackItems = new();

    #region TEMP
    // NOTE: ALL THINGS RELATING TO CONTROLS IS TEMP UNTIL I MOVE THIS TO MAIN MENU
    Controls _controls = null;

    protected override void Awake()
    {
        base.Awake();
        _controls = new Controls();
        AssignControls();
    }

    private void AssignControls()
    {
        if (!_controls.MainGameplay.enabled)
        {
            _controls.MainGameplay.Enable();
        }

        //_controls.MainGameplay.TEMPOpenInventory.performed += ctx => OpenInventory();
    }
    #endregion

    // i REALLY need to ObjectPool this
    public void InstantiateGrid(GridLayoutGroup group = null)
    {
        GridLayoutGroup invGroup = group ?? inventoryGroup;
        invGroup.constraintCount = gridSize.x;
        for (int y = 0; y < gridSize.y; ++y)
        {
            for (int x = 0; x < gridSize.x; ++x)
            {
                GameObject item = Instantiate(gridItemPrefab, invGroup.transform);
                var gridItem = item.GetComponent<InventoryGridItem>();
                gridItem.OnHover.AddListener(() => OnPointerEnterGrid(gridItem));
                gridItem.OnUnhover.AddListener(() => OnPointerExitGrid(gridItem));
                var position = new Vector2Int(x, y);
                gridItem.Position = position;
                grids.Add(position, gridItem);
            }
        }

        // TODO: Instantiate items
    }

    public void ClearGrid()
    {
        foreach (var grid in grids)
        {
            Destroy(grid.Value.gameObject);
        }
        grids.Clear();
        CurrGrid = null;
        //spawnedBackpackItems
    }

    public bool GetIsValidSpot(BackpackItemInfo info)
    {
        if (CurrGrid == null)
            return false;

        if (CurrGrid.Position.x + info.GridSize.x > gridSize.x ||
            CurrGrid.Position.y + info.GridSize.y > gridSize.y)
            return false;

        for (int y = CurrGrid.Position.y; y < CurrGrid.Position.y + info.GridSize.y; ++y)
        {
            for (int x = CurrGrid.Position.x; x < CurrGrid.Position.x + info.GridSize.x; ++x)
            {
                if (grids[new Vector2Int(x, y)].State != GridState.Empty)
                    return false;
            }
        }

        return true;
    }

    public void OnPlacedItem(BackpackItemInfo info)
    {
        List<InventoryGridItem> linkedGrids = new();
        var topLeftGrid = grids[info.GridPosition];

        for (int y = info.GridPosition.y; y < info.GridPosition.y + info.GridSize.y; ++y)
        {
            for (int x = info.GridPosition.x; x < info.GridPosition.x + info.GridSize.x; ++x)
            {
                var grid = grids[new Vector2Int(x, y)];
                if (grid != topLeftGrid)
                {
                    grid.State = GridState.LinkedOccupied;
                    grid.ItemInfo = info;
                    grid.LinkedGrids.Add(grids[info.GridPosition]);

                    linkedGrids.Add(grid);
                }
            }
        }

        topLeftGrid.State = GridState.Occupied;
        topLeftGrid.ItemInfo = info;
        topLeftGrid.LinkedGrids = linkedGrids;
        BackpackItems.Add(info.GridPosition, info);
    }

    public void OnRemoveItem(Vector2Int position)
    {
        var topleftGrid = grids[position];
        // just make this grid + linked grids empty
        foreach (var grid in topleftGrid.LinkedGrids)
        {
            grid.ResetGridInfo();
        }
        topleftGrid.ResetGridInfo();
        BackpackItems.Remove(position);
    }

    public void OnPointerEnterGrid(InventoryGridItem grid)
    {
        CurrGrid = grid;
    }

    public void OnPointerExitGrid(InventoryGridItem grid)
    {
        if (CurrGrid == grid)
            CurrGrid = null;
    }
}
