using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UserSetting : MonoBehaviour
{
    public bool[] Tower;
    public bool[] stageClear;
    // Start is called before the first frame update
    void Awake()
    {
        DontDestroyOnLoad(gameObject);
    }

    void Start()
    {
        Tower = new bool[10];
        stageClear = new bool[3];
        Tower[0] = true;
        stageClear[0] = true;
    }

    void Update()
    {
        
    }
}
