/*using UnityEngine;

public class GoalTrigger : MonoBehaviour
{
    public GameObject clearText; // (����) UI �ؽ�Ʈ

    private void OnTriggerEnter2D(Collider2D other)
    {
        Debug.Log("���� ���Դ�: " + other.name + ", �±�: " + other.tag);

        if (other.CompareTag("Player"))
        {
            Debug.Log("�÷��̾ ���������� ����!");

            // ����! ���� ���� ����
            PlayerMovement.isCleared = true;

            if (clearText != null)
            {
                clearText.SetActive(true);
            }

            // �ʿ��ϸ� ���⿡ Time.timeScale = 0f; �Ǵ� �� ��ȯ�� ����
        }
    }
}*/

using UnityEngine;

public class GoalTrigger : MonoBehaviour
{
    public GameObject clearText; // (����) UI �ؽ�Ʈ

    private void OnTriggerEnter2D(Collider2D other)
    {
        Debug.Log("���� ���Դ�: " + other.name + ", �±�: " + other.tag);

        if (other.CompareTag("Player"))
        {
            Debug.Log("�÷��̾ ���������� ����!");

            // GameManager �� Ŭ���� ó�� ����
            GameManager.Instance.GameClear();

            // �� �Ʒ� �ڵ���� GameManager���� ó���ϹǷ� ���� ����
            // PlayerMovement.isCleared = true;
            // if (clearText != null) clearText.SetActive(true);
            // Destroy(other.gameObject); // �Ǵ� other.gameObject.SetActive(false);
        }
    }

}

