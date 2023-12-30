using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameObject : MonoBehaviour
{
    void Start()
    {
       // 모든 오브젝트는 transform이라는 변수를 항상 가지고 있음.
       Vector3 vec = new Vector3(5,0,0);  // 3차원 벡터 할당

       transform.Translate(vec);  // 벡터 값을 현재 위치에 더하는 함수
    }

    void Update()
    {
        // Vector3 vec2 = new Vector3(0, 0.01f, 0);
        // transform.Translate(vec2);

        Vector3 vec3 = new Vector3(
            Input.GetAxis("Horizontal")*0.01f,
            Input.GetAxis("Vertical")*0.01f, 0);
        transform.Translate(vec3);
    }
}
