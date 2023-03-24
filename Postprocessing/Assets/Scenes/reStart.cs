using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class reStart : MonoBehaviour
{
    public void StartGame (int SceneID)
    {
        SceneManager.LoadScene(SceneID);
    }
    // Start is called before the first frame update
}
