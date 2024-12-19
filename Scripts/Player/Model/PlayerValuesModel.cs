using UnityEngine;

namespace Player.Model
{
    [CreateAssetMenu(menuName = "GameData/PlayerStaticData", fileName = "NewPlayerStaticData")]
    public class PlayerData : ScriptableObject
    {
        [Header("Default Data")]
        [SerializeField] private int health = 100;
        [SerializeField] private int fuel = 100;
        [SerializeField] private float jumpForce = 11.5f;
        [SerializeField] private float walkForce = 7f;
        [SerializeField] private float dashForce = 15f;
        [SerializeField] private float moveInput;
        // [SerializeField] private float dashDuration = 1.0f;
        // [SerializeField] private float dashCooldown = 2.0f;
        // [SerializeField] private float attackDuration = 0.5f;
        // [SerializeField] private float attackCooldown = 1.0f;
        // [SerializeField] private float attackComboDuration = 0.3f;

        public int Health => health;
        public int Fuel => fuel;
        public float JumpForce => jumpForce;
        public float WalkForce => walkForce;
        public float DashForce => dashForce;
        public float MoveInput => MoveInput;
        // public float DashDuration => dashDuration;
        // public float DashCooldown => dashCooldown;
        // public float AttackDuration => attackDuration;
        // public float AttackCooldown => attackCooldown;
        // public float AttackComboDuration => attackComboDuration;
    }

    public class PlayerValuesModel
    {
        // 动态状态
        public float Health { get; private set; }
        public float Fuel { get; private set; }
        public float moveInput { get; private set; }

        public bool IsDashing { get; private set; }
        public bool IsLanding { get; private set; }
        public bool IsAttacking { get; private set; }
        public bool JumpLimit { get; private set; }
        public bool DashLimit { get; private set; }

        public PlayerValuesModel(PlayerData playerData)
        {
            // 初始化动态数据
            Health = playerData.Health;
            Fuel = playerData.Fuel;
            moveInput = playerData.MoveInput;
        }

        public  void PlayerMoveHorizontal()
        {
            
        }
    }
}
