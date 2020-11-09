using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Tilemaps;

public class BuildTower : MonoBehaviour
{
    public Tilemap towerBase;
    public Tile getTile;
    public Tile Tower;
    public GameObject tower;
    public int count;

    Vector3Int position;
    Vector3Int[] positions;

    int x, y;
    bool exist;
    // Start is called before the first frame update
    void Start()
    {
        count = 0;
        exist = false;
        positions = new Vector3Int[99];
    }

    // Update is called once per frame
    void Update()
    {
        int x = transform.position.x > 0 ? (int)transform.position.x : (int)transform.position.x - 1;
        int y = transform.position.y > 0 ? (int)transform.position.y : (int)transform.position.y - 1;
        position = new Vector3Int(x, y, 0);

        if (towerBase.GetTile(position) == getTile)
        {
            exist = false;
            for(int i=0; i<count; i++)
            {
                if (positions[i] == position)
                {
                    exist = true;
                    break;
                }
                else
                    exist = false;
            }
            if (!exist)
            {
                if (Input.GetMouseButtonDown(0))
                {
                    GameObject Tower = Instantiate(tower, new Vector3(position.x + 0.5f, position.y + 0.5f, 0), Quaternion.identity);
                    positions[count] = position;
                    count++;
                    Tower.name = "BasicTower" + count.ToString();
                }
            }
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Base"))
        {
            Debug.Log("This is a Base");
        }
    }
}
