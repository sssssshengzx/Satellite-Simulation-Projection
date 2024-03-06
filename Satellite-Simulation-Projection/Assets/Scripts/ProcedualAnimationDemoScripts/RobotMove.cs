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
        //��������е��
        /*if (Input.GetMouseButtonDown(0))
        {
            //��ȡ����
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            RaycastHit hit;
            //�ж����߼���Ƿ�ɹ�
            if (Physics.Raycast(ray, out hit))
            {
                Vector3 point = hit.point;
                agent.SetDestination(point);
            }
        }*/
        agent.SetDestination(target.position);
    }
}
