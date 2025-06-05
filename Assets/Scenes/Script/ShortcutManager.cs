//방향키를 알려주는 매니저
using TMPro; // 꼭 있어야 함!
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
        } //R을 누르면 재시작 , M을 누르면 메인메뉴
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.R))
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex); // 다시시작
        }
        else if (Input.GetKeyDown(KeyCode.M))
        {
            SceneManager.LoadScene("StartScene"); // 스타트 씬으로 이동

        }
    }
}
