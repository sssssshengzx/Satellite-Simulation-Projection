using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class RobotMove : MonoBehaviour
{
    private NavMeshAgent agent;
    private Transform target;
    // Start is called before the first frame update
    void Start()
    {
        agent = GetComponent<NavMeshAgent>();
        target = GameObject.Find("target").transform;
    }

    // Update is called once per frame
    void Update()
    {
        //如果鼠标进行点击
        /*if (Input.GetMouseButtonDown(0))
        {
            //获取射线
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            RaycastHit hit;
            //判断射线检测是否成功
            if (Physics.Raycast(ray, out hit))
            {
                Vector3 point = hit.point;
                agent.SetDestination(point);
            }
        }*/
        agent.SetDestination(target.position);
    }
}
