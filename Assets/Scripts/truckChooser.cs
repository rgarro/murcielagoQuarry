using System.Collections;
using System.Collections.Generic;
using UnityEngine;
/**
 *           o x o x o x o . . .
 *         o      _____            _______________ ___=====__T___
 *       .][__n_n_|DD[  ====_____  |    |.\/.|   | |   |_|     |_
 *      >(________|__|_[_________]_|____|_/\_|___|_|___________|_|
 *      _/oo OOOOO oo`  ooo   ooo   o^o       o^o   o^o     o^o
 *   -+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-
 *  Button Navigator Allowing to swap among 4 vehicles
 * 
 *
 * @author Rolando<rgarro@gmail.com> <https://emptyart.github.io>
 */
public class truckChooser : MonoBehaviour
{
    public string backHoeTag = "backHoeTag";
    public string loaderTag = "loaderTag";
    public string caterpillarTag = "catTag";
    public string truckTag = "loaderTag";

    protected bool loader_is_on = true;
    protected bool backHoe_is_on = false;
    protected bool caterpillar_is_on = false;
    protected bool truck_is_on = false;

    public GUISkin btnSkin;
    public Texture2D backHoeIcon;
    public Texture2D loaderIcon;
    public Texture2D caterpillarIcon;
    public Texture2D truckIcon;

    protected int buttons_x_corner = 150;



    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnGUI(){
        if(GUI.Button(new Rect(this.buttons_x_corner,20,40,40), this.backHoeIcon)){

        } 
    }

    void activateBackHoe(){

    }

    void deactivateBackHoe(){
        
    }

     void activateLoader(){

    }

    void deactivateLoader(){
        
    }
}
