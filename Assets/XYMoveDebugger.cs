using UnityEngine;

public class XYMoveDebugger : MonoBehaviour
{
    #region Field

    public bool reverse;
    public float value;

    #endregion Field

    void Update ()
    {
        base.transform.position = new Vector3()
        {
            x = value * (this.reverse ? -1 : 1),
            y = value * 0.5f,
            z = base.transform.position.z
        };
    }
}