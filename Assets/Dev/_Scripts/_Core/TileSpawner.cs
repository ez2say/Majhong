using UnityEngine;

public class BrickSpawner
{
    private readonly GameObject _brickPrefab;
    private readonly ISpawnStrategy _spawnStrategy;
    private readonly Transform _spawnParent;
    private readonly int _brickCount;

    public BrickSpawner(
        GameObject brickPrefab,
        ISpawnStrategy spawnStrategy,
        Transform spawnParent,
        int brickCount)
    {
        _brickPrefab = brickPrefab;
        _spawnStrategy = spawnStrategy;
        _spawnParent = spawnParent;
        _brickCount = brickCount;
    }

    public void Spawn()
    {
        IBrickFactory factory = new BrickFactory(_brickPrefab);
        _spawnStrategy.Spawn(_spawnParent, factory, _brickCount);
    }
}