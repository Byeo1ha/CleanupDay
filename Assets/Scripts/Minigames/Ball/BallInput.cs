using UnityEngine;

public class BallInput : MonoBehaviour
{
    [SerializeField] private BallThrowController ballThrowController;

#if UNITY_EDITOR
    [ContextMenu("Auto Assign")]
    private void AutoAssign()
    {
        ballThrowController = GameObject.Find("BallThrowManager").GetComponent<BallThrowController>();
    }
#endif

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            ballThrowController.StartBallThrow();
        }

        if (Input.GetKey(KeyCode.Space))
        {
            ballThrowController.HoldBallThrow();
        }

        if (Input.GetKeyUp(KeyCode.Space))
        {
            ballThrowController.FinishBallThrow();
        }
    }
}
