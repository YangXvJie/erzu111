
using System;
using System.Security.Cryptography;
using UnityEngine;
using UnityEngine.UI;

namespace HotFix
{
    public class DetailWindow : Window
    {
        private Button m_QuitBtn;//退出按钮
        private Text m_Name;//名字
        private Image m_SexIcon;//性别
        private Text m_Age;//年龄
        private Text m_QiPaoNum;//起跑
        private Text m_SuDuNum;//速度
        private Text m_NaiLiNum;//耐力
        private Text m_ZhiHuiNum;//智慧
        private Text m_YuanQiZhiNum;//元气值
        private Slider m_QiPaoSlider;//起跑滑动条
        private Slider m_SuDuSlider;//速度滑动条
        private Slider m_NaiLiSlider;//耐力滑动条
        private Slider m_ZhiHuiSlider;//智慧滑动条
        private Slider m_YuanQiZhiSlider;//元气值滑动条
        private Text m_BiSaiNum;//比赛数量
        private Text m_WinNum;//胜率
        private Button m_JingSaiBtn;//竞赛属性按钮   打开竞赛界面
        private Button m_BiSaiBtn;//比赛记录按钮   打开比赛记录界面
        private GameObject m_JingSaiPanel;//竞赛界面
        private GameObject m_BiSaiPanel;//比赛界面
        private HorseObject m_HorseObject;

        public override void Awake(object param1 = null, object param2 = null, object param3 = null)
        {
            base.Awake(param1, param2, param3);
            FindAllComponent();
            AddAllBtnListener();
            HorseDetail horseData = (HorseDetail)param1;
            m_HorseObject = ObjectsManager.instance.AddObject(m_Transform.Find("BG/HorsePos").GetChild(0).gameObject, "Horse", "HorseObject", new HorseData(horseData.id, horseData.code, 1, 0)) as HorseObject;
        }

        private void AddAllBtnListener()
        {
            AddButtonClickListener(m_QuitBtn, () => { UIManager.instance.CloseWnd(this); });
            AddButtonClickListener(m_JingSaiBtn, () =>
            {
                m_JingSaiPanel.SetActive(true);
                m_BiSaiPanel.SetActive(false);
            });
            AddButtonClickListener(m_BiSaiBtn, () =>
            {
                m_JingSaiPanel.SetActive(false);
                m_BiSaiPanel.SetActive(true);
            });
        }

        public void FindAllComponent()
        {
            m_QuitBtn = m_Transform.Find("Return").GetComponent<Button>();
            m_Name = m_Transform.Find("Back/Btns/Name").GetComponent<Text>();
            m_SexIcon = m_Transform.Find("Back/Btns/Sex/Image").GetComponent<Image>();
            m_Age = m_Transform.Find("Back/Btns/Name/Time/Text").GetComponent<Text>();
            m_QiPaoNum = m_Transform.Find("Back/JingSaiBack/BackImg/QiPao/SliderBack/Des").GetComponent<Text>();
            m_SuDuNum = m_Transform.Find("Back/JingSaiBack/BackImg/SuDu/SliderBack/Des").GetComponent<Text>();
            m_NaiLiNum = m_Transform.Find("Back/JingSaiBack/BackImg/NaiLi/SliderBack/Des").GetComponent<Text>();
            m_ZhiHuiNum = m_Transform.Find("Back/JingSaiBack/BackImg/ZhiHui/SliderBack/Des").GetComponent<Text>();
            m_YuanQiZhiNum = m_Transform.Find("Back/JingSaiBack/BackImg/PiLaoDu/SliderBack/Des").GetComponent<Text>();
            m_QiPaoSlider = m_Transform.Find("Back/JingSaiBack/MyBackImg/QiPao/SliderBack").GetComponent<Slider>();
            m_SuDuSlider = m_Transform.Find("Back/JingSaiBack/MyBackImg/SuDu/SliderBack").GetComponent<Slider>();
            m_NaiLiSlider = m_Transform.Find("Back/JingSaiBack/MyBackImg/NaiLi/SliderBack").GetComponent<Slider>();
            m_ZhiHuiSlider = m_Transform.Find("Back/JingSaiBack/MyBackImg/ZhiHui/SliderBack").GetComponent<Slider>();
            m_YuanQiZhiSlider = m_Transform.Find("Back/JingSaiBack/MyBackImg/PiLaoDu/SliderBack").GetComponent<Slider>();
            m_BiSaiNum = m_Transform.Find("Back/BiSaiBack/Back/DesBack/Des").GetComponent<Text>();
            m_WinNum = m_Transform.Find("Back/BiSaiBack/Back/DesBack/Num").GetComponent<Text>();
            m_JingSaiBtn = m_Transform.Find("Back/Btns/JingSai").GetComponent<Button>();
            m_BiSaiBtn = m_Transform.Find("Back/Btns/BiSai").GetComponent<Button>();
            m_JingSaiPanel = m_Transform.Find("Back/JingSaiBack").gameObject;
            m_BiSaiPanel = m_Transform.Find("Back/BiSaiBack").gameObject;
        }

        public override void OnShow(object param1 = null, object param2 = null, object param3 = null)
        {
            base.OnShow(param1, param2, param3);
            m_JingSaiPanel.SetActive(true);
            m_BiSaiPanel.SetActive(false);
            HorseDetail horseData = (HorseDetail)param1;
            m_HorseObject.SetHorseTexture(horseData.code);
        }
    }
}