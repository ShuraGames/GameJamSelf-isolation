using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EventMouse : MonoBehaviour
{
    [SerializeField] private GameObject menuItemObject;

    private void OnMouseDown() 
    {
        if(menuItemObject != null) 
        {
            menuItemObject.SetActive(true);
            TimeTick.singleton.isPaused = true;
        }
    }
}
