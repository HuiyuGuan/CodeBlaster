using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class MainMenu : MonoBehaviour
{
    public string Level1;
    [SerializeField] InputField playerNameInput;
    // [SerializeField] InputField playerNameInput;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void PlayGame(){
        string s = playerNameInput.text;
        PersistentData.Instance.SetName(s);
        SceneManager.LoadScene("Level1");
    }
    public void OpenOptions(){
        SceneManager.LoadScene("Options");
    }
    public void OpenInstructions(){
        SceneManager.LoadScene("Instructions");
    }
    public void OpenHighScores(){
        SceneManager.LoadScene("HighScores");
    }

}
