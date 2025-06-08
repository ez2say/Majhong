using UnityEngine;

public class BrickFactory : IBrickFactory
{
    private readonly GameObject _prefab;

    public BrickFactory(GameObject prefab)
    {
        _prefab = prefab;
    }

    public IBrick CreateBrick()
    {
        var go = Object.Instantiate(_prefab);
        if (go.TryGetComponent(out IBrick brick))
            return brick;

        throw new System.Exception("Prefab не реализует IBrick");
    }
}