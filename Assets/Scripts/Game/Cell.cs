using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cell : MonoBehaviour
{
    public int X {  get; private set; }
    public int Y { get; private set; }

    private bool _isPainted = false;

    public void Init(int x, int y)
    {
        X = x;
        Y = y;
    }

    public void Paint()
    {
        if (_isPainted) return;

        _isPainted = true;
        GetComponent<SpriteRenderer>().color = Color.yellow; 
    }

    public bool IsPainted() => _isPainted;
}
