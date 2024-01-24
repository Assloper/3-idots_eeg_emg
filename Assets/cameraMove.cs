using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cameraMove : MonoBehaviour
{
    public Transform player; // ������ ���� ������Ʈ
    public float dist = 10.0f; // ī�޶���� ���� �Ÿ�
    public float height = 5.0f; // ī�޶� ���� ����
    public float dampTrace = 20.0f; // �ε巯�� ������ ���� ����


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = Vector3.Lerp(transform.position, player.position - (player.forward * dist) + (Vector3.up * height), Time.deltaTime * dampTrace);
        transform.LookAt(player);
    }
}
