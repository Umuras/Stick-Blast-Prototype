using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Zenject;

public class GameInstaller : MonoInstaller
{
    [SerializeField]
    private GridManager gridManager;

    public override void InstallBindings()
    {
        SignalBusInstaller.Install(Container);

        //Signal Örneði
        Container.Bind<GridManager>().FromInstance(gridManager).AsSingle();

        //Game Classes


        //UI, StickSpawner, vs. buraya eklenecek
    }
}
