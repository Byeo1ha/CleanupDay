using UnityEngine;

public class CutSceneRemind : MonoBehaviour
{
    [SerializeField] private DoubleCutSceneManager pictureCutScene;
    [SerializeField] private CutSceneManager ballCutScene;
    [SerializeField] private CutSceneManager tugCutScene;
    [SerializeField] private CutSceneManager leashCutScene;
    [SerializeField] private CutSceneManager shampooCutScene;
    [SerializeField] private PlayerRoomUIGuideText uiGuideText;

    public enum PropsType
    {
        None, Picture, Ball, Tug, Leash, Shampoo
    };

    [SerializeField] private PropsType propsType;

    public void SetPropsNone()
    {
        propsType = PropsType.None;
    }

    public void SetPropsPicture()
    {
        propsType = PropsType.Picture;
    }

    public void SetPropsBall()
    {
        propsType = PropsType.Ball;
    }

    public void SetPropsTug()
    {
        propsType = PropsType.Tug;
    }

    public void SetPropsLeash()
    {
        propsType = PropsType.Leash;
    }

    public void SetPropsShampoo()
    {
        propsType = PropsType.Shampoo;
    }

    public void OnButtonClick()
    {
        switch (propsType)
        {
            case PropsType.Picture:
                StartCoroutine(pictureCutScene.StartCutScene());
                break;
            case PropsType.Ball:
                StartCoroutine(ballCutScene.StartCutScene());
                break;
            case PropsType.Tug:
                StartCoroutine(tugCutScene.StartCutScene());
                break;
            case PropsType.Leash:
                StartCoroutine(leashCutScene.StartCutScene());
                break;
            case PropsType.Shampoo:
                StartCoroutine(shampooCutScene.StartCutScene());
                break;
            case PropsType.None:
                uiGuideText.StartGuide();
                return;
        }
    }
}
