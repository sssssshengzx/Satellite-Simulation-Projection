using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using Lolopupka;
public class SliderControl : MonoBehaviour
{
    public Slider fricitionSlider;  // 控制摩擦力的滑动条
    public Slider adhesionSlider;  // 控制粘附力的滑动条
    public GameObject robot;  // 机器人
    private float stepDistance = 2f;
    private float stepHeight = 2f;
    void Start()
    {
        // 添加监听事件
        fricitionSlider.onValueChanged.AddListener(delegate { FrictionChangeCheck(); });
        adhesionSlider.onValueChanged.AddListener(delegate { AdhesionChangeCheck(); });
    }

    // 当滑动条的值改变时调用
    public void FrictionChangeCheck()
    {
        // 更新ROBOT的步距
        if (robot.GetComponent<proceduralAnimation>()) {
            robot.GetComponent<proceduralAnimation>().StepDistance = stepDistance-fricitionSlider.value;
        }
        
    }
    public void AdhesionChangeCheck()
    {
        // 更新ROBOT的步高
        if (robot.GetComponent<proceduralAnimation>())
        {
            robot.GetComponent<proceduralAnimation>().StepHeight = stepHeight - adhesionSlider.value;
        }

    }
}
