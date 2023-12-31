using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    // Update is called once per frame
    Vector3 target = new Vector3(8, 1.5f, 0);  // 목표지점, 타겟값

    void Update()
    {
        // 실시간으로 위치값이 바뀐다면 다시 해당 지역으로 이동하고자 함.
        // // 1. MoveTowards (등속 직선 이동)
        transform.position = 
            Vector3.MoveTowards(transform.position, target, 0.05f * Time.deltaTime*100); // 시작점과 목표 위치, 속도를 입력해줌. 최대치 1이 아님
            // 음수값을 넣으면 반대 방향으로 계속 이동하는듯...
        
        // 2. SmoothDamp (가속도 반영 이동)
        // Vector3 velo = Vector3.zero;  // 이미 할당이 되어 있는 벡터, new가 필요 없음

        // transform.position =
        //     Vector3.SmoothDamp(transform.position, target, ref velo, 0.1f * Time.deltaTime); // ref : 참조, 포인터 대신 쓰는 것, 영벡터 넣어주면 됨.
                // 마지막 매개변수는 이동 시간이라고 보면 됨. 1f가 제일 느림

        // 3. Lerp (선형 보간 이동), SmoothDamp보다 감속시간이 긺.
        // transform.position = 
        //     Vector3.Lerp(transform.position, target, 1f * Time.deltaTime); // 0~1f값, 1이 제일 빠름

        // // 4. Slerp (구면 선형 보간)
        // transform.position = 
        //     Vector3.Slerp(transform.position, target, 0.05f * Time.deltaTime); // 0~1f값, 1이 제일 빠름
    }
}
