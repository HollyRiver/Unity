using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Actor {
    // 접근자, private가 디폴트
    public int id;
    public string name;
    public string title;
    public string weapon;
    public float strength;
    public int level;

    public string Talk()  // 파라메터가 없이 리턴값만 있는 함수
    {
        return "대화를 걸었습니다.";
    }

    public string HasWeapon()
    {
        return weapon;
    }

    public void LevelUp()  // 동작 함수
    {
        level++;
    }
}
