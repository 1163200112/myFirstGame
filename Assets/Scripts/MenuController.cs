using UnityEngine;

/*
 * Small behaviour to handle menu button callbacks.
 */
public class MenuController : MonoBehaviour
{
  /*
   * When the start button is pressed, load the Game scene.
   */
  public void OnStartClicked()
  {
    Application.LoadLevel("Level0");
  }

    public void OnstartClicked1()
    {
        Application.LoadLevel("Level1");
    }

    public void OnstartClicked2()
    {
        Application.LoadLevel("Level2");
    }

    public void OnQuitClicked()
    {
        Application.Quit();
    }

    /*
     * When the back button is clicked, load the Menu scene.
     */
    public void OnBackClicked()
  {
    Application.LoadLevel("Menu");
  }
}
