using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveOnPCController : MonoBehaviour
{
    public float speed = 0.5f;
    public float rotationSpeed = 2f;
    //protected Transform transform;
    // Start is called before the first frame update
    void Start()
    {
        //transform = this.transform;
    }

    // Update is called once per frame
    void Update()
    {
        //����
        if (Input.GetKey(KeyCode.A))
        {
            transform.Translate(Vector3.left * speed * Time.deltaTime);
        }
        //����
        if (Input.GetKey(KeyCode.D))
        {
            transform.Translate(Vector3.right * speed * Time.deltaTime);
        }
        //��ǰ
        if (Input.GetKey(KeyCode.W))
        {
            transform.Translate(Vector3.forward * speed * Time.deltaTime);
        }
        //���
        if (Input.GetKey(KeyCode.S))
        {
            transform.Translate(Vector3.back * speed * Time.deltaTime);
        }
        RotatePlayer();

    }
    void RotatePlayer()
    {
        float mouseX = Input.GetAxis("Mouse X");
        float mouseY = Input.GetAxis("Mouse Y");

        // ��������ƶ���X���Y������ת����
        transform.Rotate(Vector3.up * mouseX * rotationSpeed);

        // ��ת��������ǣ�������ת��
        transform.Rotate(Vector3.left * mouseY * rotationSpeed);
    }
}
