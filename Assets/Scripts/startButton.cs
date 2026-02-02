using UnityEngine;
using UnityEngine.SceneManagement;
public class startButton : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    
    public void OnStartButtonClick()
    {
        SceneManager.LoadScene("MainScene");
        Debug.Log("메인씬 실행");
    }
}
