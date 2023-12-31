using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectFlow : MonoBehaviour  // MonoBehaviour라는 곳에서 끌어옴
{
    // 1. 초기화 영역
    void Awake()  // 가장 먼저 실행되는 함수
    {
        Debug.Log("플레이어 데이터가 준비되었습니다.");  // 최초 한 번만 실행
    }

    void OnEnable() // 오브젝트 활성화 함수
    {
        Debug.Log("플레이어가 로그인하였습니다.");
    }

    void Start()
    {
        Debug.Log("사냥 장비를 챙겼습니다.");  // 업데이트 시작 직전(프레임 들어가기 전) 한 번 실행
    }

    // 2. 물리 연산 영역
    void FixedUpdate()  // 업데이트 함수, 초당 50회 정도 실행, CPU를 많이 사용, 오직 물리 연산 로직만 넣을 것
    {
        Debug.Log("이동중");
    }

    // 3. 주기적으로 변하는 게임 환경 변환 함수
    void Update()   // 프레임 당 실행, 환경에 따라 실행 주기가 변할 수 있음.
    {
        Debug.Log("몬스터 사냥!!");
    }

    // 4. 업데이트 이후 최종 반영 로직, 카메라 무빙 또는 로직 후처리 진행
    void LateUpdate()
    {
        Debug.Log("경험치 획득!");
    }

    void OnDisable()  // 오브젝트 비활성화 함수, 해체시키지 않고도 위 함수들을 비활성화 가능
    {
        Debug.Log("플레이어가 로그아웃했습니다.");
    }

    // 5. 해체, 프레임에서 벗어나는 것.
    void OnDestroy() // 게임 오브젝트가 삭제 또는 비활성화 될 때 발생
    {
        Debug.Log("플레이어 데이터를 해체했습니다.");
    }
}
