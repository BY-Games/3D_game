using System;
using System.Collections;
using System.Collections.Generic;
using Cinemachine;
using UnityEngine;

public class AimStateManager : MonoBehaviour {
    float xAxis, yAxis;

    [SerializeField] private Transform camFollowPos;

    [SerializeField] private float mouseSense = -1;

    [HideInInspector] public CinemachineVirtualCamera vCam;
    [HideInInspector] public float currentFov = 10;
    [SerializeField] private float fovSmoothSpeed = 40;

    [SerializeField] private Transform aimPos;
    [SerializeField] private float aimSmoothSpeed = 20;
    [SerializeField] private LayerMask aimMask;
    
    [HideInInspector] public RaycastHit hitInfo;

    // Start is called before the first frame update
    void Start() {
        vCam = GetComponentInChildren<CinemachineVirtualCamera>();
    }

    // Update is called once per frame
    void Update() {
        xAxis += Input.GetAxisRaw("Mouse X") * mouseSense;
        yAxis -= Input.GetAxisRaw("Mouse Y") * mouseSense;
        yAxis = Mathf.Clamp(yAxis, -80, 80);


        // vCam.m_Lens.FieldOfView = Mathf.Lerp(vCam.m_Lens.FieldOfView, currentFov, fovSmoothSpeed * Time.deltaTime);

        Vector2 screenCentre = new Vector2(Screen.width / 2, Screen.height / 2);
        Ray ray = Camera.main.ScreenPointToRay(screenCentre);
        if (Physics.Raycast(ray, out hitInfo, Mathf.Infinity, aimMask)) {
            aimPos.position = Vector3.Lerp(aimPos.position, hitInfo.point, aimSmoothSpeed * Time.deltaTime);
        }
        // To see the Gizmo of the ray in the Scene view:
        // Debug.DrawRay(transform.TransformPoint(transform.position), aimPos.position, Color.red);

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
