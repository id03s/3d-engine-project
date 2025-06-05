//����Ű�� �˷��ִ� �Ŵ���
using TMPro; // �� �־�� ��!
using UnityEngine;
using UnityEngine.SceneManagement;

public class ShortcutManager : MonoBehaviour
{
    public TextMeshProUGUI shortcutHintText;

    void Start()
    {
        if (shortcutHintText != null)
        {
            shortcutHintText.text = "R: Restart\nM: Main Menu";
        } //R�� ������ ����� , M�� ������ ���θ޴�
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.R))
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex); // �ٽý���
        }
        else if (Input.GetKeyDown(KeyCode.M))
        {
            SceneManager.LoadScene("StartScene"); // ��ŸƮ ������ �̵�

        }
    }
}
