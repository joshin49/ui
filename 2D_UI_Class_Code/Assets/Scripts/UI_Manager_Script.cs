using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class UI_Manager_Script : MonoBehaviour
{
    

    [SerializeField] private InputField Name_Input;

    [SerializeField] private InputField Password_Input;

    [SerializeField] private Slider Slider_Value;

    //[SerializeField] private InputField input_name;

    public Slider my_slider;


    public static bool bFlip;
    

    // Start is called before the first frame update
    void Start()
    {
        bFlip = true;
    }

    // Update is called once per frame
    

    

   

    public void Myslider()
    {
        Debug.Log("slider Value: " + my_slider.value);
    }
    


    void MyButton_in_UIManager()
    {
        Debug.Log("button 1 pressed by UI Manager");
    }

    
    

    
}
