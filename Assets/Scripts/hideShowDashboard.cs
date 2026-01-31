using System.Collections;
using System.Collections.Generic;
using UnityEngine;
/**
 *                  .________________._____
 *                /~~~~~~~//~~~~~~~~//~~~~~|
 *               /       //        //      |
 *              /_\.___ //__ \.___//_______|
 *    O       [%%%%%%%%%] O=====] |[_______]
 *   __\__ ===========___/_ --------}==========================
 *  |**   |/|(@ ## (@|   **|        |     []|                  |)
 *  |     |/| ###### |     | _____  |       |         ___      |
 *  |_____|/|_######_|____ |/_  _  \}_______|________/_  _\    |.
 * |________________________|     \ \_______________//     \\ /
 *   |%{  @  }            |%{  @  }                |%{  @  }
 *    \%\   /              \%\   /                  \%\   /
 *      ~~~~                 ~~~~                     ~~~~   
 * Shows / Hides Dashboard with Turning Wheel
 *
 *
 * @author Rolando <rgarro@gmail.com> <https://emptyart.github.io>
 */
public class hideShowDashboard : MonoBehaviour
{
 
    public GameObject dashboard;
    public Texture2D dashboardIcon;
    protected bool dashboard_is_on = true;
    //button centering ...
    public int buttons_x_corner = 25;
    public int buttons_y_corner = 25;
    public int buttonWidth = 40;
    public int buttonHeight = 40;
 
    // Start is called before the first frame update
    void Start()
    {
        
    }

    void activateDash(){
        this.dashboard.SetActive(true);
    }

    void deactivateDash(){
        this.dashboard.SetActive(false);
    }

     void OnGUI(){
        if(GUI.Button(new Rect(this.buttons_x_corner,this.buttons_x_corner,this.buttonWidth,this.buttonHeight), this.dashboardIcon)) 
        {
               if(this.dashboard_is_on){
                this.deactivateDash();
                this.dashboard_is_on = false;
            } else {
                this.activateDash();
                this.dashboard_is_on = true;
            }
        }		
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
