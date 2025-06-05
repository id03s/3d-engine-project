/*using UnityEngine;

public class GoalTrigger : MonoBehaviour
{
    public GameObject clearText; // (선택) UI 텍스트

    private void OnTriggerEnter2D(Collider2D other)
    {
        Debug.Log("무언가 들어왔다: " + other.name + ", 태그: " + other.tag);

        if (other.CompareTag("Player"))
        {
            Debug.Log("플레이어가 골인지점에 도달!");

            // 여기! 골인 상태 저장
            PlayerMovement.isCleared = true;

            if (clearText != null)
            {
                clearText.SetActive(true);
            }

            // 필요하면 여기에 Time.timeScale = 0f; 또는 씬 전환도 가능
        }
    }
}*/

using UnityEngine;

public class GoalTrigger : MonoBehaviour
{
    public GameObject clearText; // (선택) UI 텍스트

    private void OnTriggerEnter2D(Collider2D other)
    {
        Debug.Log("무언가 들어왔다: " + other.name + ", 태그: " + other.tag);

        if (other.CompareTag("Player"))
        {
            Debug.Log("플레이어가 골인지점에 도달!");

            // GameManager 쪽 클리어 처리 실행
            GameManager.Instance.GameClear();

            // ↓ 아래 코드들은 GameManager에서 처리하므로 제거 가능
            // PlayerMovement.isCleared = true;
            // if (clearText != null) clearText.SetActive(true);
            // Destroy(other.gameObject); // 또는 other.gameObject.SetActive(false);
        }
    }

}

