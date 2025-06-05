//���̵� �Ŵ��� �ȳ��ϴ� ��ũ��Ʈ
//��â�� ������ �Ҷ� scene�� ���̵� ���� ��������ߴµ� ������ �߸���ҽ��ϴ�

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

        //���̵��� ���� �ϳ��� �ѱ�
        if (DifficultyManager.selectedDifficulty == "Easy")
            easymaze.SetActive(true);
        else if (DifficultyManager.selectedDifficulty == "Normal")
            normalmaze.SetActive(true);
        else if (DifficultyManager.selectedDifficulty == "Hard")
            hardmaze.SetActive(true);
    }

  
}
