using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveUI : MonoBehaviour
{
    public GameObject towerUI;
    bool clicked;
    void Start()
    {
        clicked = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButton(0))
        {
            clicked = true;
        }
        else
            clicked = false;
        if (clicked)
        {
            towerUI.transform.position = gameObject.transform.position;
        }
    }
}
