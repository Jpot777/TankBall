using UnityEngine;

public class Stage : MonoBehaviour
{
    private int _redGridCount = 0;
    private int _blueGridCount = 0;

    public void Init()
    {
        _redGridCount = 0;
        _blueGridCount = 0;

        Grid[] grid = this.transform.GetComponentsInChildren<Grid>();
        foreach (Grid g in grid)
        {
            if (g.GetComponent<SpriteRenderer>().sprite.name == "RedBlock")
            {
                _redGridCount += 1;
                g.Init(Define.eColorType.Red);
            }
            else if (g.GetComponent<SpriteRenderer>().sprite.name == "BlueBlock")
            {
                _blueGridCount += 1;
                g.Init(Define.eColorType.Blue);
            }
        }

        Block[] block = this.transform.GetComponentsInChildren<Block>();
        foreach (Block b in block)
        {
            b.Init();
        }

        Cannon[] cannon = this.transform.GetComponentsInChildren<Cannon>();
        foreach (Cannon c in cannon)
        {
            c.Init();
        }
    }
}
