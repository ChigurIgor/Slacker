using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;
public class LoadLevel : MonoBehaviour, IPointerDownHandler
{
    public string nextScene;
    float maxLevels = 10;

    // Start is called before the first frame update
    void Start()
    {
        if (nextScene == null || nextScene == "") {
            nextScene = "Scene-" + loadOpenedLevels();
        }
     }

    // Update is called once per frame
    void Update()
    {
        
    }



    public void OnPointerDown(PointerEventData eventdata)
    {
        LoadNextLevel();
    }

    void LoadNextLevel()
    {
        Application.LoadLevel(nextScene);
    }

    public float loadOpenedLevels()
    { 
        float result = PlayerPrefs.GetFloat("openedLevels");
        if (result >= maxLevels) {
            result = maxLevels - 1;
        }
        return result;
    }
}
