using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class MovePlayer : MonoBehaviour
{
    [Header("Movement")]
    public Joystick movementJoystick;
    public float playerSpeed = 5f;

    [Header("Attack")]
    public float attackDuration = 0.5f;
    public Button attackButton;

    [Header("UI")]
    public GameObject talkPanel;

    [Header("Health")]
    public int maxHp = 100;
    public Animator animatorLife;

    [SerializeField]
    public int currentHp;
    private Animator animator;
    private Rigidbody2D rb;
    private float attackTimer;
    private bool isAttacking;

    private void Awake()
    {
        animator = GetComponent<Animator>();
        rb = GetComponent<Rigidbody2D>();
        currentHp = maxHp;
    }

    private void Start()
    {
        if (SceneManager.GetActiveScene().name == "Grove")
        {
            Transform lifeBar = transform.GetChild(1);
            lifeBar.gameObject.SetActive(true);
            animatorLife = lifeBar.GetComponent<Animator>();
        }
    }

    private void FixedUpdate()
    {
        UpdateAttackTimer();
        if (isAttacking) return;

        HandleMovement();
        UpdateAnimationState();
    }

    public void ReceiveDamage()
    {
        Debug.Log("Damage taken");
        if (currentHp == 100)
        {
            SetHp(66);
        }
        else if (currentHp == 66)
        {
            SetHp(33);
        }
        else if (currentHp == 33)
        {
            SetHp(0);
            animator.SetTrigger("Hp");
            Debug.Log("Player died");
        }
        Debug.Log(currentHp);
    }

    private void SetHp(int value)
    {
        currentHp = value;
        if (animatorLife != null)
            animatorLife?.SetInteger("currentHp", value);
    }

    private void HandleMovement()
    {
        if (talkPanel.activeInHierarchy)
        {
            rb.velocity = Vector2.zero;
            return;
        }

        Vector2 input = new Vector2(movementJoystick.Direction.x, movementJoystick.Direction.y);
        rb.velocity = input != Vector2.zero ? input * playerSpeed : Vector2.zero;
    }

    public void HandleAttack()
    {
        if (isAttacking) return;

        isAttacking = true;
        Debug.Log("Attack");

        float moveX = animator.GetFloat("MoveX");
        float moveY = animator.GetFloat("MoveY");

        if (moveX == 0 && moveY == 0)
            animator.SetTrigger("TriggerAttackDown");
        else if (moveX > 0)
            animator.SetTrigger("TriggerAttackRight");
        else if (moveX < 0)
            animator.SetTrigger("TriggerAttackLeft");
        else if (moveY > 0)
            animator.SetTrigger("TriggerAttackUp");
        else if (moveY < 0)
            animator.SetTrigger("TriggerAttackDown");

        animator.SetFloat("MoveX", 0);
        animator.SetFloat("MoveY", 0);
        rb.velocity = Vector2.zero;
    }

    private void UpdateAnimationState()
    {
        float x = rb.velocity.x;
        float y = rb.velocity.y;
        animator.SetFloat("MoveX", Mathf.Abs(x) < Mathf.Abs(y) ? 0 : x);
        animator.SetFloat("MoveY", Mathf.Abs(y) < Mathf.Abs(x) ? 0 : y);
    }

    private void UpdateAttackTimer()
    {
        if (!isAttacking) return;

        attackTimer += Time.deltaTime;
        if (attackTimer >= attackDuration)
        {
            attackTimer = 0;
            isAttacking = false;
        }
    }
}
