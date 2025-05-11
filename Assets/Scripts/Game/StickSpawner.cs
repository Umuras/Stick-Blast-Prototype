using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StickSpawner : MonoBehaviour
{
    [Header("References")]
    [SerializeField]
    private Transform gridParent;
    [SerializeField]
    private GameObject stickPrefab;
    [SerializeField]
    private int stickLength = 3;

    //Çubugun mümkün olan þekilleri
    private readonly Vector2Int[] stickDirections =
    {
       new Vector2Int(1,0),//Yatay 
       new Vector2Int(0,1),//Dikey
    };

    //Çubugun her kýsmýný spawn et
    public void SpawnStick(int row, int col)
    {
        Vector2Int direction = stickDirections[Random.Range(0, stickDirections.Length)];

        for (int i = 0; i < stickLength; i++)
        {
            int x = col + direction.x * i;
            int y = row + direction.y * i;

            Vector3 localPosition = new Vector3(x, -y, 0); // Grid sistemine uygun (y ekseni ters)
            Instantiate(stickPrefab, localPosition, Quaternion.identity, gridParent);
        }
    }
}
