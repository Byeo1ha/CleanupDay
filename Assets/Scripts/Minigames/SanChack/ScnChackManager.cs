using System.Collections.Generic;
using UnityEngine;

public class ScnChackManager : MonoBehaviour
{
    [SerializeField] private List<SanChackData> SanChackList = new List<SanChackData>();
    [SerializeField] private int SanChackNum = 0;

    [SerializeField] private SpriteRenderer lRander;
    [SerializeField] private SpriteRenderer rRander;

    [System.Serializable]
    public struct SanChackData
    {
        public Sprite Limg;
        public Sprite Rimg;
        public bool side;
    }

    void Awake() {
        RelodeImg();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void RelodeImg()
    {
        lRander.sprite = SanChackList[SanChackNum].Limg;
        rRander.sprite = SanChackList[SanChackNum].Rimg;
    }

    private void OnClick(bool clickside)
    {
        //Debug.Log("OnClicked Side : " + clickside);
        if(SanChackNum >= SanChackList.Count)
        {
            return;
        }

        if(clickside == SanChackList[SanChackNum].side)
        {
            GoodWay();
        }
        else
        {
            BadWay();
        }

        SanChackNum++;
        RelodeImg();
    }

    private void GoodWay()
    {
        Debug.Log("마루쫑긋");
    }

    private void BadWay()
    {
        Debug.Log("마루씨발");
    }

    //씨발 존나 바쁘네 마루폴짝?
    public void LeftClick()
    {
        OnClick(false);
    }

    public void RightClick()
    {
        OnClick(true); 
    }
}
