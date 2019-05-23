using UnityEngine;

public class Vector3Test : MonoBehaviour
{

    mathlib.Vector3 ma = new mathlib.Vector3(-65.697f, 52.65f, 0f);
    mathlib.Vector3 mb = new mathlib.Vector3(100.65f, -88.6f, 0f);
    Vector3 ua = new Vector3(-65.697f, 52.65f, 0f);
    Vector3 ub = new Vector3(100.65f, -88.6f, 0f);

    void Start()
    {
        Debug.LogError("math add : " + (ma + mb) + " unity add : " + UnityVectorTostring(ua + ub));
        Debug.LogError("math division : " + (ma / 5.6f) + " unity division : " + UnityVectorTostring(ua / 5.6f));
        Debug.LogError("math dot product : " + ma * mb + " unity dot product : " + Vector3.Dot(ua, ub));
        Debug.LogError("math cross product : " + mathlib.Vector3.Cross(ma, mb) + " unity cross product : " + UnityVectorTostring(Vector3.Cross(ua, ub)));
        Debug.LogError("math normalize : " + mb.Normalized + " unity normalize : " + UnityVectorTostring(ub.normalized));
        Debug.LogError("math lerp : " + mathlib.Vector3.Lerp(ma, mb, 0.35f) + " unity lerp : " + UnityVectorTostring(Vector3.Lerp(ua, ub, 0.35f)));
        Debug.LogError("math magnitude : " + ma.Magnitude + " unity magnitude : " + ua.magnitude);
        Debug.LogError("math angle : " + mathlib.Vector3.Angle(ma, mb) + "unity angle" + Vector3.Angle(ua, ub));
        Debug.LogError("math project : " + mathlib.Vector3.Project(ma, mb) + " unity project : " + UnityVectorTostring(Vector3.Project(ua, ub)));
        Debug.LogError("math reflect : " + mathlib.Vector3.Reflect(ma, mb) + " unity reflect : " + UnityVectorTostring(Vector3.Reflect(ua, ub)));
        Debug.LogError("math slerp : " + mathlib.Vector3.Slerp(ma, mb, 0.76f) + " unity slerp : " + UnityVectorTostring(Vector3.Slerp(ua, ub, 0.76f)));
    }

    private string UnityVectorTostring(Vector3 vec) {
        return (string.Format("({0}, {1}, {2})", vec.x, vec.y, vec.z));
    }

}
