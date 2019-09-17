using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class ChangeScene : MonoBehaviour
{
    public Image blackImage;
    public string nextScene;
    float alpha;
    
    void Awake()
    {

    }

    void Update()
    {
        alpha = blackImage.color.a;
        Debug.Log(alpha);

        if (alpha == 1f)
        {
            SceneManager.LoadScene(nextScene);
        }
    }
}
