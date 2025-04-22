using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.InputSystem;

public class inputmanager : MonoBehaviour
{ 
    InputSystem actions;

    public Vector2 moveDir;
    void Start()
    {
        
        
        actions = new InputSystem();
        actions.Enable();
        actions.Player.Move.performed += i => moveDir = i.ReadValue<Vector2>();
        actions.Player.Move.canceled += i => moveDir = Vector2.zero;
    }

   
    void Update()
    {
      
    }
   
}
