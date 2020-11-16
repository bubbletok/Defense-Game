using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class StageStart : MonoBehaviour
{
    // Start is called before the first frame update
    public void OnClickStage()
    {
        SceneManager.LoadScene("Normal_Stage_1");
    }
}
