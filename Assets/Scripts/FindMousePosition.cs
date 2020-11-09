using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FindMousePosition : MonoBehaviour
{
    Vector2 mousePosition;
    Camera Camera;
    void Start()
    {
        Camera = GameObject.Find("Main Camera").GetComponent<Camera>();
    }

    // Update is called once per frame
    void Update()
    {
        mousePosition = Input.mousePosition;
        mousePosition = Camera.ScreenToWorldPoint(mousePosition);

        transform.position = mousePosition;
    }
}
