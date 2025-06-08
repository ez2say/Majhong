using UnityEngine;

public interface ISpawnStrategy
{
    void Spawn(Transform parent, IBrickFactory factory, int count);
}