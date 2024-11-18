using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MeshToggler : MonoBehaviour
{
    public GameObject turbineObject;
    public bool isActive = true;

    public void ToggleObject(){
        if(isActive){
            turbineObject.SetActive(false);
            isActive = false;
        }
        else{
            turbineObject.SetActive(true);
            isActive = true;
        }
    }
}
