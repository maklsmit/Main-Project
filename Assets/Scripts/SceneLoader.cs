using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;

public class SceneLoader : MonoBehaviour
{
    public static SceneLoader instance;
    [SerializeField] TextMeshProUGUI scoreText;
    // Start is called before the first frame update
    void Start()
    {
        instance = this;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void LoadNewScene(string scene){
        SceneManager.LoadScene(scene);
    }

    public void SetScoreText(int score){
        scoreText.text = "Score: " + score;
    }
}
