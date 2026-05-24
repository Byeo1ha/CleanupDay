using UnityEngine;

[RequireComponent(typeof(BallDogAnimation))]
public class DogBallCatched : MonoBehaviour
{
    [SerializeField] private LayerMask ballLayer;
    private BallDogAnimation ballDogAnimation;

#if UNITY_EDITOR
    [ContextMenu("Auto Assign")]
    private void AutoAssign()
    {
        ballLayer = LayerMask.GetMask("Ball");
    }
#endif

    private void Awake()
    {
        ballDogAnimation = GetComponent<BallDogAnimation>();
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if ((ballLayer.value & (1 << collision.gameObject.layer)) == 0) return;

        Debug.Log("공 잡음");
        collision.gameObject.SetActive(false);

        ballDogAnimation.StopRunAnim();
        ballDogAnimation.StartCatchIdleAnim();
    }
}
