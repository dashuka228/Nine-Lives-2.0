using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class backgroundScroller : MonoBehaviour
{
    private Vector3 futurePosition; //������ ������� 
    [SerializeField] private float moveUp = 0.2f; // ��������� ����� ����������� item
    [SerializeField] private float speed = 0.003f; //��������
    private int currentTarget; //������� ���� ��� ������������
    [SerializeField] private Vector3[] positions; //������ �������

    void Start()
    {
        futurePosition = transform.position;
        futurePosition.y = transform.position.y + moveUp;
        positions = new Vector3[2];
        positions[0] = transform.position;
        positions[1] = futurePosition;
    }

    void Update()
    {
        Moving();
    }

    private void Moving()
    {
        transform.position = Vector3.MoveTowards(transform.position, positions[currentTarget], speed);
        if (transform.position == positions[currentTarget])
        {
            if (currentTarget < positions.Length - 1)
                currentTarget++;

            else
                currentTarget = 0;
            //transform.localScale = new Vector2(-transform.localScale.x, transform.localScale.y);
        }
    }
}
