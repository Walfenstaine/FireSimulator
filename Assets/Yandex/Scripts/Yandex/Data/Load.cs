using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using pEventBus;
using UnityEngine;
using UnityEngine.UI;

public class Load : MonoBehaviour, IEventReceiver<OnLoadIsComplete>
{
    public Data data;
    public Image progressImage;
    
    public void OnEvent(OnLoadIsComplete e)
    {
        //SceneManager.LoadScene(data.lvlNumber);
        StartCoroutine(LoadSceneAsync(data.lvlNumber));
    }

    IEnumerator LoadSceneAsync(int levelName)
    {
        AsyncOperation op = SceneManager.LoadSceneAsync(levelName);

        while (!op.isDone)
        {
            float progress = Mathf.Clamp01(op.progress / .9f);
            progressImage.fillAmount = progress;

            yield return null;
        }
    }

    void Start()
    {
        EventBus.Register(this);
        SaveAndLoad.Instance.Load();
    }

    private void OnDestroy()
    {
        EventBus.UnRegister(this);
    }
}
