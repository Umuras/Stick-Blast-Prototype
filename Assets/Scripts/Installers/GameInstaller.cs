using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Zenject;

public class GameInstaller : MonoInstaller
{
    [SerializeField]
    private GridManager gridManager;
    [SerializeField]
    private StickSpawner stickSpawner;
    [SerializeField]
    private GameManager gameManager;

   

    public override void InstallBindings()
    {
        SignalBusInstaller.Install(Container);

        //Signal Örneði
        Container.Bind<GridManager>().FromInstance(gridManager).AsSingle();
        Container.Bind<StickSpawner>().FromInstance(stickSpawner).AsSingle();
        Container.Bind<GameManager>().FromInstance(gameManager).AsSingle();
        //Game Classes


        //UI, StickSpawner, vs. buraya eklenecek
    }
}
