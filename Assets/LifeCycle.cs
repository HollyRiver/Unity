using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// 키 입력
public class LifeCycle : MonoBehaviour
{
    void Update()
    {
        if (Input.anyKeyDown)  // 아무 입력을 최초로 받을 때 호출, True 반환
            Debug.Log("플레이어가 아무 키를 눌렀습니다.");

        // if (Input.anyKey)  // 아무 키를 누르고 있을 때 True 반환
        //     Debug.Log("플레이어가 아무 키를 누르고 있습니다.");

        // Enter : Return, Escape : ESC
        if (Input.GetKeyDown(KeyCode.Return))  // KeyCode의 메소드를 매개변수로, Return이 Enter입니다. Enter는 없음
            Debug.Log("아이템을 구입하였습니다.");
        
        if (Input.GetKey(KeyCode.LeftArrow))  // 누르고 있을 때 작동
            Debug.Log("왼쪽으로 이동 중");

        if (Input.GetKeyUp(KeyCode.RightArrow))  // Up, 떼었을 때 작동
            Debug.Log("오른쪽 이동을 멈추었습니다.");
    }
}
