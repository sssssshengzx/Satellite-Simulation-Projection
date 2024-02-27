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
        //向左
        if (Input.GetKey(KeyCode.A))
        {
            transform.Translate(Vector3.left * speed * Time.deltaTime);
        }
        //向右
        if (Input.GetKey(KeyCode.D))
        {
            transform.Translate(Vector3.right * speed * Time.deltaTime);
        }
        //向前
        if (Input.GetKey(KeyCode.W))
        {
            transform.Translate(Vector3.forward * speed * Time.deltaTime);
        }
        //向后
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

        // 根据鼠标移动的X轴和Y轴来旋转人物
        transform.Rotate(Vector3.up * mouseX * rotationSpeed);

        // 旋转人物的仰角（上下旋转）
        transform.Rotate(Vector3.left * mouseY * rotationSpeed);
    }
}
