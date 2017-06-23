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
        if (PauseMenu.IsOn)
        {
            cursorHide = false;
            UpdateCursor();

        } else
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
