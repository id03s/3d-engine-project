//버튼 누르도록 안내해줌
using UnityEngine;
using UnityEngine.SceneManagement;
public class DifficultyManager : MonoBehaviour
{
    public static string selectedDifficulty = "Easy";

    public void SetEasy()
    {
        selectedDifficulty = "Easy";
        SceneManager.LoadScene("GameScene");
    }

    public void SetNormal()
    {
        selectedDifficulty = "Normal";
        SceneManager.LoadScene("GameScene");
    }

    public void SetHard()
    {
        selectedDifficulty = "Hard";
        SceneManager.LoadScene("GameScene");
    }
}
