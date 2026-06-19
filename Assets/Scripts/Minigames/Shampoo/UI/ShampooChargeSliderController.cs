using UnityEngine;
using UnityEngine.UI;

public class ShampooChargeSliderController : MonoBehaviour
{
    [SerializeField] private ShampooSystemManager shampooSystemManager;
    [SerializeField] private Slider chargeSlider;
    [SerializeField] private float decreaseSpeed = 4f;

    private void Awake()
    {
        if (chargeSlider == null)
        {
            chargeSlider = GetComponent<Slider>();
        }
    }

    private void Start()
    {
        if (shampooSystemManager == null) return;
        if (chargeSlider == null) return;

        chargeSlider.normalizedValue = shampooSystemManager.NormalizedCharged;
    }

    private void LateUpdate()
    {
        if (shampooSystemManager == null) return;
        if (chargeSlider == null) return;

        float targetValue = shampooSystemManager.NormalizedCharged;

        if (targetValue >= chargeSlider.normalizedValue)
        {
            chargeSlider.normalizedValue = targetValue;
            return;
        }

        chargeSlider.normalizedValue = Mathf.MoveTowards(
            chargeSlider.normalizedValue,
            targetValue,
            Time.deltaTime * decreaseSpeed);
    }
}
