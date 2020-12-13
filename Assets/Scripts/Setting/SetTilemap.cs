using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Tilemaps;
public class SetTilemap : MonoBehaviour
{
    
    public Tilemap Base;
    public Tile baseTile;

    void Start()
    {
        //Set a base tile according to count;
        for(int i=-15; i<=8; i++)
        {
            for(int j=-5; j<=8; j++)
            {
                Base.SetTile(new Vector3Int(i,j,0), baseTile);
            }
        }
    }

}
