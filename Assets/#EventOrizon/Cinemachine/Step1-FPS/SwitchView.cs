using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Cinemachine;

public class SwitchView : MonoBehaviour
{
    [SerializeField]private CinemachineVirtualCamera cineCam;
    [SerializeField]private  List<Transform> targets;

    public int currentInt;
    // Start is called before the first frame update
    void Start()
    {
        cineCam = GetComponent<CinemachineVirtualCamera>();
    }

    // Update is called once per frame
    void Update()
    {
         if (Input.GetKeyDown (KeyCode.Space)) {
            Debug.Log ("switch target");
            currentInt++;
            if(currentInt >= targets.Count){
                currentInt = 0;
            }
            cineCam.Follow = targets[currentInt];

        }
    }
}
