using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Button_Script : MonoBehaviour
{

    public static bool bCheck_Parameter = true;

    public static int bHardware = 0;


    [SerializeField] private InputField Name_Input;

    [SerializeField] private InputField Password_Input;

    [SerializeField] private Slider Slider_Value;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void My_Button()
    {
        Debug.Log("Hi I am a button");
    }

    public void MyCheckButton()
    {
        if (bCheck_Parameter == true)
        {
            bCheck_Parameter = false;

        }else if (bCheck_Parameter == false)
        {
            bCheck_Parameter = true;
        }

        Debug.Log("My check button:" + bCheck_Parameter);
    }

    public void MyRadioButton1()
    {
        bHardware = 1;
        Debug.Log("오픈지엘을 선택했습니다:" + bHardware);
    }
    public void MyRadioButton2()
    {
        bHardware = 2;
        Debug.Log("다이렉트를 선택했습니다:" + bHardware);
    }

    public void MyInputField_Name()
    {
        Debug.Log("이름을 입력했습니다.");
        if(Name_Input.text == "Kang")
        {
            Debug.Log("존재하는 ID 입니다");
        }
    }
    public void MyInputField_Password()
    {
        Debug.Log("암호를 입력했습니다.");
        if (Password_Input.text == "1111")
        {
            Debug.Log("암호가 일치합니다.");
        }
    }

    public void MySlider()
    {
        Debug.Log("슬라이더값:" + Slider_Value.value);
    }
}
