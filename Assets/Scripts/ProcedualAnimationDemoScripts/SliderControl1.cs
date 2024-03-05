using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using Lolopupka;
public class SliderControl1 : MonoBehaviour
{
    public Slider fricitionSlider;  // ����Ħ�����Ļ�����
    public Slider adhesionSlider;  // ����ճ�����Ļ�����
    public Slider speedSlider;  // ����ճ�����Ļ�����
    public GameObject robot;  // ������
    private float stepDistance = 2f;
    private float stepHeight = 2f;
    private float robotSpeed = 4f;

    void Start()
    {
        // ��Ӽ����¼�
        fricitionSlider.onValueChanged.AddListener(delegate { FrictionChangeCheck(); });
        adhesionSlider.onValueChanged.AddListener(delegate { AdhesionChangeCheck(); });
        speedSlider.onValueChanged.AddListener(delegate { SpeedChangeCheck(); });
    }

    // ����������ֵ�ı�ʱ����
    public void FrictionChangeCheck()
    {
        // ����ROBOT�Ĳ���
        if (robot.GetComponent<proceduralAnimation>())
        {
            robot.GetComponent<proceduralAnimation>().StepDistance = stepDistance - fricitionSlider.value;
        }

    }
    public void AdhesionChangeCheck()
    {
        // ����ROBOT�Ĳ���
        if (robot.GetComponent<proceduralAnimation>())
        {
            robot.GetComponent<proceduralAnimation>().StepHeight = stepHeight - adhesionSlider.value;
        }

    }
    public void SpeedChangeCheck()
    {
        // ����ROBOT���ٶ�
        if (robot.GetComponentInParent<WalkDemonstrateTest>())
        {
            robot.GetComponentInParent<WalkDemonstrateTest>().speed = robotSpeed + speedSlider.value * 2;
        }

    }
}
