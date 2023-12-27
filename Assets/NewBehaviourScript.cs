using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// 클래스 뒤에 있는 MonoBehavior는 뭐임??
// 상속의 개념, 유니티 클래스의 함수 전부 사용 가능

public class NewBehaviourScript : MonoBehaviour
{
    int health = 30;  // 클래스 최상위에 변수를 선언하여 전역변수로 사용 가능
    int level = 5;
    float strength = 15.5f;
    string playerName = "나검사";
    bool isFullLevel = false;

    void Start()
    {
        //1. 변수


        //2. 그룹형 변수
        string[] monsters = { "슬라임", "사막뱀", "악마" };
        int[] monsterLevel = new int[3];
        monsterLevel[0] = 1;
        monsterLevel[1] = 9;
        monsterLevel[2] = 16;

        Debug.Log("맵에 존재하는 몬스터");
        Debug.Log(monsters[0] + ", " + monsters[1] + ", " + monsters[2]);
        Debug.Log("몬스터의 레벨");
        Debug.Log(monsterLevel[0] + ", " + monsterLevel[1] + ", " + monsterLevel[2]);        

        List<string> items = new List<string>();
        items.Add("생명물약30");
        items.Add("마나물약30");

        Debug.Log("현재 보유한 아이템");
        Debug.Log(items[0]);
        Debug.Log(items[1]); 

        items.RemoveAt(0);  //remove at index


        //3. 연산자
        int exp = 1500;

        exp = 1500 + 320;  // 덧셈
        exp = exp - 10;  // 뺄셈
        exp = exp / 300; // 나눗셈
        strength = level * 3.1f; // 곱셈

        Debug.Log("용사의 총 경험치는?");
        Debug.Log(exp);
        Debug.Log("용사의 레벨은?");
        Debug.Log(level);
        Debug.Log("용사의 힘은?");
        Debug.Log(strength);

        int nextExp = 300 - (exp % 300);  // 나머지
        Debug.Log("남은 경험치");
        Debug.Log(strength);

        string title = "전설의";
        Debug.Log("용사의 이름은?");
        Debug.Log(title + " " + playerName);

        int fullLevel = 99;
        isFullLevel = level == fullLevel;
        Debug.Log("용사는 만렙입니까? : " + isFullLevel);

        bool isEndTutorial = level > 10;
        Debug.Log("튜토리얼이 끝난 용사입니까? : " + isEndTutorial);

        int health = 30;
        int mana = 25;
        // bool isBadCondition = health <= 50 && mana <= 20;  // and
        bool isBadCondition = health <= 50 || mana <= 20;  // or

        string condition = isBadCondition ? "나쁨" : "좋음";
        Debug.Log("용사의 상태는? : " + condition);

        // 5. 조건문
        if (condition == "나쁨") {
            Debug.Log("플레이어 상태가 나쁘니 아이템을 사용해주세요.");
        }
        else {
            Debug.Log("플레이어 상태가 좋습니다.");
        }

        if (isBadCondition && items[0] == "생명물약30") {
            items.RemoveAt(0);
            health += 30;
            Debug.Log("생명물약30을 사용하였습니다.");
        }
        else if (isBadCondition && items[0] == "마나물약30") {
            items.RemoveAt(0);
            mana += 30;
            Debug.Log("마나물약30을 사용하였습니다.");
        }

        switch (monsters[0]) {
            case "슬라임" :
                Debug.Log("소형 몬스터가 출현!");
                break;
            case "악마" :
                Debug.Log("중형 몬스터가 출현!");
                break;
            case "골렘" :
                Debug.Log("대형 몬스터가 출현!");
                break;
            default :
                Debug.Log("??? 몬스터가 출현!");
                break;
        }

        // 6. 반복문
        while (health > 0) {
            health--;  // 1만큼 감소시킴
            
            if (health > 0)
                Debug.Log("독 데미지를 입었습니다.");
            else
                Debug.Log("사망하였습니다.");
            
            if (health <= 10) {
                Debug.Log("해독제를 사용합니다.");
                break;
            }
        }

        // for (변수 ; 조건 ; 연산) {}
        for (int count = 0 ; count < 10 ; count ++) {
            health ++;
            Debug.Log("휴식중... 현재 체력 : " + health);
        }

        // for (int index = 0 ; index < monsters.Length ; index ++) {
        //     Debug.Log("이 지역에 있는 몬스터 " + (index+1) + " : " + monsters[index]);
        // }

        // foreach (진행할 변수 in 리스트나 어레이) {}
        foreach (string monster in monsters) {
            Debug.Log("이 지역에 있는 몬스터 : " + monster);
        }

        Heal();  // 파라메터 없는 함수가 정상작동함

        for (int index = 0; index < monsters.Length; index ++) {
            Debug.Log("용사는 " + monsters[index] + "에게 " + Battle(monsterLevel[index]));
        }

        // 8. 클래스
        Actor player = new Player();  // player에 클래스 Player를 할당함, Player에는 Actor가 종속되어 있음. 변수 전부 사용 가능
        player.id = 0;
        player.name = "나법사";
        player.title = "현명한";
        player.strength = 2.4f;
        player.weapon = "나무 지팡이";
        Debug.Log(player.Talk());
        Debug.Log(player.HasWeapon());

        player.LevelUp();
        Debug.Log(player.name + "의 레벨은? : " + player.level);
    }

    // 7. 함수 (메소드). 받을 함수(파라메터)
    int Healing(int currentHealth)
    {
        currentHealth += 10;
        Debug.Log("힐을 받았습니다... 현재 생명력 : " + currentHealth);
        return currentHealth;  // 반환값, 리턴만 수행하고 변수를 바꾸지 않음
    }

    void Heal()  // 반환 데이터가 없는 함수타입
    {
        health += 10;  // 더해주는 작업만 수행, 리턴값 없이 작업
        Debug.Log("힐을 받았습니다... 현재 생명력 : " + health);
    }

    string Battle(int monsterLevel) // 파라메터에 대한 자료형 명시
    {
        string result;  // 할당만 해주고 입력은 안함
        if (level >= monsterLevel)
            result = "이겼습니다.";
        else
            result = "졌습니다.";
        
        return result;
    }
}
