// Credits https://www.youtube.com/watch?v=fdF4h2sUmwE
using System;
using System.Collections;
using System.Collections.Generic;
using UnityEditor.Animations;
using UnityEngine;

public class dataAnimation : MonoBehaviour
{
    public AnimationClip aClip;
    private bool isRecording;
    private GameObjectRecorder aRecorder;
    public GameObject targetToRecord;

    // Start is called before the first frame update
    void Start()
    {
        isRecording = false;
        aRecorder = new GameObjectRecorder();
        aRecorder.root = targetToRecord;
        aRecorder.BindComponent<Transform>(targetToRecord,true);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void LateUpdate()
    {
        if (aClip == null)
        {
            return;
        }

        if (isRecording)
        {
            aRecorder.TakeSnapshot(Time.deltaTime);
        }else if (aRecorder.isRecording)
        {
            aRecorder.SaveToClip(aClip);
            aRecorder.ResetRecording();
        }
    }

    public void startRecording()
    {
        isRecording = true;
    }

    public void stopRecording()
    {
        isRecording = false;
    }
}
