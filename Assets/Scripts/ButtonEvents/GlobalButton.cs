using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GlobalButton : MonoBehaviour
{
    public void ExitThisMenu(GameObject thisMenu)
    {
        thisMenu.SetActive(false);
        TimeTick.singleton.isPaused = false;
    }
}
