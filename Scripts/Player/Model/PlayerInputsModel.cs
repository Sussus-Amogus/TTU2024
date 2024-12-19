using System.Collections.Generic;
using UnityEngine.InputSystem;

namespace Player.Model
{
    public class PlayerInputsModel
    {
        public readonly InputActionAsset InputActions;//宣告一個集合與多個動作
        private readonly List<InputAction> _actions = new List<InputAction>();

        public PlayerInputsModel(InputActionAsset inputActions)
        {
            // 初始化 InputActions
            InputActions = inputActions;//將各種動作存入集合
            
            foreach (var map in inputActions.actionMaps)
            {
                foreach (var action in map.actions)
                {
                    _actions.Add(action);
                }
            }

            // 可以根據需要添加更多的初始化邏輯（例如啟動動作）
            EnableActions();
        }
        // 啟用所有的輸入動作
        private void EnableActions()
        {
            foreach (var action in _actions)
            {
                action.Enable();
            }
        }
        
        private void DisableActions()
        {
            foreach (var action in _actions)
            {
                action.Disable();
            }
        }
    }
}