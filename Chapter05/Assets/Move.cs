using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move : MonoBehaviour
{
    public Rigidbody myRigidbody;
    public float moveSpeed = 5f; // 이동 속도를 조절할 변수
    private Vector3 moveDirection = Vector3.right; // 이동 방향을 저장할 변수
    private Vector3 previousDirection; // 이전 이동 방향을 저장할 변수
    private bool changeDirection = false; // 방향 변경 플래그

    // Start is called before the first frame update
    void Start()
    {
        myRigidbody.velocity = moveDirection * moveSpeed; // 처음에 이동 방향으로 이동
        InvokeRepeating("ToggleDirection", 2f, 2f); // 2초마다 ToggleDirection 함수 호출
    }

    // Update is called once per frame
    void Update()
    {
        // 구가 점프하는 동작을 추가하려면 여기에 코드를 추가할 수 있습니다.
    }

    // 2초마다 호출되는 함수
    void ToggleDirection()
    {
        changeDirection = true; // 방향 변경 플래그 설정
    }

    // 물리 연산 업데이트
    void FixedUpdate()
    {
        if (changeDirection)
        {
            // 이전 방향을 저장
            previousDirection = moveDirection;

            // X와 Z 축 중 무작위로 선택하여 이동 방향 변경
            if (Random.Range(0, 2) == 0)
                moveDirection = Vector3.right;
            else
                moveDirection = Vector3.forward;

            // 새 방향이 이전 방향과 동일한 경우, 반대 방향으로 변경
            if (moveDirection == previousDirection)
                moveDirection *= -1;

            myRigidbody.velocity = moveDirection * moveSpeed; // 변경된 방향으로 이동
            changeDirection = false; // 플래그 초기화
        }
    }
}
