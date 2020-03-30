using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using HTC.UnityPlugin.Vive;
using UnityEngine.UI;

public class ControllScene : MonoBehaviour
{

    public Text leftScreen;
    public Text rightScreen;
    public Text middleScreen;
    private float seqCounter;
    private float leftCounter;
    private float rightCounter;


    // Start is called before the first frame update
    void Start()
    {
        seqCounter = 0f;
        leftCounter = 0f;
        rightCounter = 0f;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void Awake()
    {
        ViveInput.AddListenerEx(HandRole.LeftHand, ControllerButton.Trigger, ButtonEventType.Click, reduceCounter);
        ViveInput.AddListenerEx(HandRole.RightHand, ControllerButton.Trigger, ButtonEventType.Click, increaseCounter);
    }

    private void OnDestroy()
    {
        ViveInput.RemoveListenerEx(HandRole.LeftHand, ControllerButton.Trigger, ButtonEventType.Click, reduceCounter);
        ViveInput.RemoveListenerEx(HandRole.RightHand, ControllerButton.Trigger, ButtonEventType.Click, increaseCounter);
    }

    private void reduceCounter()
    {
        Debug.Log("LeftHand_Trigger_Clicked");
        seqCounter -= 0.5f;
        middleScreen.text = "Seq_Counter: " + seqCounter;
        leftCounter -= seqCounter - 1;
        rightCounter += seqCounter + 1;
        leftScreen.text = "leftCounter: " + leftCounter;
        rightScreen.text = "rightCounter: " + rightCounter;
    }

    private void increaseCounter()
    {
        Debug.Log("RightHand_Trigger_Clicked");
        seqCounter += 0.5f;
        middleScreen.text = "Seq_Counter: " + seqCounter;
        leftCounter -= seqCounter - 1;
        rightCounter += seqCounter + 1;
        leftScreen.text = "leftCounter: " + leftCounter;
        rightScreen.text = "rightCounter: " + rightCounter;
    }
}
