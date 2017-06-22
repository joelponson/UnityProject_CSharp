using UnityEngine;

public class CursorScript : MonoBehaviour {

    private bool cursorHide;

    // Use this for initialization
    void Start () {
        cursorHide = true;
        UpdateCursor();
    }
	
	// Update is called once per frame
	void Update ()
    {
        if (Input.GetKeyUp(KeyCode.Escape))
        {
            cursorHide = false; UpdateCursor();
        } else if (Input.GetMouseButtonDown(0))
        {
            cursorHide = true;
            UpdateCursor();
        }
    }

    void UpdateCursor()
    {
        if (cursorHide)
        {
            Cursor.lockState = CursorLockMode.Locked; Cursor.visible = false;
        } else
        {
            Cursor.lockState = CursorLockMode.None; Cursor.visible = true;
        }
    }
}
