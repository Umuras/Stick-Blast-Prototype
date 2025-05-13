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
    [SerializeField]
    private List<GameObject> stickPrefabs;
    [SerializeField] 
    private Transform[] spawnPoints;
    

    //Çubugun her kýsmýný spawn et
    public void SpawnRandomStick()
    {
        if (stickPrefabs == null || stickPrefabs.Count == 0)
        {
            Debug.LogWarning("Stick prefab listesi boþ.");
            return;
        }

        //for (int i = 0; i < spawnPoints.Length; i++)
        //{
        //    GameObject selectedPrefab = stickPrefabs[Random.Range(0, stickPrefabs.Count)];
        //    Vector3 localPosition = new Vector3(spawnPoints[i].transform.position.x, spawnPoints[i].transform.position.y, 0); // y eksenini ters çeviriyoruz
        //    Instantiate(selectedPrefab, localPosition, Quaternion.identity, gridParent);
        //}

        for (int i = 0; i < spawnPoints.Length; i++)
        {
            int randomIndex = Random.Range(0, stickPrefabs.Count);
            GameObject stick = Instantiate(stickPrefabs[randomIndex], spawnPoints[i]);
            //stick.transform.localPosition = Vector3.zero; // hizalama
            //stick.transform.localScale = Vector3.one; // küçültülmüþ görünüm
        }

    }
}
