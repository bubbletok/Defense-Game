using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SelectTower : MonoBehaviour
{
    Image image;
    BuildTower buildTower;
    SpriteRenderer spriteRenderer;
    void Start()
    {
        buildTower = GameObject.Find("Mouse").GetComponent<BuildTower>();
        spriteRenderer = GameObject.Find("Mouse").GetComponent<SpriteRenderer>();
        image = gameObject.GetComponent<Image>();
    }

    public void None()
    {
        buildTower.towerSelected = false;
        spriteRenderer.sprite = null;
    }

    public void basicTower()
    {
        buildTower.buildNumber = 0;
        buildTower.towerSelected = true;
        spriteRenderer.sprite = image.sprite;
        
    }

    public void sharpTower()
    {
        buildTower.buildNumber = 1;
        buildTower.towerSelected = true;
        spriteRenderer.sprite = image.sprite;
    }
}
