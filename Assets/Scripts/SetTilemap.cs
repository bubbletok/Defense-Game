using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Tilemaps;

static class Constatns
{
    public const int count = 4;
}
public class SetTilemap : MonoBehaviour
{
    
    public Tilemap Base;
    public Tilemap Aisle;
    public Tile baseTile;
    public Tile aisleTile;

    // Start is called before the first frame update
    void Start()
    {
        
        int count = Constatns.count;
        //Set a base tile according to count;
        for(int i=-count; i<=count; i++)
        {
            for(int j=-count; j<=count; j++)
            {
                Base.SetTile(new Vector3Int(j,i,0), baseTile);
            }
        }
    }

}
