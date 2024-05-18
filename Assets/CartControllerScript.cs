using UnityEngine;

public class CartControllerScript : MonoBehaviour
{
    private Animator animator;

    void Start()
    {
        animator = GetComponent<Animator>();
    }

    void Update()
    {
        // ������ �������� �� ������� ������ (��������, ������)
        if (Input.GetKeyDown(KeyCode.Space))
        {
            animator.Play("CartMove");
        }
    }
}
