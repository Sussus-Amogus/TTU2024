using System.Collections;
using UnityEngine.InputSystem;
using Player.Model;
using UnityEngine;

namespace Player.Controller
{
    public class PlayerController : MonoBehaviour
    {
        Rigidbody2D PlayerRB;
        [SerializeField] private PlayerData playerData; // 從 Unity Editor 設定 PlayerData（ScriptableObject）
        [SerializeField] private InputActionAsset inputActionAsset; // 從 Unity Editor 設定 InputActionAsset（包含輸入設置）


        private PlayerInputsModel _inputSettingsModel;
        private PlayerValuesModel _playerValuesModel;
        
        private void InitializeModels()
        {
            _playerValuesModel = new PlayerValuesModel(playerData);
            _inputSettingsModel = new PlayerInputsModel(inputActionAsset);
        }

        private void Start()
        {
            InitializeModels();
            RegisterInputCallbacks();
        }

        private void RegisterInputCallbacks()
        {
            // 遍歷所有輸入動作並註冊它們
            foreach (var action in _inputSettingsModel.InputActions.actionMaps)
            {
                foreach (var inputAction in action.actions)
                {
                    if (inputAction.name == "MoveHorizontal")
                    {
                        inputAction.performed += ctx => HandleMovement(ctx);
                        inputAction.canceled += ctx => HandleMovementStop(); 
                    }
                    // else if (inputAction.name == "Jump")
                    // {
                    //     inputAction.performed += ctx => HandleJump();
                    // }
                    // else if (inputAction.name == "Attack")
                    // {
                    //     inputAction.performed += ctx => HandleAttack();
                    // }
                    // else if (inputAction.name == "Dash")
                    // {
                    //     inputAction.performed += ctx => HandleDash();
                    // }
                    // 根據需要添加更多動作的處理
                }
            }
        }
        private void Update()//檢測各項input，若符合則打開tag
        {

        }
        void FixedUpdate() //收到各項tag後，執行tag之指令
        {
            HandleFlags();
        }
        
        //============================================================
        private void HandleFlags()
        {
            
        }
        private void HandleMovement(InputAction.CallbackContext ctx)
        {
            // 處理移動邏輯
            float moveInput = ctx.ReadValue<float>();
            
        }

        private void HandleMovementStop()
        {
            float moveInput = 0;
        }
    }
}