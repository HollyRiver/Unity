using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OtherBalls : MonoBehaviour
{
    MeshRenderer mesh;  // MeshRenderer 개체 선언
    Material mat;  // MeshRenderer 내의 Material 개체(MyBall) 선언

    void Start()
    {
        mesh = GetComponent<MeshRenderer>();
        mat = mesh.material;
    }

    // 이벤트성 함수, 보통 On이 들어감
    // private void OnCollisionEnter(Collision other)  // Collision(충돌)시 호출되는 함수
    // {
    //     mat.color = new Color(1,0,0);  // 기본 색상 클래스, Color32 : 255 color 클래스
    // }

    private void OnCollisionEnter(Collision other)  // 충돌에 대한 모든 내용을 조정 가능
    {
        if (other.gameObject.name == "MyBall") {
            mat.color = new Color32(255, 0, 0, 255);
        }
    }

    private void OnCollisionStay(Collision other)  // 충돌 중일 때
    {
        
    }

    private void OnCollisionExit(Collision other)  // 충돌이 끝났을 때
    {
        if (other.gameObject.name == "MyBall") {
            mat.color = new Color32(0, 0, 0, 255);
        }
    }
}
