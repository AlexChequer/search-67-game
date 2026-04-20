using UnityEngine;

public class PlayerHealth : MonoBehaviour
{
    private bool isInvincible = false;
    public float invincibleDuration = 1.5f;
    private SpriteRenderer spriteRenderer;

    void Start()
    {
        spriteRenderer = GetComponent<SpriteRenderer>();
    }

    public void TakeDamage()
    {
        if (isInvincible) return;
        
        GameController.LoseLife();
        isInvincible = true;
        InvokeRepeating(nameof(Blink), 0f, 0.15f);
        Invoke(nameof(ResetInvincibility), invincibleDuration);
    }

    void Blink()
    {
        spriteRenderer.enabled = !spriteRenderer.enabled;
    }

    void ResetInvincibility()
    {
        CancelInvoke(nameof(Blink));
        spriteRenderer.enabled = true;
        isInvincible = false;
    }
}