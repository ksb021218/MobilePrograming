using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move : MonoBehaviour
{
    public Rigidbody myRigidbody;
    public float moveSpeed = 5f; // �̵� �ӵ��� ������ ����
    private Vector3 moveDirection = Vector3.right; // �̵� ������ ������ ����
    private Vector3 previousDirection; // ���� �̵� ������ ������ ����
    private bool changeDirection = false; // ���� ���� �÷���

    // Start is called before the first frame update
    void Start()
    {
        myRigidbody.velocity = moveDirection * moveSpeed; // ó���� �̵� �������� �̵�
        InvokeRepeating("ToggleDirection", 2f, 2f); // 2�ʸ��� ToggleDirection �Լ� ȣ��
    }

    // Update is called once per frame
    void Update()
    {
        // ���� �����ϴ� ������ �߰��Ϸ��� ���⿡ �ڵ带 �߰��� �� �ֽ��ϴ�.
    }

    // 2�ʸ��� ȣ��Ǵ� �Լ�
    void ToggleDirection()
    {
        changeDirection = true; // ���� ���� �÷��� ����
    }

    // ���� ���� ������Ʈ
    void FixedUpdate()
    {
        if (changeDirection)
        {
            // ���� ������ ����
            previousDirection = moveDirection;

            // X�� Z �� �� �������� �����Ͽ� �̵� ���� ����
            if (Random.Range(0, 2) == 0)
                moveDirection = Vector3.right;
            else
                moveDirection = Vector3.forward;

            // �� ������ ���� ����� ������ ���, �ݴ� �������� ����
            if (moveDirection == previousDirection)
                moveDirection *= -1;

            myRigidbody.velocity = moveDirection * moveSpeed; // ����� �������� �̵�
            changeDirection = false; // �÷��� �ʱ�ȭ
        }
    }
}
