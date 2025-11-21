using UnityEngine;

public class UnitSelection : MonoBehaviour
{
    public IUnit selectedUnit;

    void Update()
    {
        return;

        // if(Input.Getu)
        // {
        //     Vector2 mousePos = Mouse.current.position.ReadValue;
        //     Ray rayOrigin = Camera.main.ScreenPointToRay(mousePos);

        //     if(Physics.Raycast(rayOrigin, out hitInfo))
        //     {
        //         GameObject item = hitInfo.transform.gameObject;
        //         selectedUnit.ToggleOutline(false);
        //         selectedUnit = item.GetComponent<IUnit>();
        //         selectedUnit.ToggleOutline(true);
        //     }
        // }
    }
}