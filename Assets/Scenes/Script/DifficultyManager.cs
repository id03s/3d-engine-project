//��ư �������� �ȳ�����
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
