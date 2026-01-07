using System;
using System.Collections;
using UnityEngine;
using UnityEngine.UI;

namespace HotFix
{
    public class ShareWindow : Window
    {
        private Button ReturnBtn;
        public override void Awake(object param1 = null, object param2 = null, object param3 = null)
        {
            GatAllComponent();
            AddAllBtnListener();
        }

        private void AddAllBtnListener()
        {
            AddButtonClickListener(ReturnBtn, SHAREPANEL);
        }

        private void SHAREPANEL()
        {
            UIManager.instance.CloseWnd(FilesName.SHAREPANEL);
        }

        private void GatAllComponent()
        {
            ReturnBtn= m_Transform.Find("Back/ReturnBtn").GetComponent<Button>();
        }
    }
}