using System.Collections;
using UnityEngine;

public class DoubleCutSceneManager : MonoBehaviour
{
    [SerializeField] private CutSceneFade cutSceneFade1;
    [SerializeField] private CutSceneFade cutSceneFade2;

    public IEnumerator StartCutScene()
    {
        FadeManager.Instance.HalfFadeOut();
        cutSceneFade1.FadeIn();
        cutSceneFade2.FadeIn();

        yield return new WaitForSecondsRealtime(5f);
        FadeManager.Instance.HalfFadeIn();
        cutSceneFade1.FadeOut();
        cutSceneFade2.FadeOut();

        yield return new WaitForSecondsRealtime(2f);
    }
}
