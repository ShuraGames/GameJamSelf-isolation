using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LocalButton : MonoBehaviour
{

    [SerializeField] private GameObject loadPanel;
    [SerializeField] private GameObject loadBox;

//Button from monitor start
    public void PlayGame()
    {
        StartCoroutine(ChangeParametrs(-2, 2, 2));
    }

    public void Social()
    {
        StartCoroutine(ChangeParametrs(0, -2, 2));
    }

    public void Learning()
    {
        StartCoroutine(ChangeParametrs(2, -2, 2));
    }
//Button from monitor end

//Button from bed start
    public void Sleep()
    {
        StartCoroutine(ChangeParametrs(0, 1, -6));
    }

    public void Doze()
    {
        StartCoroutine(ChangeParametrs(1, 1, -4));
    }
//Button from bed End




    private IEnumerator ChangeParametrs(int stressed, int loneliness, int fatigue)
    {
        loadBox.SetActive(true);
        loadPanel.SetActive(true);
        yield return new WaitForSeconds(3);

        TimeTick.singleton.stressedIndex += stressed;
        TimeTick.singleton.lonelinessIndex += loneliness;
        TimeTick.singleton.fatigueIndex += fatigue;
        
        loadBox.SetActive(false);
        loadPanel.SetActive(false);
    }        
}
