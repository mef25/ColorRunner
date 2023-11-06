
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class kilitsistemi : MonoBehaviour
{
    public List<Button> leveller;
    void Start()
    {
        if (!PlayerPrefs.HasKey("level"))
            PlayerPrefs.SetInt("level", 1);
        if (!PlayerPrefs.HasKey("seviyeSayýsý"))
            PlayerPrefs.SetInt("seviyeSayýsý", leveller.Count);
        kilitleriAc();
    }

   public void kilitleriAc()
    {
        for(int i = 0; i < PlayerPrefs.GetInt("level"); i++)
        {
            leveller[i].interactable = true;
        }
    }
    public string levelAdi(int id)
    {
        string scenePath=SceneUtility.GetScenePathByBuildIndex(id);
        string sceneName=System.IO.Path.GetFileNameWithoutExtension(scenePath);
        return sceneName;
    }
    public void levelAc(int id)
    {
        PlayerPrefs.SetString("suankisecilenlevel",levelAdi(id));
        SceneManager.LoadScene(levelAdi(id));
    }
}
