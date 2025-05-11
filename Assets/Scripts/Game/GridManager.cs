using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GridManager : MonoBehaviour
{
    [SerializeField]
    private int rows = 10;
    [SerializeField]
    private int columns = 10;
    [SerializeField]
    private GameObject cellPrefab;
    [SerializeField]
    private Transform gridParent;

    private Cell[,] grid;

    public void InitializeGrid()
    {
        grid = new Cell[rows, columns];

        for (int y = 0; y < rows; y++)//row
        {
            for(int x = 0; x < columns; x++)//column
            {
                GameObject cellObj = Instantiate(cellPrefab, gridParent);
                //x → Yatayda (soldan sağa) hareket ederiz. 
                //y → Dikeyde (yukarıdan aşağıya) hareket ederiz.
                //Ancak biz grid’i yukarıdan aşağıya kurmayı amaçladığımız için y değerini negatif yapıyoruz
                //(-y). Bu şekilde, grid’in üst kısmı pozitif y değerlerine sahip olur.
                cellObj.transform.localPosition = new Vector3(x, -y, 0);

                Cell cell = cellObj.GetComponent<Cell>();
                //Celli yerleştiriyoruz, 0,0 0,1 0,2 0,10 şeklinde
                grid[y, x] = cell;
                //x columnu yani matristeki x eksenindeki konumu belirtiyor, bu kordinat sisteminde x e denk geliyor, y içinde tam tersi
                //o yüzden bu şekilde grid dizisine göre ters yazıyoruz.
                cell.Init(x,y);
            }
        }
    }

    public Cell GetCell(int x, int y)
    {
        if(x >= 0 && y >= 0 && x < columns && y < rows)
        {
            return grid[y, x];
        }
        return null;
    }
}
