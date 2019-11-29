using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using UnityEngine.SceneManagement;

public class UIManager : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject loadingScreen;
    public GameObject settingsScreen;
    public Slider progressSlider;
    public TextMeshProUGUI loadText;
    void Start()
    {
      DontDestroyOnLoad(this);  
    }
    public void LoadLevel(int sceneIndex)
    {
        StartCoroutine(LevelLoader(sceneIndex));
    }
    IEnumerator LevelLoader(int sceneIndex)
    {
        AsyncOperation operation = SceneManager.LoadSceneAsync(sceneIndex);

        loadingScreen.SetActive(true);

        while (!operation.isDone) 
        {
            float progress = Mathf.Clamp01(operation.progress / .9f);
            progressSlider.value = progress;

            loadText.text = "Loading: " + progress * 100f +"%";

            if(operation.isDone)
            {
                loadingScreen.SetActive(false);
            }

            yield return null;
        }
    }
    public void Settings()
    {
        settingsScreen.SetActive(true);
    }
    public void SettingsBack()
    {
        settingsScreen.SetActive(false);
    }
    public void QuitGame()
    {
        Application.Quit();
    }

    public void BackGame(int backGame)
    {
        SceneManager.LoadScene(backGame);
    }
}
