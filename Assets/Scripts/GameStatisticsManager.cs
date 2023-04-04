using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameStatisticsManager : DDOLSingletonMonoBehaviour<GameStatisticsManager>
{
    [SerializeField] private GameStatisticsCollector _collector;
    public GameStatisticsCollector Collector => _collector;

    protected override void Awake()
    {
        base.Awake();
        _collector.Init();
    }
}

