using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Force24fps : MonoBehaviour
{

public int targetFPS = 12;

 void Awake () {

     QualitySettings.vSyncCount = 0;  // VSync must be disabled
     Application.targetFrameRate = targetFPS;

 }
}
