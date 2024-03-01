using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using Lolopupka;
public class SliderControl : MonoBehaviour
{
    public Slider fricitionSlider;  // ����Ħ�����Ļ�����
    public Slider adhesionSlider;  // ����ճ�����Ļ�����
    public GameObject robot;  // ������
    private float stepDistance = 2f;
    private float stepHeight = 2f;
    void Start()
    {
        // ��Ӽ����¼�
        fricitionSlider.onValueChanged.AddListener(delegate { FrictionChangeCheck(); });
        adhesionSlider.onValueChanged.AddListener(delegate { AdhesionChangeCheck(); });
    }

    // ����������ֵ�ı�ʱ����
    public void FrictionChangeCheck()
    {
        // ����ROBOT�Ĳ���
        if (robot.GetComponent<proceduralAnimation>()) {
            robot.GetComponent<proceduralAnimation>().StepDistance = stepDistance-fricitionSlider.value;
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
}
