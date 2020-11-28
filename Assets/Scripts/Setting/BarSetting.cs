using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BarSetting : MonoBehaviour
{
    public float hp;
    public Vector2 movePosition;

    Transform TransForm;
    void Start()
    {
        TransForm = gameObject.GetComponent<Transform>();
    }
    void Update()
    {
        gameObject.transform.position = movePosition;
        TransForm.localScale = new Vector3(hp*40*(1/100), 1, 1);
    }
}
