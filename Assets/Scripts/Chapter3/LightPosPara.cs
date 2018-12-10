using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[ExecuteInEditMode]
public class LightPosPara : MonoBehaviour
{
    private Transform mTrans;

    void Awake() {
        mTrans = transform;
    }

    void Update()
    {

        Shader.SetGlobalVector("_Light_Pos", mTrans.position);
    }
}
