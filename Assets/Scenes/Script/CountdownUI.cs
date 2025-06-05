using UnityEngine;
using TMPro;

public class CountdownUI : MonoBehaviour
{
    public TMP_Text countdownText;
    private int countdown;

    void OnEnable()
    {
        countdown = 5; //5초 카운트 다운
        countdownText.gameObject.SetActive(true);
        StartCoroutine(StartCountdown());
    }

    System.Collections.IEnumerator StartCountdown()
    {
        while (countdown > 0)
        {
            countdownText.text = countdown.ToString(); //카운트 다운 값 표시
            yield return new WaitForSeconds(1f); //1초대기
            countdown--; //카운트다운 숫자 감소
        }

        countdownText.text = "START!"; //start 하면 움직임
        yield return new WaitForSeconds(1f);
        countdownText.text = "";

        // 여기에 게임 시작 트리거 추가
        if (GameManager.Instance != null)
        {
            GameManager.Instance.StartGame(); // 실제 게임 시작
        }
    }
}
