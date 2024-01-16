using System;
using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;
using UnityEngine.Playables;

public class IndependentTimeEvent : MonoBehaviour
{
    public PlayableDirector _TargetDirector;
    private void Awake()
    {
        if(_TargetDirector == null)
        {
            throw new Exception("Playable Director를 할당하지 않았습니다. ");
        }
    }

    public void Pause()
    {
        _TargetDirector.Pause();
    }

    public void JumpAndResume(float f)
    {
        _TargetDirector.time = f;
        _TargetDirector.Resume();
    }

    public void End()
    {
        _TargetDirector.Stop();
    }
}
