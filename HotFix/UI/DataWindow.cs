using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine.UI;

namespace HotFix
{
    class DataWindow: Window
    {
        private Button m_QuitBtn;//推出按钮
        private Text m_Name;//名字
        private Image m_SexIcon;//性别
        private Text m_Age;//年龄
        private Text m_QiPaoNum;//起跑
        private Text m_SuDuNum;//速度
        private Text m_NaiLiNul;//耐力
        private Text m_ZhiHuiNum;//智慧
        private Text m_YuangiZhiNum;//元气值
        private Slider m_QiPaoNumslider;//起跑
        private Slider m_SuDuNunSlider;//速度
        private Slider m_NaiLiNumSlider;//耐力
        private Slider m_ZhiHuiNunSlider;//智慧
        private Slider m_YuanQiZhiNumSlider;//元气值
        private Text m_BiSaiNul;//比t赛数量
        private Text m_winNu;//胜率
        private Button m_JingSa18t0;//竞赛属性按钮 打开竞赛界面
        private Button m_BiSa1Btn;//比赛记录按钮 打开比赛记录界面
        public override void Awake(object param1 = null, object param2 = null, object param3 = null)
        {
            base.Awake(param1, param2, param3);
            FindAllComponent();
            AddAllBtnListener();
        }

        private void AddAllBtnListener()
        {
            AddButtonClickListener(m_QuitBtn, () => { UIManager.instance.CloseWnd(this); });
        }

        private void FindAllComponent()
        {
            m_QuitBtn = m_Transform.Find("QuitBtn").GetComponent<Button>();
            m_Name = m_Transform.Find("Name").GetComponent<Text>();
            m_SexIcon = m_Transform.Find("SexIcon").GetComponent<Image>();
            m_Age = m_Transform.Find("Age").GetComponent<Text>();
            m_QiPaoNum = m_Transform.Find("QiPaoNum").GetComponent<Text>();
            m_SuDuNum = m_Transform.Find("SuDuNum").GetComponent<Text>();
            m_NaiLiNul = m_Transform.Find("NaiLiNum").GetComponent<Text>();
            m_ZhiHuiNum = m_Transform.Find("ZhiHuiNum").GetComponent<Text>();
            m_YuangiZhiNum = m_Transform.Find("YuanQiZhiNum").GetComponent<Text>();
            m_QiPaoNumslider = m_Transform.Find("QiPaoNumSlider").GetComponent<Slider>();
            m_SuDuNunSlider = m_Transform.Find("SuDuNumSlider").GetComponent<Slider>();
            m_NaiLiNumSlider = m_Transform.Find("NaiLiNumSlider").GetComponent<Slider>();
            m_ZhiHuiNunSlider = m_Transform.Find("ZhiHuiNumSlider").GetComponent<Slider>();
            m_YuanQiZhiNumSlider = m_Transform.Find("YuanQiZhiNumSlider").GetComponent<Slider>();
            m_BiSaiNul = m_Transform.Find("BiSaiNum").GetComponent<Text>();
            m_winNu = m_Transform.Find("WinNum").GetComponent<Text>();
            m_JingSa18t0 = m_Transform.Find("JingSaBtn").GetComponent<Button>();
            m_BiSa1Btn = m_Transform.Find("BiSaBtn").GetComponent<Button>();

        }
    }
}
