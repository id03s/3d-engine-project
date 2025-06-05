using UnityEngine;

public class Wallmanager : MonoBehaviour
{
    public GameObject easyWalls;
    public GameObject normalWalls;
    public GameObject hardWalls;

    public void SetDifficulty(string level)
    {
        easyWalls.SetActive(level == "Easy");
        normalWalls.SetActive(level == "Normal");
        hardWalls.SetActive(level == "Hard");
    }
}
