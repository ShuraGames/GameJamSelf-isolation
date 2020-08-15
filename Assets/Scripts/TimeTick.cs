using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;


public class TimeTick : MonoBehaviour
{
    public static TimeTick singleton;



    [SerializeField] private TextMeshProUGUI dayCounterText;

    private int index;

    public int stressedIndex;
    public int lonelinessIndex;
    public int fatigueIndex;
    public bool isPaused;
    public delegate void StressedCountUp(int index);
    public event StressedCountUp stressedCountUp;
    public event StressedCountUp lonelinessCountUp;
    public event StressedCountUp fatigueCountUp;

    private void Awake() 
    {
        singleton = this;
    }

    private void Start()
    {
        StartCoroutine(TimeTickCounter());
        StartCoroutine(GetCountToStressed());
        StartCoroutine(GetCountToLoneliness());
        StartCoroutine(GetCountToFatigue());
    }

    private IEnumerator TimeTickCounter()
    {
        while(true)
        {
            yield return new WaitForSeconds(.1f);

            if(!isPaused)
            {
                yield return new WaitForSeconds(10f);
                dayCounterText.text = "Day " + index;
                index++;
            }
        }
    }

    public IEnumerator GetCountToStressed()
    {
        while(true)
        {
            yield return new WaitForSeconds(.1f);

            if(!isPaused)
            {
                stressedIndex++;
                stressedCountUp?.Invoke(stressedIndex);
                yield return new WaitForSeconds(8);
            }
        }
    }
    public IEnumerator GetCountToLoneliness()
    {
        while(true)
        {
            yield return new WaitForSeconds(.1f);

            if(!isPaused)
            {
                lonelinessIndex++;
                lonelinessCountUp?.Invoke(lonelinessIndex);
                yield return new WaitForSeconds(5f);
            }
        }
    }
    public IEnumerator GetCountToFatigue()
    {
        while(true)
        {
            yield return new WaitForSeconds(.1f);

            if(!isPaused)
            {
                fatigueIndex++;
                fatigueCountUp?.Invoke(fatigueIndex);
                yield return new WaitForSeconds(5f);
            }
        }
    }

}
