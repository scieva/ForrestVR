using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class ButtonSelector : MonoBehaviour
{
    //Make sure to attach these Buttons in the Inspector
    public Button m_YourFirstButton, m_YourSecondButton, m_YourThirdButton;

    private float nextActionTime = 0.0f;
    private float waitPeriod = 1f;

    void Start()
    {
        //Calls the TaskOnClick/TaskWithParameters/ButtonClicked method when you click the Button
        m_YourFirstButton.onClick.AddListener(TaskOnClick);
        m_YourSecondButton.onClick.AddListener(TaskOnClick);
        m_YourThirdButton.onClick.AddListener(TaskOnClick);
    }



    public void Play()
    {
        Invoke("TaskOnClick", 3);
    }

    public void TaskOnClick()
    {      
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }

    public void TaskOffClick()
    {
        //Output this to console when Button1 or Button3 is clicked
        Debug.Log("You have deselected the button!");
    }

    public void TaskWithParameters()
    {
        //Output this to console when the Button2 is clicked
        Debug.Log("You have selected button 2!!!!!");
    }

    public void TaskWithParametersOFF()
    {
        //Output this to console when the Button2 is clicked
        Debug.Log("You have deselected button 2!!!!!");
    }


    public void ButtonClicked33333()
    {
        //Output this to console when the Button3 is clicked
        Debug.Log("You have selected button 3");
    }

    public void OFFButtonClicked33333()
    {
        //Output this to console when the Button3 is clicked
        Debug.Log("You have deselected button 3");
    }
}