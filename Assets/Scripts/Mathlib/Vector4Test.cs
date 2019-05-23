using UnityEngine;

public class Vector4Test : MonoBehaviour
{

    mathlib.Vector4 ma = new mathlib.Vector4(-65.697f, 52.65f, 0f, 1.1f);
    mathlib.Vector4 mb = new mathlib.Vector4(100.65f, -88.6f, 0f, 2.5f);
    Vector4 ua = new Vector4(-65.697f, 52.65f, 0f, 1.1f);
    Vector4 ub = new Vector4(100.65f, -88.6f, 0f, 2.5f);

    void Start()
    {
        Debug.LogError("math add : " + (ma + mb) + " unity add : " + UnityVectorTostring(ua + ub));
        Debug.LogError("math division : " + (ma / 5.6f) + " unity division : " + UnityVectorTostring(ua / 5.6f));
        Debug.LogError("math dot product : " + ma * mb + " unity dot product : " + Vector4.Dot(ua, ub));
        Debug.LogError("math normalize : " + mb.Normalized + " unity normalize : " + UnityVectorTostring(ub.normalized));
        Debug.LogError("math lerp : " + mathlib.Vector4.Lerp(ma, mb, 0.35f) + " unity lerp : " + UnityVectorTostring(Vector4.Lerp(ua, ub, 0.35f)));
        Debug.LogError("math magnitude : " + ma.Magnitude + " unity magnitude : " + ua.magnitude);
    }

    private string UnityVectorTostring(Vector4 vec)
    {
        return (string.Format("({0}, {1}, {2})", vec.x, vec.y, vec.z));
    }

}
