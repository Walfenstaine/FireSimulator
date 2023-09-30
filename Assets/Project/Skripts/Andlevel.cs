using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class Andlevel : MonoBehaviour
{
    public Data data;
    public string nextLvl;
    public void NextLevel()
    {
        if (data.lvlNumber >= 5)
        {
            data.lvlNumber = 1;
        }
        else {
            data.lvlNumber += 1;
        }
       
        SaveAndLoad.Instance.Save();
        SceneManager.LoadScene(nextLvl);
    }
    public void Reload()
    {
        SaveAndLoad.Instance.Save();
        Scene scene = SceneManager.GetActiveScene();
        SceneManager.LoadScene(scene.name);
    }
}
