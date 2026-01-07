using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine.UI;

namespace HotFix
{
    class RentWindow:Window
    {
        Button closeBtn;
        public override void Awake(object param1 = null, object param2 = null, object param3 = null)
        {
            base.Awake(param1, param2, param3);
            closeBtn = m_Transform.Find("BackImg/CloseBtn").GetComponent<Button>();
            AddButtonClickListener(closeBtn, () =>
            {
                UIManager.instance.CloseWnd(this);
            });
        }
    }
}
