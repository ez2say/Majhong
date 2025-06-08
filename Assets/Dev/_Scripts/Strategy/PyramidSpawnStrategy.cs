using UnityEngine;

public class PyramidSpawnStrategy : ISpawnStrategy
{
    public void Spawn(Transform parent, IBrickFactory factory, int totalBricks)
    {
        int maxBaseBricks = CalculateMaxBaseBricks(totalBricks);

        for (int level = 0; level < maxBaseBricks; level++)
        {
            int bricksInLevel = level + 1;
            float z = -(maxBaseBricks - 1 - level) * 2f;

            for (int i = 0; i < bricksInLevel; i++)
            {
                IBrick brick = factory.CreateBrick();
                brick.GetTransform().SetParent(parent);
                brick.GetTransform().localPosition = CalculatePosition(level, i, bricksInLevel, z);
            }
        }
    }

    private int CalculateMaxBaseBricks(int totalBricks)
    {
        return Mathf.FloorToInt(Mathf.Sqrt(2 * totalBricks));
    }

    private Vector3 CalculatePosition(int level, int index, int count, float z)
    {
        float width = 1.5f;
        float offsetXPerBrick = width / 2f;
        float rowStartX = -((count - 1) * offsetXPerBrick);
        float x = rowStartX + index * width;
        return new Vector3(x, 0, z);
    }
}