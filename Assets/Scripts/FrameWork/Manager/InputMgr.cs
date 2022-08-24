﻿using UnityEngine;

namespace FrameWork.Manager
{
    public class InputMgr : BaseManager
    {
        private bool isStart = false;

        //构造方法中，添加Update监听
        public InputMgr() {
            AppFacade.MonoMgr.AddUpdateListener(MyUpdate);
        }
        //检测是否需要开启输入检测
        public void StartOrEndCheck(bool isOpen) {
            isStart = isOpen;
        } 
        private void MyUpdate() {
            //没有开启输入检测，就不去检测
            if (!isStart)
                return;
            CheckKeyCode(KeyCode.A);
            CheckKeyCode(KeyCode.D);
            CheckKeyCode(KeyCode.W);
            CheckKeyCode(KeyCode.S);
        }
        private void CheckKeyCode(KeyCode key) {
            if (Input.GetKeyDown(key))
            {
                //事件中心模块，分发按下抬起事件（把哪个按键也发送出去）
                AppFacade.EventMgr.EventTrigger("KeyisDown", key);
            }
            if (Input.GetKeyUp(key))
            {
                AppFacade.EventMgr.EventTrigger("KeyisUp", key);
            }
        }
    }
}
