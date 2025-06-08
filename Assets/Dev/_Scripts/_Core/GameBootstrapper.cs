using UnityEngine;

public class GameBootstrapper : MonoBehaviour
{
    [SerializeField] private GameObject _brickPrefab;
    [SerializeField] private Transform _spawnParent;
    [SerializeField] private int _brickCount = 9;

    private void Start()
    {
        ISpawnStrategy strategy = new PyramidSpawnStrategy();
        BrickSpawner spawner = new BrickSpawner(_brickPrefab, strategy, _spawnParent, _brickCount);
        spawner.Spawn();
    }
}