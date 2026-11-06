using UnityEngine;
using UnityEngine.InputSystem;

public class Puerta : MonoBehaviour
{
    [SerializeField] InputActionReference interactuar;
    Animator animator;
    bool levantada;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        animator = GetComponent<Animator>();
    }

    private void OnEnable()
    {
        interactuar.action.performed += Interactuar;
        interactuar.action.Enable();
    }
    void Interactuar(InputAction.CallbackContext context)
    {
        animator.SetBool("Abierto", levantada);
        levantada = !levantada;
        Debug.Log("CAmbio");
    }
}
