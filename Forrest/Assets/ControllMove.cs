using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Leap;
using Leap.Unity;

public class ControllMove : MonoBehaviour
{
    Controller controller;
    float HandPalmPitch;
    float HandPalmYaw;
    float HandPalmRoll;
    float HandWristRot;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        controller = new Controller();
        Frame frame = controller.Frame();
        List<Hand> hands = frame.Hands;
        if (frame.Hands.Count > 0)
        {
            Hand fristHand = hands[0];
        }


        HandPalmPitch = hands[0].PalmNormal.Pitch;
        HandPalmRoll = hands[0].PalmNormal.Roll;
        HandPalmYaw = hands[0].PalmNormal.Yaw;

        HandWristRot = hands[0].WristPosition.Pitch;

        Debug.Log("Pitch : " + HandPalmPitch);
        Debug.Log("Roll : " + HandPalmRoll);
        Debug.Log("Yaw : " + HandPalmYaw);
        
        //Straight
        if (HandPalmYaw > -0.5f && HandPalmYaw < 4f)
        {
            transform.Translate(new Vector3(0, 0, 0.7f * Time.deltaTime));
        }
        //Back
        else if (HandPalmYaw < -2.5f)
        {
            transform.Translate(new Vector3(0, 0, -0.7f * Time.deltaTime));
        }
        //Left
        if (HandPalmRoll < -0.1f)
        {
            transform.Translate(new Vector3(0.7f * Time.deltaTime, 0, 0));
        }
        //Right
        else if (HandPalmRoll > 0.1f && HandPalmRoll < 3f)
        {
            transform.Translate(new Vector3(-0.7f * Time.deltaTime, 0, 0));
        }
    }
}
