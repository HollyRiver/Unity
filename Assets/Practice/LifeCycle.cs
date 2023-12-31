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

        // Mouse Control, 0 : Left, 1 : Right
        if (Input.GetMouseButtonDown(0)) {
            Debug.Log("미사일 발사!");
        }

        if (Input.GetMouseButton(0)) {
            Debug.Log("미사일 모으는 중...");
        }

        if (Input.GetMouseButtonUp(0)) {
            Debug.Log("슈퍼 미사일 발사!");
        }

        // Edit > Project Settings > Input Manager 내 항목
        if (Input.GetButtonDown("Jump")) // space key
        {
            Debug.Log("점프!");
        }

        if (Input.GetButton("Jump")) {
            Debug.Log("점프 모으는 중...");
        }

        if (Input.GetButtonUp("Jump")) {
            Debug.Log("슈퍼 점프!");
        }
        // Input.GetButton("버튼 이름")으로 true, false를 받아올 수 있다.

        if (Input.GetButton("Horizontal")) {
            if (Input.GetAxis("Horizontal") > 0)  // 가속도를 반영한 값 산출
            {
                Debug.Log("오른쪽 이동 중...");
            }
            else {
                Debug.Log("왼쪽 이동 중...");
            }
        }

        if (Input.GetButton("Horizontal")) {
            Debug.Log(Input.GetAxisRaw("Horizontal")); // 가속도를 부여하지 않은 값 산출
        }

        if (Input.GetButton("Vertical")) {
            Debug.Log(Input.GetAxis("Vertical"));  // 마찬가지로 가속도 반영
        }
    }
}
