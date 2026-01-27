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
     protected bool audio_is_on = true;
 
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

    // Update is called once per frame
    void Update()
    {
        
    }
}
