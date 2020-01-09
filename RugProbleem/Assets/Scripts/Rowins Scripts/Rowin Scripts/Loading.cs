using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using TMPro;

public class Loading : MonoBehaviour
{
    public GameObject loadingScreen;
    public Slider progressSlider;
    public TextMeshProUGUI loadText;
    public void LevelLoader(int sceneIndex)
    {
        StartCoroutine(LoadLevel(sceneIndex));
    }
    IEnumerator LoadLevel(int sceneIndex)
    {
        AsyncOperation operation = SceneManager.LoadSceneAsync(sceneIndex);

        loadingScreen.SetActive(true);

        while (!operation.isDone) 
        {
            float progress = Mathf.Clamp01(operation.progress / .9f);
            progressSlider.value = progress;

            loadText.text = "Loading: " + progress * 100f +"%";

            yield return null;
        }
    }
}
