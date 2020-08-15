using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class OutputEvents : MonoBehaviour
{

    
    [SerializeField] private Slider stressedSlider;
    [SerializeField] private Slider lonelinessSlider;
    [SerializeField] private Slider fatigueIndexSlider;

    public static OutputEvents outputEventsSingleton;

    private void Awake() 
    {
        outputEventsSingleton = this;    
    }

    private void Start() 
    {
        TimeTick.singleton.stressedCountUp += UpTextStressed;
        TimeTick.singleton.lonelinessCountUp += UpTextLoneliness;
        TimeTick.singleton.fatigueCountUp += UpTextFatigue;
    }

    public void UpTextStressed(int index)
    {
        stressedSlider.value = index;
    }

    public void UpTextLoneliness(int index)
    {
        lonelinessSlider.value = index;
    }

    public void UpTextFatigue(int index)
    {
        fatigueIndexSlider.value = index;
    }
}
