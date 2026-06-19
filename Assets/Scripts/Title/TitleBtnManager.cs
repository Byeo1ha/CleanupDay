using UnityEngine;

public class TitleBtnManager : MonoBehaviour
{
    [SerializeField] private string nextSceneName = "IntroScene";
    [SerializeField] private ImgLoader imgLoader;

    public void GameStartBtn()
    {
        SceneLoadManager.Instance.LoadScene(nextSceneName);
    }

    public void GameQuitBtn()
    {
        Application.Quit();
    }

    public void OpenSliceImg()
    {
        
    }

}
