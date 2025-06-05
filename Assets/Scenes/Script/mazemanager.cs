//난이도 매니저 안내하는 스크립트
//초창기 개발을 할때 scene을 난이도 별로 나눴어야했는데 방향을 잘못잡았습니다

using Unity.VisualScripting;
using UnityEngine;

public class Mazemanager : MonoBehaviour
{
    public GameObject easymaze;
    public GameObject normalmaze;
    public GameObject hardmaze;

    void Start()
    {
        easymaze.SetActive(false);
        normalmaze.SetActive(false);
        hardmaze.SetActive(false);

        //난이도에 따라 하나만 켜기
        if (DifficultyManager.selectedDifficulty == "Easy")
            easymaze.SetActive(true);
        else if (DifficultyManager.selectedDifficulty == "Normal")
            normalmaze.SetActive(true);
        else if (DifficultyManager.selectedDifficulty == "Hard")
            hardmaze.SetActive(true);
    }

  
}
