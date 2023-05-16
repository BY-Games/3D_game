using UnityEngine;

public class AimStateManager : MonoBehaviour {
    float xAxis, yAxis;

    [SerializeField] private Transform camFollowPos;

    // Direction of the mouse movement
    [SerializeField] private float mouseSense = -1;


    // Update is called once per frame
    void Update() {
        xAxis += Input.GetAxisRaw("Mouse X") * mouseSense;
        yAxis -= Input.GetAxisRaw("Mouse Y") * mouseSense;
        yAxis = Mathf.Clamp(yAxis, -80, 80);

    }

    private void LateUpdate() {
        var localEulerAngles = camFollowPos.localEulerAngles;
        localEulerAngles =
            new Vector3(yAxis, localEulerAngles.y, localEulerAngles.z);
        camFollowPos.localEulerAngles = localEulerAngles;
        var transform1 = transform;
        var eulerAngles = transform1.eulerAngles;
        eulerAngles = new Vector3(eulerAngles.x, xAxis, eulerAngles.z);
        transform1.eulerAngles = eulerAngles;
    }
}
