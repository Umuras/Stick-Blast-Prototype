using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cell : MonoBehaviour
{
    public int X {  get; private set; }
    public int Y { get; private set; }

    private bool _isPainted = false;
    private SpriteRenderer _spriteRenderer;

    private void Awake()
    {
        _spriteRenderer = GetComponent<SpriteRenderer>();
    }

    //Cellin kordinat düzlemdeki yerleri atanýyor
    public void Init(int x, int y)
    {
        X = x;
        Y = y;
    }

    //Sprite Rendererýn boyanýp boyanmadýðý kontrol ediliyor.
    public void Paint()
    {
        if (_isPainted) return;

        _isPainted = true;
        _spriteRenderer.color = Color.yellow; 
    }

    public bool IsPainted() => _isPainted;
}
