using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MyBall : MonoBehaviour
{
    Rigidbody rigid;  // 리지드바디 선언

    private bool Jump;
    private bool Foward;
    private Vector3 vec0 = Vector3.zero;

    void Start() // 초기화
    {
        rigid = GetComponent<Rigidbody>(); // 현재 Rigidbody를 불러온다.
        // rigid.velocity = new Vector3(0.5f, 2.8f, 0); // 게임 시작 시 right 방향으로 1회 가속도를 가함. y값이 높이에 해당
        // rigid.AddForce(Vector3.up * 3, ForceMode.Impulse); // Impulse를 가장 많이 사용한다. 질량에 따라 더 많은 힘이 필요
    }

    void FixedUpdate() // 물리 현상의 경우 FixedUpdate에 반영하는 것이 더 안정적
    {   
        if (Jump) {
            rigid.AddForce(Vector3.up * 5 * Time.fixedDeltaTime * 100, ForceMode.Impulse);
            Jump = false;  // 물리 적용은 FixedUpdate에서
            Debug.Log(rigid.velocity);  // 가속도 값을 받아옵니다.
        }

        // Vector3 vec = new Vector3(Input.GetAxisRaw("Horizontal"), 0, Input.GetAxisRaw("Vertical"));

        // rigid.AddForce(vec * Time.fixedDeltaTime, ForceMode.Impulse);  // 가속도를 부여하는 방식으로 움직임, 물리 반영

        // 회전력
        rigid.AddTorque(Vector3.back * 0.1f); // 입력한 벡터를 축으로 하여 회전한다.
    }

    void Update()
    {
        if (Input.GetButtonDown("Jump")) {            
            Debug.Log("Space 버튼을 눌렀습니다.");
            Jump = true;  // 입력은 Update에서
        }
    } 
}
