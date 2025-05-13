using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Zenject;

public class GameManager : MonoBehaviour
{
    [Inject]
    private GridManager gridManager;

    [SerializeField]
    private StickSpawner stickSpawner;
    [SerializeField]
    private int spawnRow = 2;
    [SerializeField]
    private int spawnCol = 2;

    private void Start()
    {
        gridManager.InitializeGrid();
        stickSpawner.SpawnRandomStick();
    }
}
