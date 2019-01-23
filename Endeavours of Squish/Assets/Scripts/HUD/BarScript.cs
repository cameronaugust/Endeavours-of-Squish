using UnityEngine;
using UnityEngine.UI;

public class BarScript : MonoBehaviour
{
    private float fillAmount;

    [SerializeField]
    private float lerpSpeed;

    [SerializeField]
    private Image content;

    public float MaxValue { get; set; }

    public float Value
    {
        set
        {
            fillAmount = Map(value, 0, MaxValue, 0, 1);
        }
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        HandleBar();
    }
    private void HandleBar()
    {
        if (fillAmount != content.fillAmount)
        {
            content.fillAmount = Mathf.Lerp(content.fillAmount, fillAmount, Time.deltaTime * lerpSpeed) ;
        }
    }
    private float Map(float value, float inMin, float inMax, float outMin, float outMax)
    {
        //conversion from any scale of health to 0-> 1 for content fillment
        return (value - inMin) * (outMax - outMin) / (inMax - inMin) + outMin;
        
    }
}
