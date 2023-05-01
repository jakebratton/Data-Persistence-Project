using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

public class MenuUIHandler : MonoBehaviour
{
    public TextMeshProUGUI highscoreText;
    public TMP_InputField nameInput;

    // Start is called before the first frame update
    void Start()
    {
        DataManager.Instance.LoadHighscore();
        highscoreText.text = "Best score: " + DataManager.Instance.highscoreName + " : " + DataManager.Instance.highscore;
    }

    public void StartGame()
    {
        SceneManager.LoadScene(1, LoadSceneMode.Single);
    }

    public void SetName()
    {
        DataManager.Instance.currentName = nameInput.text;
    }
}
